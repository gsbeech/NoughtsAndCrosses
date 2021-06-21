namespace NoughtsAndCrosses
{
    class Player
    {
        public PlayerTeam team { get; }
        public int playerNumber { get; }

        public Player(int number)
        {
            playerNumber = number;
            if (playerNumber == 0)
            {
                team = PlayerTeam.O;
            }
            else
            {
                team = PlayerTeam.X;
            }
        }

        public void ClaimCell (int selectedCellNumber, Board board)
        {
            board.SetCellValueForPlayer(this, selectedCellNumber);
        }

        public int GetNumpadIntegerFromPlayer()
        {
            System.Console.WriteLine("Please enter the number on the numberpad corresponding to the square you would like to claim!");
            return int.Parse(System.Console.ReadLine());
        }

        public bool CheckIfCellIsAlreadyClaimed(int numpadInteger, Board board)
        {
            return board.IsSelectedCellEmpty(numpadInteger);
        }
    }
}
