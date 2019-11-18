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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadEmpresas ce = new CadEmpresas();
            ce.ShowDialog();
        }

        private void btEntrar_MouseHover(object sender, EventArgs e)
        {
            gpCadastro.Visible = true;
        }

        private void btEntrar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void gpCadastro_MouseHover(object sender, EventArgs e)
        {
            gpCadastro.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadVeiculos cv = new CadVeiculos();
            cv.ShowDialog();
        }
    }
}
