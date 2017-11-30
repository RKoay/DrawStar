using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class mainDisplay : Form
    {
        public mainDisplay()
        {
            InitializeComponent();
            Graphics g = this.CreateGraphics();
            Pen pen;
        }
        public void DrawStar(Pen pen, float x, float y, float size)
        {
            size = size / 84;
            int firstxdis = -10;
            int secondxdis = -31;
            int thirdxdis = 25;
            int fourthxdis = -11;
            int fifthxdis = 27;
            int sixthxdis = 27;
            int seventhxdis = -9;
            int eighthxdis = 25;
            int ninthxdis = -32;

            int firstydis = 30;
            int secondydis = 0;
            int thirdydis = 19;
            int fourthydis = 32;
            int fifthydis = -19;
            int sixthydis = 19;
            int seventhydis = -32;
            int eighthydis = -19;
            int ninthydis = 0;

            Graphics g = this.CreateGraphics();
            g.DrawLine(pen, x, y, (size * firstxdis) + x, (size * firstydis) + y);
            g.DrawLine(pen, (size *firstxdis) + x, (size * firstydis) + y, (size * (firstxdis + secondxdis)) + x, (size *(firstydis + secondydis)) + y);
            g.DrawLine(pen, (size * (firstxdis + secondxdis)) + x, (size * (firstydis + secondydis)) + y, (size * (firstxdis + secondxdis + thirdxdis)) + x, (size * (firstydis + secondydis + thirdxdis)) + y);
            g.DrawLine(pen, (size * (firstxdis + secondxdis + thirdxdis)) + x, (size * (firstydis + secondydis + thirdxdis)) + y, (size *(firstxdis + secondxdis + thirdxdis + fourthxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis)) + y);
            g.DrawLine(pen, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis)) + y, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis + fifthydis)) + y);
            g.DrawLine(pen, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis + fifthydis)) + y, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis)) + y);
            g.DrawLine(pen, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis)) + y, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis)) + y);
            g.DrawLine(pen, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis)) + y, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis + eighthxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis + eighthydis)) + y);
            g.DrawLine(pen, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis + eighthxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis + eighthydis)) + y, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis + eighthxdis + ninthxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis + eighthydis + ninthydis)) + y);
            g.DrawLine(pen, (size * (firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis + eighthxdis + ninthxdis)) + x, (size * (firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis + eighthydis + ninthydis)) + y, x, y);

            //Calculating width
            //86-2 = 84



        }

        private void starButton_Click(object sender, EventArgs e)
        {

        }

    }
}

            //Calculating width
            //86-2 = 84
            
//Graphics g = this.CreateGraphics();
//g.DrawLine(pen, 43, 4, 33, 34);
//            g.DrawLine(pen, 33, 34, 2, 34);
//            g.DrawLine(pen, 2, 34, 27, 53);
//            g.DrawLine(pen, 27, 53, 16, 85);
//            g.DrawLine(pen, 16, 85, 43, 66);
//            g.DrawLine(pen, 43, 66, 70, 85);
//            g.DrawLine(pen, 70, 85, 61, 53);
//            g.DrawLine(pen, 61, 53, 86, 34);
//            g.DrawLine(pen, 86, 34, 54, 34);
//            g.DrawLine(pen, 54, 34, 43, 4);