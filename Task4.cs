/*
This is essentially a DFS algorithm. The algorithm is not very efficient, but it works for the given map.
My reasoning is that we can not duplicate the car, so we have to keep track of the crossroads we have visited.
*/

List<(int, int)> crossroads = new List<(int, int)>();

bool teleported = false;

while (!AtGoal())
{
    int availableRoads = PeekAllDirections();

    if (availableRoads > 1)
    {
        crossroads.Add(CurrentPosition());

        while (!Peek())
        {
            Turn();
        }

        Move();
    }
    else if (availableRoads == 1)
    {
        Move();
    }
    else
    {
        if (teleported)
        {
            crossroads.RemoveAt(crossroads.Count - 1);
            if (crossroads.Count > 0)
            {
                Teleport(crossroads[crossroads.Count - 1]);
            }
        }
        else
        {
            Teleport(crossroads[crossroads.Count - 1]);
            crossroads.RemoveAt(crossroads.Count - 1);
            teleported = true;
        }
    }
}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    Paint();
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

int PeekAllDirections()
{
    int turnCount = 0;
    int availableRoads = 0;

    while (turnCount < 4)
    {
        if (Peek())
        {
            // Add the current cell to the list of crossroads.
            crossroads.Add(CurrentPosition());
            availableRoads++;
        }
        Turn();
        turnCount++;
    }

    return availableRoads;
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

void Teleport((int, int) position)
{
    // Teleports the car to the given position.
}

#endregion