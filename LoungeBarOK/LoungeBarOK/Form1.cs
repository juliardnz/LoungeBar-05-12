using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoungeBarOK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "loungebar";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM `bebida` WHERE 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgCadastro.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgCadastro.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetString(0); //ID
                    row.Cells[1].Value = reader.GetString(1); //BEBIDA
                    row.Cells[2].Value = reader.GetString(2); //CATEGORIA
                    row.Cells[3].Value = reader.GetString(3); //DESCRICAO
                    row.Cells[4].Value = reader.GetString(4); //VALOR
                    row.Cells[5].Value = reader.GetString(5); //ATIVO
                    dgCadastro.Rows.Add(row); //ADICIONO LINHA NA TABELA
                }
                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sem Conexao!");
                Console.WriteLine(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void limparCampos()
        {
            txtBebida.Clear();
            txtCategoria.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
            txtId.Clear();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            MySqlBaseConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open();

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO `bebida` (`nomeBebida`, `categoriaBebida`, `descricaoBebida`, `valorBebida`)" +
                    " VALUES('" + txtBebida.Text + "','" + txtCategoria.Text + "', '" + txtDescricao.Text + "','" + Convert.ToInt16(txtValor.Text) + "')";
                
                comandoMySql.ExecuteNonQuery();

                realizarConexaoBD.Close();
                MessageBox.Show("Adicionado com sucesso!");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            MySqlBaseConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open();

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand();
                comandoMySql.CommandText = "UPDATE `bebida` SET ` nomeBebida = '" + txtBebida.Text + "'," +
                    "`categoriaBebida` = '" + txtCategoria.Text + "'," +
                    "`descricaoBebida` = '" + txtDescricao.Text + "'," +
                    "`idBebida` = '" + txtId.Text + "'," +
                    "WHERE `valorBebida` = '" + Convert.ToInt16(txtValor) + "')";

                comandoMySql.ExecuteNonQuery();

                realizarConexaoBD.Close();
                MessageBox.Show("Atualizado com Sucesso!");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

             
        }

        private void dgCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCadastro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgCadastro.CurrentRow.Selected = true;
                txtBebida.Text = dgCadastro.Rows[e.RowIndex].Cells["ColNomeBebida"].FormattedValue.ToString();
                txtCategoria.Text = dgCadastro.Rows[e.RowIndex].Cells["ColCategoria"].FormattedValue.ToString();
                txtDescricao.Text = dgCadastro.Rows[e.RowIndex].Cells["ColDescricao"].FormattedValue.ToString();
                txtValor.Text = dgCadastro.Rows[e.RowIndex].Cells["ColValor"].FormattedValue.ToString();
                txtId.Text = dgCadastro.Rows[e.RowIndex].Cells["ColID"].FormattedValue.ToString();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            MySqlBaseConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open();

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand();
                comandoMySql.CommandText = "UPDATE `bebida` SET `ativoBebida` = '0' WHERE `bebida`.`idBebida` = " + txtId.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizarConexaoBD.Close();
                MessageBox.Show("Excluido com Sucesso!");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}




