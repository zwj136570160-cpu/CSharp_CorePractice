using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇.游戏场景逻辑
{
    struct Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //贪吃蛇中，肯定是存在位置的比较
        //各个游戏对象，都会去比较位置是不是重合
        public static bool operator == (Position p1, Position p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Position p1, Position p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return false;
            }
            return true;
        }
    }
}
