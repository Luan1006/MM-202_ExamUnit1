class Task5
{
    void Main()
    {
        while (!AtGoal())
        {
            TurnCounterClockwise();
            if (Peek())
            {
                Move();
            }
            else
            {
                Turn();
                if (Peek())
                {
                    Move();
                }
                else
                {
                    Turn();
                    Move();
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
            // Turns the car 90 deg counter clockwise.
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

        #region Created Functions

        void TurnCounterClockwise()
        {
            for (int i = 0; i < 4; i++)
            {
                Turn();
            }
        }

        #endregion
    }
}