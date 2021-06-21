using System;
using System.Collections.Generic;
using System.Text;

namespace NoughtsAndCrosses
{
    static class NoughtsAndCrossesHelper
    {
        public static Value ConvertPlayerTeamToCellValue(PlayerTeam playerTeam)
        {
            Value cellValueFromPlayerTeam = playerTeam switch
            {
                PlayerTeam.O => Value.O,
                PlayerTeam.X => Value.X,
                _ => throw new System.ArgumentException("Only accepted values of PlayerTeam should be provided.")
            };
            return cellValueFromPlayerTeam;
        }

        public static string ConvertCellValueToRendererValue(Cell cell)
        {
            switch (cell.value)
            {
                case Value.X:
                    return "X";
                case Value.O:
                    return "O";
                case Value.Empty:
                    return " ";
                default:
                    return " ";
            }
        }
    }
}
