using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDepartamento
{


    class Cadastro
    {
        SqlConnection conexao;

        public Cadastro()
        {
            {
                try
                {
                    conexao = new SqlConnection("");
                    conexao.Open();
                    SqlCommand comando = new SqlCommand();
                    SqlDataReader dr;
                    comando.CommandText = "select * from CLIENTES";
                    dr = comando.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            System.Windows.Forms.MessageBox.Show(dr[0].ToString());
                        }
                    }
                    conexao.Close();
                }

                catch (Exception E)
                {
                    System.Windows.Forms.MessageBox.Show(E.Message);
                }
            }
        }
    }
}