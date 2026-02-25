using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.Game对象和场景更新接口;

namespace 贪吃蛇.场景切换
{
    internal class BeginScene : BeginOrEndBaseScene
    {
        public BeginScene()
        {
            title = "贪吃蛇";
            option1 = "开始游戏";
        }

        public override void EnterJDoSomething()
        {
            //按J键之后的逻辑
            if (nowSelIndex == 0)
            {
                GameClass.ChangeScene(E_SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
