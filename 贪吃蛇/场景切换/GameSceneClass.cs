using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.Game对象和场景更新接口;
using 贪吃蛇.地图逻辑;
using 贪吃蛇.游戏场景逻辑;
using 贪吃蛇.蛇;

namespace 贪吃蛇.场景切换
{
    class GameSceneClass : ISceneUpdate
    {
        Map map;
        Snake snake;
        Food food;
        int updateIndex = 0;

        public GameSceneClass()
        {
            map = new Map();
            snake = new Snake(10, 10);
            food = new Food(snake);
        }

        public void Update()
        {
            if (updateIndex % 10000 == 0)
            {
                map.Draw();
                food.Draw();
                snake.Move();
                snake.Draw();

                //检测是否撞墙
                if (snake.CheckEnd(map))
                {
                    //结束逻辑
                    GameClass.ChangeScene(E_SceneType.End);
                }

                snake.ChackFood(food);

                updateIndex = 0;
            }
            ++updateIndex;

            //在控制台中检测玩家输入，让程序不被检测卡住
            //KeyAvailable判断有没有键盘输入，如果有才是true
            if (Console.KeyAvailable)
            {
                //检测输入输出不能在间隔帧里去处理，需要每次都检测
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChanggeDir(E_MoveDir.Up);
                        break;
                    case ConsoleKey.A:
                        snake.ChanggeDir(E_MoveDir.Left);
                        break;
                    case ConsoleKey.S:
                        snake.ChanggeDir(E_MoveDir.Down);
                        break;
                    case ConsoleKey.D:
                        snake.ChanggeDir(E_MoveDir.Right);
                        break;
                }
            }
        }
    }
}
