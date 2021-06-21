namespace NoughtsAndCrosses
{
    class Board
    {
        public Cell[,] boardCells { get; }

        public Board()
        {
            boardCells = new Cell[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardCells[i,j] = new Cell();
                }
            }
        }

        /// <summary>
        /// If the cell at the selected board reference is empty, change the value of the cell to that of the player making the move's team
        /// </summary>
        /// <param name="player"></param>
        /// <param name="numpadInteger"></param>
        public void SetCellValueForPlayer(Player player, int numpadInteger)
        {
            (int, int) boardReference = GetBoardReferenceFromNumpadInteger(numpadInteger);
            Value cellValueForCallingPlayer = NoughtsAndCrossesHelper.ConvertPlayerTeamToCellValue(player.team);

            if (IsSelectedCellEmpty(numpadInteger))
            {
                boardCells[boardReference.Item1, boardReference.Item2].value = cellValueForCallingPlayer;
            }
            else
            {
                throw new System.ArgumentException("Selected cell is already claimed by a player");
            }            
        }


        /// <summary>
        /// Checks if the selected cell is empty
        /// </summary>
        /// <param name="numpadInteger"></param>
        /// <returns></returns>
        public bool IsSelectedCellEmpty(int numpadInteger)
        {
            (int, int) boardReference = GetBoardReferenceFromNumpadInteger(numpadInteger);

            return (boardCells[boardReference.Item1, boardReference.Item2].IsEmpty);
        }

        /// <summary>
        /// Maps each number on the numpad to a Cell reference in the Board
        /// </summary>
        /// <param name="numpadInteger"></param>
        /// <returns></returns>
        private (int, int) GetBoardReferenceFromNumpadInteger(int numpadInteger)
        {
            (int, int) boardReferenceFromNumPadInteger = numpadInteger switch
            {
                7 => (0, 0),
                8 => (0, 1),
                9 => (0, 2),
                4 => (1, 0),
                5 => (1, 1),
                6 => (1, 2),
                1 => (2, 0),
                2 => (2, 1),
                3 => (2, 2),
                _ => throw new System.ArgumentException("Unacceptable input - only numbers on the numberpad can be used (1-9)")
            };
            return boardReferenceFromNumPadInteger;
        }

        /// <summary>
        /// Iterates over each row and returns true if all three Cells in a column share the same claim value and aren't empty
        /// </summary>
        /// <returns></returns>
        public bool IsHorizontalThreeInARow()
        {
            for (int i = 0; i < 3; i++)
            {
                if (!boardCells[i, 0].IsEmpty && boardCells[i, 0].value == boardCells[i, 1].value && boardCells[i, 1].value == boardCells[i, 2].value)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Iterates over each column and returns true if all three Cells in a column share the same claim value and aren't empty
        /// </summary>
        /// <returns></returns>
        public bool IsVerticalThreeInARow()
        {
            for (int i = 0; i < 3; i++)
            {
                if (!boardCells[0, i].IsEmpty && boardCells[0, i].value == boardCells[1, i].value && boardCells[1, i].value == boardCells[2, i].value)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Both elements of the conditional refer to the references on the board of the two diagonals (bottom left to top right, top left to bottom right)
        /// </summary>
        /// <returns></returns>
        public bool IsDiagonalThreeInARow()
        {
            if ((!boardCells[0, 0].IsEmpty && boardCells[0, 0].value == boardCells[1, 1].value && boardCells[1, 1].value == boardCells[2, 2].value) || 
                    (!boardCells[2, 0].IsEmpty && boardCells[2, 0].value == boardCells[1, 1].value && boardCells[1, 1].value == boardCells[0, 2].value))
            {
                return true;
            }
            return false;
        }
    }
}
