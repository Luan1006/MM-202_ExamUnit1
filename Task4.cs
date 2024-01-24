List<(int, int)> crossroads = new List<(int, int)>();

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
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

(int, int) CurrentPosition()
{
    // Returns the current cell Position.
    return (0, 0); // Just a placeholder value.
}

void Remember(int x, int y)
{
    // Remembers the current cell Position.
}

#endregion