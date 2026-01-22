You can choose program and grid presets with the two dropdown menus in the top left

The textbox under the commands is for errors
The textbox on the right is the output of the program. All the commands that were executed
The character starts on the top left tile and faces east.

Loading a custom grid or program can be done using their respective options in the drowdown menus.

Formatting of programs:
- Indenting is done using four spaces
- Every command is written on a new line

Valid commands:
- Move (times)            "Move 4"
- Turn (left or right)    "Turn left"
- Repeat (times)          "Repeat 4"

- RepeatUntil (condition)
	- "RepeatUntil wall"       - repeats the indented block until the next command would collide with a wall
	- "RepeatUntil edge"       - repeats the indented block until the next command would go off the grid

Formatting of custom grids:
- 'o' is an open tile
- '+' is a blocked tile
- 'x' is an endstate tile (a finish for pathfinding puzzles)

Examples:

Program:
---------------------
Move 4
turn left
Repeat 3
    Turn right
	Move 2
	Repeat 2
	    Move 2
Turn left
RepeatUntil edge
    Move 3
	Turn left
---------------------

Grid:

---------------------
oo++++
oooo++
+oooo+
++oooo
+++ooo
++++ox
---------------------