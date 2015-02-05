# Ball-and-Cup-Trick
====================

This is a simulation of the ball and cup trick. The trick is to follow the cup with the ball, while the magician switches the cups around.

Unity Objects
=============

- One Sphere (Ball)
- Cubes to create a cup object (or import a cup model)
- One Cube (Table)
- One Directional Light
- One Camera
- One empty object

Unity Components
================

Add the CupMove.cs to the empty object.
Add animations to the three cup objects.
Add any textures and any skybox you'd like.

Unity Animations
================

There are six animations for each cup. Each animation is one second. The cup moves up or down the table in the z-axis, and half the distance it'll travel in the x-axis. Each animation has a "counterpart", meaning if cup 1 is switching with cup 2, then cup 1 will go up and right, while cup 2 goes down and left. The final positions should equal to other cup's position.
