using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCommand
{
    class Light
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Light() { }

        /// <summary>
        /// 電気をつける
        /// </summary>
        public void On()
        {
            Console.WriteLine("電気をつけました");
        }

        /// <summary>
        /// 電気を消す
        /// </summary>
        public void Off()
        {
            Console.WriteLine("電気を消しました");
        }
    }
}
