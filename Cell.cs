using System;
using System.Collections.Generic;
using System.Text;

namespace NoughtsAndCrosses
{
    class Cell
    {
        public Value value { get; set; }
        public Cell()
        {
            value = Value.Empty;
        }

        public bool IsEmpty => value == Value.Empty;
    }
}
