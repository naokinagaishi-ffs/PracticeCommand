using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCommand
{
    public class RemoteControlTest
    {
        static void Main(string[] args)
        {
            //リモコンはインボーカ。リモコンは、リクエストを行うために
            //使用できるコマンドオブジェクトを渡される
            SimpleRemoteControl remote = new SimpleRemoteControl();

            //ここでLightオブジェクトを作成しており、
            //これがリクエストのレシーバーになる。
            Light light = new Light();

            //ここで、コマンドを作成し、レシーバーをコマンドに渡す。
            LightOnCommand lightOn = new LightOnCommand(light);

            //ここでコマンドをインボーカに渡す。
            remote.SetCommand(lightOn);

            //そして再生ボタンをシミュレートする
            remote.buttonWasPressed();
        }
    }
}
