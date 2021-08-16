using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa P1 = new Pessoa();
            P1.Nome = txtNomeP.Text;
            P1.Telefone = txtTelefone.Text;
            P1.Endereco = txtEndereco.Text;
            P1.QuantidadeA = int.Parse(txtQuantA.Text);
            Form2 F2 = new Form2(P1);
            F2.Show();
        }
    }
}
