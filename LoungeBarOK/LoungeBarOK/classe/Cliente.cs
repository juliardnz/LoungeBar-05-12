using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace LoungeBarOK.classe
{



    class Cliente
    {
        public MySqlConnection conexaobanco;

        public MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "loungebar";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }
      class CRUD : Cliente
        {
            //PROPRIEDADES
            public string Nome { get; set; }
            public int Cpf { get; set; }
            public string Email { get; set; }
            public int Aniver { get; set; }
            public int Telefone { get; set; }
            public int Id { get; set; }

            //FUNCOES
            public void atualizarGrid()
            {
                MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
                MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
                {
                    realizaConexaoBD.Open();

                    MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                    comandoMySql.CommandText = "SELECT * FROM `cliente` WHERE 1";
                    MySqlDataReader reader = comandoMySql.ExecuteReader();
                }
               
            }
        }
        
    }
}
