using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Marvin
{
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();
        }

        private void habilitar()
        {
            txtCodigo.Enabled = false;
            txtCusto.Enabled = true;
            TxtPreVenda.Enabled = true;
            txtTipo.Enabled = true;
            txtMarca.Enabled = true;
            txtEstoque.Enabled = true;
            txtCodigo.Focus();
        }
        private void desHabilitar()
        {
            txtCodigo.Enabled = false;
            txtCusto.Enabled = false;
            TxtPreVenda.Enabled = false;
            TxtPreVenda.Enabled = false;
            txtMarca.Enabled = false;
            txtEstoque.Enabled = false;
        }
         private void LimparControles()
        {
            txtCodigo.Clear();
            txtCusto.Clear();
            TxtPreVenda.Clear();
            txtTipo.Clear();
            txtMarca.Clear();
            txtEstoque.Clear();
        }

        private bool validaDados()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Preenchimento de campo obrigatório", "Marvin",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Clear();
                txtCodigo.Focus();
                return false;
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_BEBIDASDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dB_BEBIDASDataSet.Table);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void lblIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                //se txtCodigo não estiver vazio, significa que já foi consultado um cliente.
                // a instrução a seguir captura se foi clicado o botão Yes (SIM) como resposta da pergunta.
                if (MessageBox.Show("Você está editando um registro existente. Deseja incluir um registro novo?", "Marvin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    LimparControles();
                return;   //encerra a sub-rotina
            }

            // antes de incluir é preciso validar os dados de preenchimento obrigatório
            //chama o método para validar a entrada de dados
            //se retornou falso, interrompe o processamento para incluir no banco de dados

            if (validaDados() == false)
            {
                return;  //interrompe a sub-rotina
            }

            //declaração da variável para guardar as instruções SQL
            string sqlQuery;

            //cria conexão chamando o método getConnection da classe Conexao
            SqlConnection conCliente = Conexao.getConnection();

            //cria a instrução sql, parametrizada
            sqlQuery = "INSERT INTO ESTOQUE(Cod_Bebida,Custo,PrecoVenda,Marca,Tipo,Estoque) VALUES(@Cod_Bebida,@Custo,@PrecoVenda,@Marca,@Tipo,@Estoque)";

            //Tratamento de exceções
            try
            {
                //abre a conexão com o banco de dados
                conCliente.Open();

                //cria um objeto do tipo SqlCommand com a instrução SQL e a conexão
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                //define, adiciona os parametros
                cmd.Parameters.Add(new SqlParameter("@Cod_Bebida", txtCodigo.Text));
                cmd.Parameters.Add(new SqlParameter("@Custo",txtCusto.Text ));
                cmd.Parameters.Add(new SqlParameter("@PrecoVenda", TxtPreVenda.Text));
                cmd.Parameters.Add(new SqlParameter("@Marca", txtMarca.Text));
                cmd.Parameters.Add(new SqlParameter("@Tipo", txtTipo.Text));
                cmd.Parameters.Add(new SqlParameter("@Estoque", txtEstoque.Text));

                //executa o commando
                //ExecuteNonQuery envia instruções para o banco de dados que estão em cmd
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso", "Marvin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpa os campos para nova entrada de dados
                LimparControles();
            }
            catch (Exception ex)  // se houve alguma exceção dentro do bloco try
            {
                MessageBox.Show("Problema ao incluir produto " + ex, "Marvin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally  // independente se houve exceção ou não o bloco try é sempre executado
            {
                //se conexão não for nula, fecha conexão
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private class Conexao
        {
            internal static SqlConnection getConnection()
            {
                throw new NotImplementedException();
            }
        }
    }
}
