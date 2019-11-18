using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlotteSoft.MODEL
{
    public partial class splash : Form
    {
        int x = 50;
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void splash_Load(object sender, EventArgs e)
        {

            timer1.Start();
            timer1.Start();
            timer1.Start();
            timer1.Start();
            timer1.Start();
        }

        private void splash_Activated(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            carroLaranja.Left = x;
            x = x + 50;
            if (x> 655)
            {
                timer1.Stop();
                timer1.Stop();
                timer1.Stop();
                timer1.Stop();
                timer1.Stop();
                Menu menu = new Menu();
                this.Close();
                menu.ShowDialog();
               
            }
        }
    }
}
