using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_2020_TeamCoding_Hierarchy_Shapes_
{
    [Flags]
    public enum Direction
    {
        NoAction = 0x00,

        Right = 0x01,
        Left = 0x02,
        Up = 0x04,
        Down = 0x08,

        MoveAction = Right | Left | Up | Down,
    }
}
