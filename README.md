#  Creative Making-2

## Final Project - Car Race

In this project I have created a racing game which is connected to an Arduino and uses potentiometer to control the direction and ultrasonic sensor to control the speed, as well as adding light sensor and vibration motor.



<img src="https://github.com/Meng-73/Making-2/blob/main/image/1.png" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/1-1.png" width="60%">


*&nbsp;*

*&nbsp;*

### 1. Ultrasonic Sensor, Potentiometer

Firstly, I connected the Arduino to an ultrasonic sensor and a potentiometer to control the speed of the car, and the direction of the car respectively.The higher the value of the distance sensor, the faster the car will go. Whenthe potentiometer is turned to the right, the car will also travel to the right.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/2.JPG" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/2-1.png" width="60%">


The settings of the car can be changed by adjusting the variables I have defined in Unity.

<img src="https://github.com/Meng-73/Making-2/blob/main/image/2-2.JPG" width="60%">

*&nbsp;*

*&nbsp;*

### 2. Light Sensor

I then added light sensors to control the brightness of the sky in the game to allow the player to become more immersed in the game. For example, if you play the game in a dark room, the scenes in the game will also be dark.

<img src="https://github.com/Meng-73/Making-2/blob/main/image/3.JPG" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/3-1.png" width="60%">

This is how the light changes in the game when I cover the light sensor with my hand.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/3-2.png" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/3-3.png" width="60%">


*&nbsp;*

*&nbsp;*

### 3. Vibration Motor

After this I added a vibration motor and put it on the back of the steering wheel. When the car hits an obstacle, the vibration motor will vibrate and the steering wheel will vibrate with it, which will give the player an immersive gaming experience.

<img src="https://github.com/Meng-73/Making-2/blob/main/image/4.JPG" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/4-1.png" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/4-2.png" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/4-3.png" width="60%">

*&nbsp;*

*&nbsp;*

### 4. Road

I have created ten prefabs for roads, thus creating a random endless road. When the car passes a section of road, a new section of road will randomly appear at the end of the road, while the roads it has passed will be destroyed. The game frame will always have three sections of road.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/6.JPG" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/6-1.png" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/6-2.JPG" width="60%">

These are a few of my road prefabs.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/6-3.JPG" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/6-4.JPG" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/6-5.JPG" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/6-6.JPG" width="60%">

*&nbsp;*

*&nbsp;*

### 5. Score

I have added some coins to the roads and a score record in the top left corner of the game screen. When a car hits a coin, the coin will disappear and increase the score. When the car hits an obstacle, the score will be reduced. When the score is zero, the game will end when another collision occurs.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/5.png" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/5-1.png" width="60%">

I added a collision effect that makes a blue flame, and a destruction effect that makes a red explosion, respectively.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/5-2.png" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/5-3.png" width="60%">

*&nbsp;*

*&nbsp;*

### 6. Menu

I have added a main menu scene to this game scene which contains buttons to start the game and end the game. Clicking on start game will jump the screen to the game scene and start the game, clicking on end game will exit the game.Also I have set the button effect so that the colour of the button will change when the mouse hovers over it.Also, I have created an end of game scene containing a button to start again and a button to end the game.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/7.png" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/8.JPG" width="60%">

The game contains two scenes.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/8-1.JPG" width="60%">

*&nbsp;*

*&nbsp;*

### 7. Audio

Finally, I have added sounds to this game. This includes the overall soundtrack of the game, the sound of picking up coins, the sound of hitting an obstacle, the sound of the game ending, and the sound of clicking a button.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/9.JPG" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/9-1.JPG" width="60%">

I write the code to make them play at the right time.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/9-2.png" width="60%">


<img src="https://github.com/Meng-73/Making-2/blob/main/image/9-3.png" width="60%">


*&nbsp;*

*&nbsp;*

### 8. Appearance
I ended up making a steering wheel that was assembled with the potentiometer that controls the direction. To make this game a better experience and to make it looks cooler.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/10.JPG" width="60%">

*&nbsp;*

*&nbsp;*

## Video

This is the video presentation of the final project.


<img src="https://github.com/Meng-73/Making-2/blob/main/image/11.png" width="60%">
