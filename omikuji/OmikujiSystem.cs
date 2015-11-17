using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace omikuji
{
    class OmikujiSystem
    {
        public static void Omikuji()
        {
            var rnd = new Random();
            int rundomNum = rnd.Next(6);
            switch (rundomNum)
            {
                case 0:
                    MessageBox.Show("大吉");
                    break;

                case 1:
                    MessageBox.Show("吉");
                    break;

                case 2:
                    MessageBox.Show("凶");
                    break;

                case 3:
                    MessageBox.Show("末凶");
                    break;

                case 4:
                    MessageBox.Show("大凶");
                    break;

                
            }


        }
    }
}
