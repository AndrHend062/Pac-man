using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Pac_man
{
    public partial class pacMan : Form
    {
        public pacMan()
        {
            InitializeComponent();
        }
      
        
        private void button1_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            

            Graphics formGraphics = this.CreateGraphics();// graphics setup
            Pen drawPen = new Pen(Color.Blue, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            SolidBrush drawBrush2 = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            formGraphics.DrawLine(drawPen, 0, 20, 400, 20); // top line 
            formGraphics.DrawLine(drawPen, 0, 200, 200, 200);
            formGraphics.DrawLine(drawPen, 400, 20, 400, 300);
            formGraphics.DrawLine(drawPen, 200, 200, 200, 300);
            Thread.Sleep(500);
            formGraphics.FillPie(drawBrush2, 250, 200, 50, 50, 120, 300);




            formGraphics.FillPie(drawBrush,50,50,50,50,30,300);
            Thread.Sleep(500);
            formGraphics.FillPie(drawBrush2, 50, 50, 50, 50, 30, 300);
            formGraphics.FillPie(drawBrush, 100, 50, 50, 50, 30, 360);
            Thread.Sleep(500);
            formGraphics.FillPie(drawBrush2, 100, 50, 50, 50, 30, 360);
            formGraphics.FillPie(drawBrush, 150, 50, 50, 50, 30, 300);
            Thread.Sleep(500);
            formGraphics.FillPie(drawBrush2, 150, 50, 50, 50, 30, 360);
            formGraphics.FillPie(drawBrush, 200, 50, 50, 50, 30, 360);
            Thread.Sleep(500);
            formGraphics.FillPie(drawBrush2, 200, 50, 50, 50, 30, 360);
            formGraphics.FillPie(drawBrush, 250, 50, 50, 50, 30, 300);
            Thread.Sleep(500);
            formGraphics.FillPie(drawBrush2, 250, 50, 50, 50, 30, 360);
            formGraphics.FillPie(drawBrush, 250, 50, 50, 50, 120, 360);
            Thread.Sleep(500);
            formGraphics.FillPie(drawBrush2, 250, 50, 50, 50, 120, 360);
            formGraphics.FillPie(drawBrush, 250, 100, 50, 50, 120, 300);
            Thread.Sleep(500);
            formGraphics.FillPie(drawBrush2, 250, 100, 50, 50, 120, 360);
            formGraphics.FillPie(drawBrush, 250, 150, 50, 50, 120, 360);
            Thread.Sleep(500);
            formGraphics.FillPie(drawBrush2, 250, 150, 50, 50, 120, 360);
            formGraphics.FillPie(drawBrush, 250, 200, 50, 50, 120, 300);

            formGraphics.DrawString("Congratulations", drawFont, drawBrush, 50, 60);
            Thread.Sleep(1000);
            startButton.Visible = true;

        }
    }
}
