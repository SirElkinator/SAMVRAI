# SAMVRAI
Game Synopsis

  Welcome to SamVRai, for centuries the Honifusho Valley has been a center for peaceful living and ... ...until rumors about the serpent cult invading the sacred dojo were confirmed with many going missing not to return. You have been selected as the next samurai to try and get to the bottom of these disappearances, as you approach the dojo a sense of dread fills your heart. Everything still seems to be as normal, but something feels off. As you enter the front doors of the dojo you notice two katanas on the ground...

About the Game
	
   Samurai VR, henceforth known as SamVRai, is a virtual reality game for the HTC VIVE developed in Unity version 2018.2.12f1 by Jacksonville State University students Chase Sparks, Paul Zachos, Dalton Murphree, Adam Newton and Joshua Luce. Originally planned as a controller-based sword fighting game, the group eventually decided it could easily be developed into a VR game. The objectives are relatively simple: Avoid the flying projectiles by deflecting them with swords attached to the two VIVE controllers. To score points, hit them back at the enemies that threw them.
  The terrain and different natural map features were designed in Unity’s various elements. The code was written in C#. The Dojo itself and several objects in the game including the enemies, were designed in the program Blender and are saved as .blend files. While most of the game was created completely from scratch, a few things were borrowed from online sources such as object textures, audio files and the VR API called VRTK. These have all been sourced back to the original files in the “Credits” section.
  On February 15th, 2019 the development team presented SamVRai to a panel of judges and JSU Faculty as well as many audience members. The game obtained overall good reception and had two viewers come forth to test it. This is documented on YouTube under the profile JSU Student Symposium.
  
Navigation
	
  Notice
	
  Under the “GameObjects” folder inside “Assets”, viewable are the Blender objects within “Blender”. It is important to note for these to display properly, Blender must be installed on the computer it is being run from. It is recommended to download Blender before the game is installed or opened the first time.
	
  Overview
  
  Every item in the game is stored under the “Assets” folder. This includes three scenes IntroScreen, Scene1 and Credits. To start the game, open the IntroScreen scene in Unity and drag the other two scenes into Hierarchy tab. Then press the play button in the top middle of the screen. 
  Any item that has been borrowed from the Unity Asset store is saved in “Downloaded”. VRTK is stored in “Plugins”, and all programming C# scripts are enclosed in “Scripts”. Audio Files are in “Sounds” and are categorized by “Sound Effects” and “Music”. All enemy models are under the folder “Combat”.












  Combat
  
  This folder houses the multiple enemy models throughout the game. There are currently three models that each have different attributes, “doorenemy” is the ninja that comes through the door under the stairs, while “stairsenemy” appears at the door atop the staircase. These act differently in some ways, but they both approach the character when they are on the ground and throw shurikens every five seconds. The “trapdoorenemy” rises and lowers from the trapdoor on the southeast corner of the Dojo, at its peak height it will throw a shuriken as well. All have the “enemybehavior” script attached to them that inscribes that if they come in contact with objects tagged with shuriken or sword they will destroy themselves and the characters killcount will increment. This folder also contains the model for the katanas, the shurikens, the smoke effect, the base model for the enemy, and the animation object. Currently the animator only has a throw animation, however others could be attached to it.
  
  Downloaded
	
  Scripts
	
  GameObjects
