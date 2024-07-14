
# Augmented Reality Based College Campus Indoor Navigation

While GPS is widely used for outdoor navigation, it falls short indoors. While some maps are available on campus, users do not receive continuous assistance to reach their destinations. They may attempt to plan their routes using these static maps, but once they begin walking in their intended direction, they lack ongoing guidance. Indoor navigation often requires expensive additional hardware. This project explores techniques for indoor campus
positioning, pathfinding, and route guidance. Our project's goal is to introduce a cost-effective indoor campus navigation system. Our solution utilizes the built-in sensors in mobile devices to pinpoint user location and combines them with AR technology to provide an immersive navigation experience.

## Problem Statement

● Navigating inside campus, particularly for
newcomers, is challenging due to limited guidance
and the absence of effective navigation systems.

● Need for a AR based navigation experience for
better visualization and understanding of the route
compared to 2D Maps or boards.

## What our Project does ?

● Our project aims to create an affordable and
user-friendly indoor Campus navigation system by
utilizing the sensors in mobile devices.

● We will develop a mobile apk that integrates with
AR Foundation for precise indoor positioning and
ARCore for real-time AR guidance.

● Users will have the option to choose their desired destination within the campus, and they will receive AR-based navigation to enhance their visual user experience.


DEMO
https://drive.google.com/file/d/1B2-8Cle-puHzyLFyF4TKFIU4lam_t-8x/view?usp=sharing
https://drive.google.com/file/d/1m06XlJSwsNdr6q3A0fEw_5qdlNmrp7jf/view?usp=sharing

### Literature Survey

The following link contains the Literature survey's of few research papers related to this project - 
https://docs.google.com/document/d/1QqfRV16re0NvfmY8iGACqnWsCJHELwkcPTNeZt0ApgU/edit?usp=sharing

<br></br>

## Design

There are three stages in this project

<img src="https://github.com/CapstoneProjectDSU/Augmented-Reality-Based-indoor-College-Campus-Navigation/assets/149241928/c36bd865-d831-4510-acfc-ed32a1ebc695" width="350" height="530">
<img src="https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/efd4fdd3-534d-4326-bd7e-4ee533d24b95" width="350" height="530">
<br></br>

i) **Mapping** - Campus indoor floor is designed and the 3D environment is created using Unity. The attributes and scaling must be accurate.

ii) **Localization** - There are various ways to detect the user location without the help of GPS such as :

● Beacons - A Bluetooth beacon is a small wireless device that works based on Bluetooth Low Energy. These are small devices which need to be purchased and placed all over the campus. It helps to calculate the user location and guide them accordingly. (Accuracy - 5 meters)

    Pros - Easy setup
    Cons - Expensive and not feasible inside campus.

● Visual positioning system (VPS) - Uses smartphone camera to analyze the surrounding and determine user location

    Pros - Automated and accurate.
    Cons - It is complicated to set up and configure. We need create our own datasets 
           and train artificial intelligence models to recognize environments.

● Visual Markers - It is an image which the system can recognize. It must be a unique and asymmetric image so that the system can understand from which side it is viewing the marker.

    Pros - Highly accurate and easy to set up.
    Cons - Periodic rescanning.

We use Visual Markers technology in our project since it is cost effective and highly accurate. 
Visual markers are helpful for ensuring IPS (indoor positioning system) accuracy. Each marker has its own unique ID. These markers tell the user's position in 3d space.

iii) **Visualization** - Visualization is about presenting information to the user in an understandable and intuitive manner, combining the digital and physical worlds.

● AR Rendering: We use AR Foundation to render AR content, such as directional lines, blips, or labels, in the user's view based on their position and the target location.

● Minimap Display: Created a minimap that shows an overview of the indoor environment and indicates the user's position and the target location as blips.

● UI Elements: Design and display user interface elements for start and target selection, navigation controls.

In this visualization stage, we provide the user with an AR-enhanced view that guides them from the start point to the target point, incorporating elements like directional lines, minimaps, and user interface components.

## AR Based Campus Indoor Navigation Architecture 

![IndoorNavArchitectureDiagram](https://github.com/CapstoneProjectDSU/Augmented-Reality-Based-indoor-College-Campus-Navigation/assets/149241928/a9fd980d-4d0f-4649-a1ea-e2a14903ccd3)

# App Overview

● The app helps in providing AR Based Navigation for the Campus.

● It provides you with the Shortest path to your destination.

● Features QR Code Recentering which helps in accurate reposition of User Start Point.

● You can toggle line visibility and also Adjust the line height.

● Built with AR Core and XR Origin which helps in AR Motion tracking of the user movement.


![FeaturesShowcase](https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/7ff54842-91b3-4e26-93a3-834203b1c762)




### Unity Game Engine

**Campus Floor Map Model and App UI**

<img src="https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/4c1e010c-6bb6-4486-80fb-604d74f92c89" width="900" height="500">
<br></br>

**The floor map was converted into 3D Model Environment using 3D Objects such as Floor and Walls**

![Screenshot 2023-10-27 224239](https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/3b66a038-0c60-4a0f-9fb0-5da26f72f8ec)
![Screenshot 2023-10-28 113305](https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/1c196c1c-ad61-4f48-b564-453f12593901)


**The walls are occluded so that it doesnt appear in our AR Cam and stays invisible**

![Screenshot 2023-10-28 113456](https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/3c1015c7-afd3-462b-a207-9dfe4ee46acc)


**Nav Mesh - The Nav Bake agent helps in detecting the open area (traversable path) inside the floor map**

![Screenshot 2023-10-27 225843](https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/ebcde5a8-5e2b-4cda-ad89-7e3713bef0e5)

**The mini map blip is rendered with help of a top down camera**

![Screenshot 2023-10-27 233629](https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/9f22070e-b1d7-4c1b-9ffc-17b5510531c3)

### To Build and Run the apk in Andriod Phone

Step 1 - Connect the andriod phone using the usb cable to the laptop.

Step 2 - Activate developer mode in andriod and turn on USB Debugging.

Step 3 - This will create a wired connection to our laptop and the device will be detected by unity.

Step 4 - Since we need a wireless connection to navigate. We can you the following commands in the terminal to connect the phone wirelessly

![Screenshot 2023-10-28 150257](https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/f5db0749-baf8-4826-882d-41400d19da4c)

### Output Screen



https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/04aacb6d-0c0b-49cf-8fed-3dc6d322496e



https://github.com/DSU-cst/AR-Based-Indoor-College-Campus-Navigation/assets/149241928/8aecf599-9d80-4282-89bc-7a4254d96ef2




## Frameworks and Packages used 

1. AR Foundation
2. AR Core
3. AI Navigation
4. AR Session
5. XR Origin
6. ZXing.Net.0.16.8.0

## Software Requirements

1. Unity Hub and Editor 2023.15
2. Java JDK 11.0.14.1 or above
3. Andriod SDK Tools
4. Andriod NDK 23.1.7779620
5. Gradle 7.3.3 or above





