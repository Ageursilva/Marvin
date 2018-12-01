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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Aparecer uma nova imagem
            Form3 frm = new Form3();
            frm.Show();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmCadastroClientes();
            frm.Show();
            this.Visible = true;
        }
    }
}
