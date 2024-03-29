﻿class Task1 {
    void Main()
    {
        int turnNumber = 1;
        int counter = 0;

        while (!AtGoal())
        {
            if (Peek())
            {
                Move();
                continue;
            }

            TurnBasedOnCounter(turnNumber);
            counter++;

            if (counter == 2)
            {
                counter = 0;
                turnNumber++;
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

        void TurnLeft()
        {
            for (int i = 0; i < 4; i++)
            {
                Turn();
            }
        }

        void TurnBasedOnCounter(int turnNumber)
        {
            if (turnNumber % 2 != 0)
            {
                Turn();
            }
            else
            {
                TurnLeft();
            }
        }

        #endregion
    }
}