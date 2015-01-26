Xcom2012SoldierViewer
=====================

Will be a program to view your XCom 2012 EW Long war soldiers.

WARNING:
When running the program in the VS debugger I found a strange bug where if the program crashes, the next few XCOM saves in game end up being 0kb. This isn't a huge deal for a non-Ironman campaign, just save the game over and over in an empty slot until you get a non-0kb save file, but this could be disasterous for an Ironman game.
If you're playing ironman I highly recommend copying the save to another directory.

Planned features:
Sort soldiers by name, stats or class.
Search soldiers by name, perks, equipment, class.
Filter by stats, perks or class.

Progress:
Completed:
Reversed engineered Strategy save file. (Saved from outside of a mission.)
Parsed soldier data into memory.
Create GUI.
Implement search/sort features

In progress:
Figure out what the parsed data means in game.
Write methods to convert the raw data into human readable information.

Future:
TBD.
