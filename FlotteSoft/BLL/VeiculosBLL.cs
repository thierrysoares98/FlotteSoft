using FlotteSoft.DAL;
using FlotteSoft.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlotteSoft.BLL
{
    class VeiculosBLL
    {
        Datacon DTC = new Datacon();
        public void inserirEmpresa(VeiculosDTO VDTO)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("INSERT INTO [dbo].[veiculo]([tipo_veiculo],[marca],[modelo] ,[ano],[valor_diaria],[ar_condicionado],[veiculo_do_Cliente])VALUES(@tipo_veiculo, @marca, @modelo, @ano, @Valordiaria, @ar_condicionado, @veiculo_cliente)", DTC.conectar());
                
                sqlCmd.Parameters.AddWithValue("@tipo_veiculo", VDTO.Tipo_veiculo);
                sqlCmd.Parameters.AddWithValue("@marca", VDTO.Marca);
                sqlCmd.Parameters.AddWithValue("@modelo", VDTO.Modelo);
                sqlCmd.Parameters.AddWithValue("@ano", VDTO.Ano);
                sqlCmd.Parameters.AddWithValue("@Valordiaria", VDTO.Valordiaria);
                sqlCmd.Parameters.AddWithValue("@ar_condicionado", VDTO.Ar_condicionado);
                sqlCmd.Parameters.AddWithValue("@veiculo_cliente", VDTO.Veiculo_do_cliente);

                DTC.ExecutarComandoSQL(sqlCmd);
                MessageBox.Show("Veiculo cadastrada com sucesso !");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
