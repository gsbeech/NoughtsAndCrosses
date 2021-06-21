namespace NoughtsAndCrosses
{
    class NoughtsAndCrossesGame
    {
        public Player[] Players { get; }

        public Board Board { get; }

        public int TurnNumber { get; set; } = 0;

        public NoughtsAndCrossesGame()
        {
            // Initial Game Setup
            // Create players
            Players = new Player[2];

            // Create the two players, each one will be assigned a team based on their playerNumber
            for (int i = 0; i < Players.Length; i++)
            {
                Players[i] = new Player(i);
            }

            // Create board
            Board = new Board();
        }

        /// <summary>
        /// Check if there are 3 cells with the same value either vertically, horizontally, or diagonally.
        /// </summary>
        /// <returns></returns>
        public bool IsGameFinished()
        {
            return (Board.IsHorizontalThreeInARow() || Board.IsDiagonalThreeInARow() || Board.IsVerticalThreeInARow());
        }

        public void RunGame()
        {
            while (!IsGameFinished())
            {
                if (TurnNumber == 9)
                {
                    GameRenderer.RenderGameState(Board);
                    System.Console.WriteLine("We have a draw!");
                }
                GameRenderer.RenderGameState(Board);
                if(TurnNumber % 2 == 0)
                {
                    int desiredCell = Players[0].GetNumpadIntegerFromPlayer();
                    Players[0].ClaimCell(desiredCell, Board);
                }
                else
                {
                    int desiredCell = Players[1].GetNumpadIntegerFromPlayer();
                    Players[1].ClaimCell(desiredCell, Board);
                }
                TurnNumber++;
            }   
            GameRenderer.RenderGameState(Board);
            System.Console.WriteLine("We have a winner!");
        }
    }
}
