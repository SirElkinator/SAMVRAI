# SAMVRAI
Game Synopsis


Welcome to SamVRai, for centuries the Honifusho Valley has been a center for peaceful living and farming…until reports about the serpent cult invading the sacred dojo were confirmed with many going missing not to return. You have been selected as the next samurai to try and investigate these disappearances, as you approach the dojo a sense of dread fills your heart. Everything still seems to be as normal, but something feels off. As you enter the front doors of the dojo you notice two katanas on the ground...


About the Game


	Samurai VR, henceforth known as SamVRai, is a virtual reality game for the HTC VIVE developed in Unity version 2018.2.12f1 by Jacksonville State University students Chase Sparks, Paul Zachos, Dalton Murphree, Adam Newton and Joshua Luce. Dr. David Thornton was mentor over the project. Originally planned as a controller-based sword fighting game, the group eventually decided it could easily be developed into a VR game. The objectives are relatively simple: Avoid the flying projectiles by deflecting them with swords attached to the two VIVE controllers. To score points, hit them back at the enemies that threw them.
	The terrain and different natural map features were designed in Unity’s various elements. The code was written in C#. The Dojo itself and several objects in the game including the enemies, were designed in the program Blender and are saved as .blend files. While most of the game was created completely from scratch, a few things were borrowed from online sources such as object textures, audio files and the VR API called VRTK. These have all been sourced back to the original files in the “Credits” section.
	On February 15th, 2019 the development team presented SamVRai to a panel of judges and JSU Faculty as well as many audience members. The game obtained overall good reception and had two viewers come forth to test it. This is documented on YouTube under the profile JSU Student Symposium.


Navigation


	Notice
	
	Under the “GameObjects” folder inside “Assets”, viewable are the Blender objects within “Blender”. It is important to note for these to display properly, Blender must be installed on the computer it is being run from. It is recommended to download Blender before the game is installed or opened the first time.
	
	Overview
	
Every item in the game is stored under the “Assets” folder. This includes three scenes IntroScreen, Scene1 and Credits. To start the game, open the IntroScreen scene in Unity and drag the other two scenes into Hierarchy tab. Then press the play button in the top middle of the screen. 
	Any item that has been borrowed from the Unity Asset store is saved in “Downloaded”. VRTK is stored in “Plugins”, and all programming C# scripts are enclosed in “Scripts”. Audio Files are in “Sounds” and are categorized by “Sound Effects” and “Music”. All enemy models are under the folder “Combat”.
	
	Combat
	
	This folder houses the multiple enemy models throughout the game. There are currently three models that each have different attributes, “doorenemy” is the ninja that comes through the door under the stairs, while “stairsenemy” appears at the door atop the staircase. These act differently in some ways, but they both approach the character when they are on the ground and throw shurikens every five seconds. The “trapdoorenemy” rises and lowers from the trapdoor on the southeast corner of the Dojo, at its peak height it will throw a shuriken as well. All have the “enemybehavior” script attached to them that inscribes that if they come in contact with objects tagged with shuriken or sword they will destroy themselves and the characters killcount will increment. In the Heirarchy an object called “Spawner” is used with a script attached to randomly choose two of the three enemies at any given moment. This folder also contains the model for the katanas, the shurikens, the smoke effect, the base model for the enemy, and the animation object. Currently the animator only has a throw animation, however others could be attached to it. 
	
	Downloaded
	
	As stated the Downloaded section has files saved from Unity and the Asset Store, it does not include things downloaded from online websites. The first folder under downloaded is [BFW]SimpleDynamicClouds. This contains the models, scripts, and effects for the clouds in the game. In the Heirarchy this is entered as Clouds > Low and High. The object labeled “Character” is not actually the playable character nor is it an enemy, it is just the model for the brown dummy object viewed inside the Dojo. “Unity Assets” are things that are preincluded when Unity is installed on the computer, they were not purchased from the asset store but downloaded inside Unity itself. The two dragon folders just include simple decorative things that were inserted into the game, such as the dragon statue on top of the mountain.
	
	Scripts
	
	This is where the logic of the game is at, everything inside this folder is a C# file. The team has broken it up into four sections: “EnemyAI”, “Map”, “Player” and “SoundScripts”. EnemyAI has aforementioned scripts from combat as they control the enemies. There is also a script labeled Knife that corresponds to the shuriken movement. It tells it to spin and move towards the headset when instantiated. Map uses scripts that help make the game run, there are some that switch between the scenes and some that make objects move. There is a script that makes the two waterfalls work, and one that turns the camera in the introscreen. An attempt to make the trapdoor rise and fall upon the Trapdoor enemy entering and exiting is seen in the trapdoor script and this is planned to be further worked on as it was not complete by presentation time. Player has two scripts that control the characters health when they are hit with a star, and turn the VR headset screen a reddish hue upon contact. The Soundscripts file startmusic generates a random number then picks one of the four songs in the game that corresponds to that number, this is to keep the game from always starting on the same song.
	
	GameObjects
	
	As described in the notice section, every three dimensional .blend file is saved under this category. As well as every material made in Unity and Blender, and every texture applied to objects in the game. These were the textures borrowed from the internet. The terrain files are saved under here, there is one for the foreground and one for the background. The three tree models which were developed in Unity are inside the trees folder of GameObjects.
