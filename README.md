# MM-202_ExamUnit1
This is my submission for MM-202 Exam Unit 1: [Basic Redux](https://github.com/CodeCraftCurriculum-II/module_basics_redux_I/)

The task was to make a pseudo-esque code to find the end of a labyrinth given four building blocks:
1. Move
2. Turn
3. Peek
4. AtGoal

And the possibility to add extra methods.

## Task1

How I solved task 1 was by going until we reached a wall and then turning 90 degrees while we painted each cell we have previously gone to. The paint will essentially function like a wall and makes the car unable to move where the paint has been. We continue to check if we are at the goal.

## Task2

Task 2 was a bit simpler as it's a spiral. I created a while-loop and just went until we hit a wall, then turn and repeat until we are at the finish line.

## Task3

For task 3 I used the same solution as task 1.

## Task4

This one was a bit tricky. For this I wanted to implement some sort of pathfinding algorihtm. However, unless I create a car duplicator, many of the algorithms don't really make any sense. I then started to think about how to complete the task.

If we use the while-loops from Task1 and Task3. We first go straight and hit a dead end, we then turn forever as the start is now painted. This means we would need some sort of backtracking feature.

I then decided to make the car backtrack if we were in a crossroad. Meaning that for each position the car is at we look at all directions. I then created a method that returns the current position in X and Y coordinates and a list to store the coordinates to these crossroads. My thought was to treat this list as a stack and each time we backtrack we pop the stack. This will make it impossible to not find the solution (unless its an impossible labyrinth) however the solution it finds might not be the most optimal one.