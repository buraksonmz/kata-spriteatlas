# Sprite Atlas Kata
In this Kata, draw calls and how to reduce them with sprite atlasses will be analyzed.

## Draw Call & Batching

![drawcall gif](https://github.com/buraksonmz/kata-spriteatlas/assets/141739960/9e99f171-c1db-4a26-8af9-d9068c206d33)

Draw call is a simply CPU saying GPU to draw something.  
When there are too many draw calls, the CPU can end up spending a significant amount of time waiting for the render thread to finish processing the graphics. 

**Disadvantages of high draw calls**  
Quick battery draining  
Device heat up  
Low performance & Lagging

**How to reduce draw calls**  
Low poly objects  
Friendly shaders  
Texture atlasses  
Dynamic and static batching  

## Sprite Atlas
A Sprite Atlas gathers several Textures into a single combined Texture. Unity can call this single Texture to issue a single draw call instead of multiple draw calls to access the packed Textures.

## Exercise
Create sprite atlas and assing textures with it. See how batching changes with "Stats" and "Frame Debugger"

**Install Sprite 2D**  
Install 2D Sprite from package manager

**Create Sprite Atlas**  
Create a sprite atlas and assign textures

**Load Textures**  
Load textures from sprite atlas in script

**Analyse Batching**  
Click "Stats" tab and see batching  
See batches from Frame Debugger: Window-Analysis-Frame Debugger
