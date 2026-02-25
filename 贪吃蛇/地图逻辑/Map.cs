using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.Game对象和场景更新接口;
using 贪吃蛇.游戏场景逻辑;

namespace 贪吃蛇.地图逻辑
{
    class Map : IDraw
    {
        public Wall[] walls;

        public Map()
        {
            walls = new Wall[GameClass.w + (GameClass.h - 3) * 2];
            int index = 0;
            for (int i = 0; i < GameClass.w; i += 2)
            {
                walls[index] = new Wall(i, 0);
                ++index;
            }

            for (int i = 0; i < GameClass.w; i += 2)
            {
                walls[index] = new Wall(i, GameClass.h - 2);
                ++index;
            }

            for (int i = 1; i < GameClass.h - 2; i++)
            {
                walls[index] = new Wall(0, i);
                ++index;
            }

            for (int i = 1; i < GameClass.h - 2; i++)
            {
                walls[index] = new Wall(GameClass.w - 2, i);
                ++index;
            }
        }

        public void Draw()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].Draw();
            }
        }
    }
}
