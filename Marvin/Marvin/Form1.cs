using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marvin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bacessar_Click(object sender, EventArgs e)
        {
            String Usuario, Senha;
            Usuario = txtUsuario.Text;
            Senha = txtSenha.Text;

            if (Usuario == "Admin" && Senha == "Admin")
            //MessageBox.Show("Acesso permitido");
            {
                //Aparecer uma nova imagem
                Form2 frm = new Form2();
                frm.Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("Acesso negado");
             
                
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }
    }
}
