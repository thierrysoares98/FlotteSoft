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

namespace FlotteSoft
{
    public partial class CadEmpresas : Form
    {
        EmpresaDTO EDTO = new EmpresaDTO();
        EmpresaBLL EBLL = new EmpresaBLL();
        public CadEmpresas()
        {
            InitializeComponent();
        }

        private void CadEmpresas_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                EDTO.Cnpj = txtCnpj.Text;
                EDTO.Razao_social = txtRazaoSocial.Text;
                EDTO.Status_empresa = txtStatusEmp.Text;
                EDTO.Telefone = txtTelefone.Text;
                EDTO.Email = txtEmail.Text;
                EDTO.Endereco = txtEndereco.Text;

                EBLL.inserirEmpresa(EDTO);

                txtCnpj.Text = "";
                txtRazaoSocial.Text = "";
                txtStatusEmp.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                txtEndereco.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO EFETUAR CADASTRO: " + ex.ToString());
            }
            
        }
    }
}
