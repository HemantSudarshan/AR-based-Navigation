using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class SetNavigationTarget : MonoBehaviour
{

    [SerializeField]
    private TMP_Dropdown navigationTargetDropdown;
    [SerializeField]
    private List<Target> navigationTargetObjects = new List<Target>();
    [SerializeField]
    private Slider navigationYOffset;
    private NavMeshPath path; // current calculated path 
    private LineRenderer line; // linerenderer to display path
    private Vector3 targetPosition = Vector3.zero; //current target position
    private int currentFloor = 1;
    private bool lineToggle = false;

    private void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
        line.enabled = lineToggle;
    }
    private void Update()
    {
        if (lineToggle && targetPosition != Vector3.zero)
        {
            NavMesh.CalculatePath(transform.position, targetPosition, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            Vector3[] calculatedPathAndOffset = AddLineOffset();
            line.SetPositions(calculatedPathAndOffset);
        }
    }

    public void SetCurrentNavigationTarget(int selectedValue)
    {
        targetPosition = Vector3.zero;
        string selectedText = navigationTargetDropdown.options[selectedValue].text;
        Target currentTarget = navigationTargetObjects.Find(x => x.Name.ToLower().Equals(selectedText.ToLower()));
        if (currentTarget != null)
        {
            if (!line.enabled)
            {
                ToggleVisibility();
            }

            targetPosition = currentTarget.PositionObject.transform.position;
        }
    }

    public void ToggleVisibility()
    {
        lineToggle = !lineToggle;
        line.enabled = lineToggle;
    }

    public void ChangeActiveFloor(int floorNumber)
    {
        currentFloor = floorNumber;
        SetNavigationTargetDropDownOptions(currentFloor);
    }

    private Vector3[] AddLineOffset()
    {
        if (navigationYOffset.value == 0)
        {
            return path.corners;
        }

        Vector3[] calculatedLine = new Vector3[path.corners.Length];
        for (int i = 0; i < path.corners.Length; i++)
        {
            calculatedLine[i] = path.corners[i] + new Vector3(0, navigationYOffset.value, 0);
        }
        return calculatedLine;
    }

    private void SetNavigationTargetDropDownOptions(int floorNumber)
    {
        navigationTargetDropdown.ClearOptions();
        navigationTargetDropdown.value = 0;

        if (line.enabled)
        {
            ToggleVisibility();
        }

        if (floorNumber == 1)
        {
            navigationTargetDropdown.options.Add(new TMP_Dropdown.OptionData("Washroom"));
            navigationTargetDropdown.options.Add(new TMP_Dropdown.OptionData("CST-Lab"));
            navigationTargetDropdown.options.Add(new TMP_Dropdown.OptionData("G016"));
            navigationTargetDropdown.options.Add(new TMP_Dropdown.OptionData("CST-HODCabin"));
            navigationTargetDropdown.options.Add(new TMP_Dropdown.OptionData("StairsExit"));
        }
        if (floorNumber == 2)
        {
            navigationTargetDropdown.options.Add(new TMP_Dropdown.OptionData("FirstFloorWashroom"));
            navigationTargetDropdown.options.Add(new TMP_Dropdown.OptionData("PlacementsCabin"));
            navigationTargetDropdown.options.Add(new TMP_Dropdown.OptionData("FirstFloorStairsExit"));
        }
    }
}
