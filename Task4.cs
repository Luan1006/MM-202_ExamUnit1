int[,] map = new int[42, 32];

map[40, 30] = 1;

enum Directions
{
    West,
    North,
    East,
    South
}

int curentDirection = 0;

List<(int, int)> crossroads = new List<(int, int)>();

bool teleported = false;

while (!AtGoal())
{
    int availableRoads = PeekAllDirections();

    if (availableRoads > 1)
    {
        crossroads.Add(CurrentPosition());

        MoveAvailableDirection();

        teleported = false;
    }
    else if (availableRoads == 1)
    {
        MoveAvailableDirection();

        teleported = false;
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

#endregion

#region Created functions

void MoveOnArray()
{
    var (currentX, currentY) = CurrentPosition();
    map[currentX, currentY] = 2;

    switch (curentDirection)
    {
        case (int)Directions.North:
            currentX--;
            break;
        case (int)Directions.East:
            currentY++;
            break;
        case (int)Directions.South:
            currentX++;
            break;
        case (int)Directions.West:
            currentY--;
            break;
    }

    map[currentX, currentY] = 1;
}

bool CheckForOpenCell()
{
    var (currentX, currentY) = CurrentPosition();
    switch (curentDirection)
    {
        case (int)Directions.North:
            currentX--;
            break;
        case (int)Directions.East:
            currentY++;
            break;
        case (int)Directions.South:
            currentX++;
            break;
        case (int)Directions.West:
            currentY--;
            break;
    }

    if (map[currentX, currentY] == 2)
    {
        return false;
    }

    return Peek();
}

void TurnAndChangeDirection()
{
    Turn();
    if (curentDirection == 3)
    {
        curentDirection = 0;
    }
    else
    {
        curentDirection++;
    }
}

int PeekAllDirections()
{
    int turnCount = 0;
    int availableRoads = 0;

    while (turnCount < 4)
    {
        if (CheckForOpenCell())
        {
            // Add the current cell to the list of crossroads.
            crossroads.Add(CurrentPosition());
            availableRoads++;
        }
        TurnAndChangeDirection();
        turnCount++;
    }

    return availableRoads;
}


(int, int) CurrentPosition()
{
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            if (map[i, j] == 1)
            {
                return (i, j);
            }
        }
    }

    return (-1, -1); // Return an invalid position if the current position is not found
}

void Teleport((int, int) position)
{
    var (currentX, currentY) = CurrentPosition();
    map[currentX, currentY] = 2;

    var (newX, newY) = position;
    map[newX, newY] = 1;
}

void MoveAvailableDirection()
{
    while (!CheckForOpenCell())
    {
        TurnAndChangeDirection();
    }

    MoveOnArray();
    Move();
}

#endregion