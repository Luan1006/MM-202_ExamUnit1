while (!AtGoal())
{
    if (Peek())
    {
        Move();
        Paint();
    }
    else
    {
        Turn();
    }

    PeekAllDirections();
}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg counter clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

#endregion

#region Created functions

void PeekAllDirections()
{
    int turnCount = 0;

    while (turnCount < 4)
    {
        if (IsGoal())
        {
            Move();
        }

        Turn();

        turnCount++;
    }
}

bool IsGoal()
{
    // Returns true if the cell ahead is the goal cell.
    return true; // Just a placeholder value.
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

void Paint()
{
    // Paints the current cell. Making it a wall.
}

#endregion