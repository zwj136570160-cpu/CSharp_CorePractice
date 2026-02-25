using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.Game对象和场景更新接口;
using 贪吃蛇.蛇;

namespace 贪吃蛇.游戏场景逻辑
{
    class Food : GameObjectClass
    {
        public Food(Snake snake)
        {
            RandomPos(snake);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("¤");
        }
        
        //随机位置的行为和蛇的位置有关系
        public void RandomPos(Snake snake)
        {
            Random random = new Random();
            int x = random.Next(2, GameClass.w / 2 - 1) * 2;
            int y = random.Next(1, GameClass.h - 4);
            pos = new Position(x, y);
            //得到蛇
            //如果重合，就会进If语句
            if (snake.CheckSamePos(pos))
            {
                RandomPos(snake);
            }
        }
    }
}
