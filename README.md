# Senior_Comps_Project
 
## Replication Instructions: How to run A Cocinar 
*IMPORTANT: Unfortunately this tutorial will only show how to run this tutorial on windows machines because testing on the Unity app isn’t directly supported on MacOS. To work on MacOS you would have to build the project everytime you want to test it.*

Step 1: Install Unity, make sure it is the Unity version 2021.3.9.f1

Step 2: In the Unity installs section, for the install you have, make sure to download the Android Build and Windows build support as well. 

Step 3: Download the [Oculus Developer](https://developer.oculus.com/downloads/package/oculus-developer-hub-win/) Hub to make sure you can use your headset as a developer. 

Step 4: Plug in your headset and make sure it is in [link mode](https://developer.oculus.com/documentation/unity/unity-enable-device/).

Step 5: Open Unity project, hit the play button at the top and try out a simple VR Unity project.

*IMPORTANT: You need to have your headset in link mode before you open A Cocinar, this is because otherwise when you play the game, it won’t load it on your headset.*

## Code Architecture:

### Project Organization:

*IMPORTANT: The folders with the * are the only ones that you will need to edit, the rest are settings or additional packages that do NOT need to be changed. The settings and additional packages are organized by Unity, the folders in bold were made by the creator to organize all the models, UI elements and scripts that were made into their respective folders. This folder organization is commonly used with Unity game development.*

├─ Assets/ <br>
│   ├─ *Animations/ - Animations for Hand Movements <br> 
│   ├─ *Materials/ - Materials used for all 3D objects <br>
│   ├─ *Models/ - Original Models of all 3D objects <br>
│   ├─ Physics/ Hulls - Hulls data create by Techie Collider <br>
│   ├─ *Prefabs/ - Prefabs used in Game <br>
│   ├─ Samples/ - Extra content from XR interaction Toolkit <br>
│   ├─ *Scenes/ - All scenes of the game <br>
│   ├─ *Scripts/ - Contains all the scripts used <br>
│   ├─ *Sprites/ - 2D images used in UI components <br>
│   ├─ Techie/ - External Package bought to create concave colliders <br>
│   ├─ Test Stuff/ - Models, Scenes and Scripts that are still being tested <br>
│   ├─ Textmesh/ - Textmesh files needed to have text in UI <br>
│   ├─ XR/ -  <br>
│   └─ XRI/ - XR Interactions Settings <br>
├─ Packages/<br>
│   └─ …<br>
├─ ProjectSettings/ <br>
│   └─ ... <br>
└─ readme.md<br>

### Script and gameObject Architecture: 

*IMPORTANT: This maps out how each type of script is used in the Scene of the game. Currently the game runs on one scene called “Working_V1”. For a script to be used it needs to be tied to an object in the Scene hierarchy of the game’s scene. Then when the game is played, Unity runs things from top to bottom based on the Scene’s hierarchy. This diagram shows how each script component, whether a specific script or a type of script (type is determined by the purpose it has for the game), ties to a specific game object or a type of game object (type is determined by what type of game object it is). For more specific on Unity’s Architecture go [here](https://github.com/UnityTechnologies/open-project-1/wiki/Game-architecture-overview)*

