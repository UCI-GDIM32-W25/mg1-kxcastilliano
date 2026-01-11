[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Kai Castilliano, he/him

After comparing my team's original game breakdown with the breakdown created in class by Professor Reid, some parts of my original plan didn’t account for as many things as the Professor's. In my original, we had formatted it in a way that implied the Player and the Plant needed separate scripts, in contrast to the example breakdown, which placed the planting method within the player script. Another thing that my original breakdown lacked was a demonstration of how each system worked together. For example, in the UI we had to make sure it was tracking how many seeds were being planted in order for it;s logic to process, that being said the UI’s update method had to be called within the player scripts’ plantseed method in order for it to track the correct numbers. Apart from this, the breakdown is shown to be a useful and connecting tool when approaching the code. The breakdown establishes which methods need to be in what class and what pieces of code should be in what method (Example: in the player class within the update method the player’s movement code must be stored inside). The breakdown didn’t only account for code but the attributes showed what variables needed to be made for the class (Player class needed to assign a transform for movement, a spriterender, and an integer for number of seeds; Plant needed a spriterender.. etc..). 
In conclusion, the breakdown establishes the specific gameobjects needed from the scene, which gameobjects require a class/component to them,  their attributes (variables) and the methods that need to be called within the objects script. 



## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
