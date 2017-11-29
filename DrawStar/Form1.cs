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
            int tenthxdis = -11;

            int firstydis = 30;
            int secondydis = 0;
            int thirdydis = 19;
            int fourthydis = 32;
            int fifthydis = -19;
            int sixthydis = 19;
            int seventhydis = -32;
            int eighthydis = -19;
            int ninthydis = 0;
            int tenthydis = -30;

            Graphics g = this.CreateGraphics();
            g.DrawLine(pen, 43, 4, 33, 34);
            g.DrawLine(pen, 33, 34, 2, 34);
            g.DrawLine(pen, 2, 34, 27, 53);
            g.DrawLine(pen, 27, 53, 16, 85);
            g.DrawLine(pen, 16, 85, 43, 66);
            g.DrawLine(pen, 43, 66, 70, 85);
            g.DrawLine(pen, 70, 85, 61, 53);
            g.DrawLine(pen, 61, 53, 86, 34);
            g.DrawLine(pen, 86, 34, 54, 34);
            g.DrawLine(pen, 54, 34, 43, 4);

            g.DrawLine(pen, size * x, size * y, size * (x + firstxdis), size * (y + firstydis));
            g.DrawLine(pen, size*(x + firstxdis), size*(y + firstydis), size*(x + firstxdis + secondxdis), size*(y + firstydis + secondydis));
            g.DrawLine(pen, size*(x + firstxdis + secondxdis), size*( y + firstydis + secondydis), size*(x + firstxdis + secondxdis + thirdxdis), size*(y + firstydis + secondydis + thirdxdis));
            g.DrawLine(pen, size*(x + firstxdis + secondxdis + thirdxdis), size*(y + firstydis + secondydis + thirdydis), size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis), size*( y + firstydis + secondydis + thirdydis + fourthydis));
            g.DrawLine(pen, size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis), size*(y + firstydis + secondydis + thirdydis + fourthydis), size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis), size*(y + firstydis + secondydis + thirdydis + fourthydis + fifthydis));
            g.DrawLine(pen, size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis), size*(y + firstydis + secondydis + thirdydis + fourthydis + fifthydis), size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis), size*( y + firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis));
            g.DrawLine(pen, size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis), size*( y + firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis), size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis), size*(y + firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis));
            g.DrawLine(pen, size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis), size*(y + firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis), size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis + eighthxdis), size*( y + firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis + eighthydis));
            g.DrawLine(pen, size*( x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis + eighthxdis), size*(y + firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis + eighthydis), size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis + eighthxdis + ninthxdis), size*(y + firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis + eighthydis + ninthydis));
            g.DrawLine(pen, size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis + eighthxdis + ninthxdis), size*(y + firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis + eighthydis + ninthydis), size*(x + firstxdis + secondxdis + thirdxdis + fourthxdis + fifthxdis + sixthxdis + seventhxdis + eighthxdis + ninthxdis + tenthxdis), size*(y + firstydis + secondydis + thirdydis + fourthydis + fifthydis + sixthydis + seventhydis + eighthydis + ninthydis + tenthydis));

            //Calculating width
            //86-2 = 84

            

        }

        private void starButton_Click(object sender, EventArgs e)
        {
        }

    }
}
