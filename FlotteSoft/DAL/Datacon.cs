using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlotteSoft.DAL
{
    class Datacon
    {
        SqlConnection conn;
        private DataTable data;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private SqlCommandBuilder cb;

        string connStr = "Data Source= localhost; Persist Security Info=False; Initial Catalog=gerenciamento_Veiculo; User ID = chicken;Password = 98253";
        //string connStr = "Data Source= 192.168.1.3,1433; Persist Security Info=False; Initial Catalog=chickenBd; User ID = chicken;Password = 98253";


        public SqlConnection conectar()
        {

            this.conn = new SqlConnection(connStr);



            try
            {
                this.conn.Open();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw new Exception(ex.Message);
            }

            return conn;

        }
        public SqlConnection conect()
        {

            this.conn = new SqlConnection(connStr);

            return conn;

        }
        public void conectarSemReturn()
        {

            this.conn = new SqlConnection(connStr);



            try
            {
                this.conn.Open();

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            cb = new SqlCommandBuilder(da);
            da.Fill(data);
            return data;
        }
        public void fechaConexao()
        {
            this.conn = new SqlConnection(connStr);
            this.conn.Close();

        }
        public void ExecutarComandoSQL(SqlCommand SQLCMD)
        {
            try
            {
                conectar();
                SQLCMD.ExecuteNonQuery();
            }

            catch (Exception exx)
            {

                MessageBox.Show(exx.ToString());
            }
        }




    }
}
