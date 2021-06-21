using System;
using System.Collections.Generic;
using System.Text;

namespace NoughtsAndCrosses
{
    static class GameRenderer
    {
        public static void RenderGameState(Board board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var valueToWriteToConsole = NoughtsAndCrossesHelper.ConvertCellValueToRendererValue(board.boardCells[i, j]);
                    Console.Write($"| {valueToWriteToConsole} |");
                }
                Console.WriteLine("");
                Console.Write("---------------");
                Console.WriteLine("");
            }
        }
    }
}
