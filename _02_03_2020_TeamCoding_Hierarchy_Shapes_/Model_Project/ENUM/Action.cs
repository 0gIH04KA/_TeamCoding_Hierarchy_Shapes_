using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_2020_TeamCoding_Hierarchy_Shapes_
{
    public enum Action
    {
        NoAction = 0x00,

        ResizeIncrease = 0x01,
        ResizeReduction = 0x02,

        Tabulation = 0x04,

        PressExit = 0xFFFF,
    }
}
