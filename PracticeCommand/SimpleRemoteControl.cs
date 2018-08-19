using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCommand
{
    class SimpleRemoteControl
    {
        private Command slot;


        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public SimpleRemoteControl() { }


        /// <summary>
        /// スロットが制御するコマンドを、設定するためのメソッド。
        /// このコードは、クライアントがリモコンのボタンの振る舞いを変更したい場合に、
        /// 何度でも呼び出せます。
        /// </summary>
        /// <param name="command"></param>
        public void SetCommand(Command command)
        {
            slot = command;
        }

        /// <summary>
        /// このメソッドはボタンが押され時に呼びだされる。ここで行うことは、スロットに
        /// 結びつけられた現行のコマンドを取得し、そのExecuteメソッドを呼び出すだけ。
        /// </summary>
        public void buttonWasPressed()
        {
            slot.Execute();
        }

    }
}
