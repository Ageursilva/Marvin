using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Marvin
{
    public partial class FrmCadastroClientes : Form
    {
        public FrmCadastroClientes()
        {
            InitializeComponent();
        }
        private void habilitar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            mskDtNasc.Enabled = true;
            mskCPF.Enabled = true;
            mskDtNasc.Focus();
        }
        private void desHabilitar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            mskDtNasc.Enabled = false;
            mskCPF.Enabled = false;
        }
        private void limparControles()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            mskDtNasc.Clear();
            mskCPF.Clear();
            mskDtNasc.Focus();
        }
        private bool validaDados()
        {
            if (string.IsNullOrEmpty(mskDtNasc.Text))
            {
                MessageBox.Show("Preenchimento de campo obrigatório", "Marvin",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskDtNasc.Clear();
                mskDtNasc.Focus();
                return false;
            }
            return true;
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                if (MessageBox.Show("Você está editando um registro existente. Deseja incluir um registro novo ? ",
                "Marvin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
                    limparControles();
                return;
            }
            if (validaDados() == false)
                return;
            string sqlQuery;
            SqlConnection conCliente = Conexao.GetConnection();
            sqlQuery = "INSERT INTO cliente(nome,data_nasc,cpf) VALUES(@nome,@data_nasc,@cpf)";
            try
            {
                conCliente.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc",
                Convert.ToDateTime(mskCPF.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskDtNasc.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente incluído com sucesso", "ACR Rental Car",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conCliente != null)
                { conCliente.Close(); }
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            habilitar();
        }

    }

    internal class Conexao
    {
        internal static SqlConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}