# 3D Helicopter Simulation ![C#](https://img.shields.io/badge/C%23-v7.3-brightgreen) ![Unity](https://img.shields.io/badge/Unity-2019.2.8f1-lightgrey) ![PostProcess](https://img.shields.io/badge/Post-Processing-orange) ![TextMeshPro](https://img.shields.io/badge/-TextMeshPro-yellow)

## 1) Assembly of Helicopter Compound Body Collider Using Capsule Colliders

The Helicopter compound body collider is made of an assortment of resized, displaced, and rotated capsule colliders. Without those, dropping the helicopter from higher up would result in it falling through the base plane of the game world. The individual pieces of the compound collider are the fuselage, tail, mast, left skid, and right skid.
The mass of the R22 helicopter is set to 1 default.

<p align="center">
  <img src="https://github.com/antoine186/3D-Helicopter/blob/main/imgs/Heli%20Wireframe.PNG" alt="alt text" width=60% height=60%>
</p>

## 2) Implementation of the UFO rigid body and hovering physics.

The UFO's collider is implemented using a sphere collider. The hover position for this rigid body is placed at the very base of the UFO. The UFO has a mass of 1 and we implemented the hovering mechanics by allowing gravity to be applied to this rigid body. As soon as a distance threshold between the hover position and the floor plane is crossed, as measured by a vertical ray, we apply upwards force to the UFO scaled by the differential between the desired hover stationary distance to the ground and the current distance to the ground.

<p align="center">
  <img src="https://github.com/antoine186/3D-Helicopter/blob/main/imgs/GifMaker_20210212193515087.gif" alt="alt text" width=60% height=60%>
</p>

Here is the hovering mechanism when challenged in an interesting way:

<p align="center">
  <img src="https://github.com/antoine186/3D-Helicopter/blob/main/imgs/GifMaker_20210212200823996.gif" alt="alt text" width=60% height=60%>
</p>

The above rotational displacement was achieved by keeping a time counter from the start of the game and using that as an input to both the cosine and the sine function each respectively applied to the forward axis and the right axis of the UFO rigid body.
