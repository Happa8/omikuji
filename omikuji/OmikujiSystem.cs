using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omikuji
{
    public static class OmikujiSystem
    {
        public static bool isRenzoku;

        public static void Omikuji()
        {
            var rnd = new Random();
            int rundomNum = rnd.Next(8);
            

            switch (rundomNum)
            {
                case 0:
                    DialogResult res0 = MessageBox.Show("大吉\n\nちっ運のいい奴め　祝ってやる");
                    if(res0 == DialogResult.OK)
                    {
                        endAction();
                    }
                    break;

                case 1:
                    DialogResult res1 = MessageBox.Show("吉\n\n「きち」じゃないです「よし」です");
                    if (res1 == DialogResult.OK)
                    {
                        endAction();
                    }
                    break;

                case 2:
                    DialogResult res2 = MessageBox.Show("凶\n\nちっちゃな不幸が身に降りかかるでしょう。\nガム踏むとか");
                    if (res2 == DialogResult.OK)
                    {
                        endAction();
                    }
                    break;

                case 3:
                    DialogResult res3 = MessageBox.Show("末凶\n\n知ってたか？末凶って凶より悪いんだぜ");
                    if (res3 == DialogResult.OK)
                    {
                        endAction();
                    }
                    break;

                case 4:
                    DialogResult res4 = MessageBox.Show("大凶\n\nま、今日は何かにおびえて暮らしてみ");
                    if (res4 == DialogResult.OK)
                    {
                        endAction();
                    }
                    break;

                case 5:
                    DialogResult res5 = MessageBox.Show("リア充爆発しろ\n\n恋愛以外のことはうまくいきます\nただし、誰と付き合っていても破局します。");
                    if (res5 == DialogResult.OK)
                    {
                        endAction();
                    }
                    break;

                case 6:
                    DialogResult res6 = MessageBox.Show("壁ドンするといいでしょう。\n\nまぁ相手がいればの話ですが（嘲笑）");
                    if (res6 == DialogResult.OK)
                    {
                        endAction();
                    }
                    break;

                case 7:
                    DialogResult res7 = MessageBox.Show("大々凶\n\nこの結果が出る確率は低いから、逆に運いいんじゃね");
                    if (res7 == DialogResult.OK)
                    {
                        endAction();
                    }
                    break;


            }


        }

        public static void endAction()
        {
            

            if (!isRenzoku)
            {
                Application.Exit();
            }


    }
    }
}
