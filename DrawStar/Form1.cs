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
        }
        public void DrawStar(Pen pen, float x, float y, float size)
        {
            int lineOne;
            int lineTwo;
            int lineThree;
            int lineFour;
            int lineFive;
            int lineSix;
            int lineSeven;
            int lineEight;
            int lineNine;
            int lineTen; 

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

            g.DrawLine(pen, x, y, x - 10, y + 30);
            g.DrawLine(pen, x - 10, y + 30, x - 10 - 31, y + 30);
            g.DrawLine(pen, x - 10 - 31, y + 30, x - 10 - 31 + 25, y + 30 + 19);
            g.DrawLine(pen, x - 10 - 31 + 25, y + 30 + 19, x - 10 - 31 + 25 - 11, y + 30 + 19 + 32);
            g.DrawLine(pen, x - 10 - 31 + 25 - 11, y + 30 + 19 + 32, x, y + 30 + 19 + 32 - 19);
            g.DrawLine(pen, x, y + 30 + 19 + 32 - 19, x + 27, y + 30 + 19 )

            //Calculating width
            //86-2 = 84
           
        }

        private void starButton_Click(object sender, EventArgs e)
        {

        }

    }
}
