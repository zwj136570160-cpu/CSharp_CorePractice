using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇.游戏场景逻辑
{
    abstract class GameObjectClass : IDraw
    {
        //游戏对象位置
        public Position pos;

        //可以继承接口后，把接口中的行为编程为抽象行为
        //供子类去实现，因为抽象行为，所以子类中是必须去实现的
        public abstract void Draw();
    }
}
