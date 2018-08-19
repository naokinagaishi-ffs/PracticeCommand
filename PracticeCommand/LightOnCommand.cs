using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCommand
{
    class LightOnCommand : Command
    {
        private Light light { get; set; }

        /// <summary>
        /// コンストラクタ。コマンドが制御する特定の照明が渡され、
        /// それを照明インスタンス変数に格納する。
        /// </summary>
        /// <param name="light"></param>
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }

}
