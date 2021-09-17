# Conway's Game of Life

Conway's Game of Life made using c# in Unity game engine.

## Controls

Use **left or right mouse click** to select or drag which cells are alive.
Press **spacebar** to advance 1 generation or hold **enter** to advance multime genrations.
If you want to restart the simulation press **backspace**

If you want to increase or decrease the number of cell in the simulation use the GameManager gameobject located on the hierarchy.

You can also spawn certain patterns with quick shortcuts:

**LShift + 1** - Spawns a glider

## What is Game of Life

The game of life is a [cellular automaton](https://en.wikipedia.org/wiki/Cellular_automaton) created by [John Conway](https://en.wikipedia.org/wiki/John_Horton_Conway) and it consists in a 2D grid composed with cells that can, based on a few rules, live, die or multiply. Throughout the game the cells can form multiple patterns.

There are 4 rules in the Game Of Life:

* Any live cell with fewer than two live neighbours dies, as if by underpopulation.
* Any live cell with two or three live neighbours lives on to the next generation.
* Any live cell with more than three live neighbours dies, as if by overpopulation.
* Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
    


## License
[MIT](https://choosealicense.com/licenses/mit/)