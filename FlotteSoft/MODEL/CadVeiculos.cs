using FlotteSoft.BLL;
using FlotteSoft.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlotteSoft.MODEL
{
    public partial class CadVeiculos : Form
    {
        VeiculosDTO VDTO  = new VeiculosDTO();
        VeiculosBLL VBLL  = new VeiculosBLL();
        public CadVeiculos()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                VDTO.Marca       = txtMarca.Text;
                VDTO.Modelo      = txtModelo.Text;
                VDTO.Ano         = int.Parse(txtAno.Text);
                VDTO.Valordiaria = Double.Parse(txtValorDiaria.Text);
                VBLL.inserirEmpresa(VDTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbArSim_CheckedChanged(object sender, EventArgs e)
        {
            VDTO.Ar_condicionado = 1;
        }

        private void rbArNao_CheckedChanged(object sender, EventArgs e)
        {
            VDTO.Ar_condicionado = 0;
        }

        private void rbVeicSim_CheckedChanged(object sender, EventArgs e)
        {
            VDTO.Veiculo_do_cliente = 1;
        }

        private void rbVeicNao_CheckedChanged(object sender, EventArgs e)
        {
            VDTO.Veiculo_do_cliente = 0;
        }

        private void rbLeves_CheckedChanged(object sender, EventArgs e)
        {
            VDTO.Tipo_veiculo = "MOTO";
        }

        private void rbMotos_CheckedChanged(object sender, EventArgs e)
        {
            VDTO.Tipo_veiculo = "CARRO";
        }

        private void rbPesados_CheckedChanged(object sender, EventArgs e)
        {
            VDTO.Tipo_veiculo = "PESADOS";
        }

        private void txtValorDiaria_TextChanged(object sender, EventArgs e)
        {
            UtilsBLL.Moeda(ref txtValorDiaria);
        }
    }
}
