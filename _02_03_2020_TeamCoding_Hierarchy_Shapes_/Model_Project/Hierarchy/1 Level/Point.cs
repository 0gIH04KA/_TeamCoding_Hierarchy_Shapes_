using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_2020_TeamCoding_Hierarchy_Shapes_
{
    class Point
    {
        #region ---===    Private    ===---

        private int _positionX;
        private int _positionY;

        #endregion

        #region ---===    Get / Set    ===---

        public int PosX
        {
            get
            {
                return _positionX;
            }
            set
            {
                if (value < 0)
                {
                    throw new PositionX_InvalidException($"Negatige set X = {value}");
                }

                if (value > Constant.MAX_WIDTH)
                {
                    throw new PositionX_InvalidException($"Set X is more than maximum number of rows = {value}");
                }

                _positionX = value;
            }
        }

        public int PosY
        {
            get
            {
                return _positionY;
            }
            set
            {
                if (value < 0)
                {
                    throw new PositionY_InvalidException($"Negatige set Y = {value}");
                }

                if (value > Constant.MAX_HEIGHT)
                {
                    throw new PositionY_InvalidException($"Set Y is more than maximum number of columns = {value}");
                }

                _positionY = value;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Point(int x, int y)
        {
            PosX = x;
            PosY = y;
        }

        public Point(Point point)
            : this(point.PosX, point.PosY)
        {
        }

        #endregion
    }
}
