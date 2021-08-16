using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atividade1
{
    public partial class Form2 : Form
    {
        public string[,] Animais = new string[999, 4];
        public int tam, limite;
        Pessoa pessoa;
        public Form2(Pessoa P1)
        {
            InitializeComponent();
            pessoa = P1;
            this.tam = P1.QuantidadeA;
            this.limite = P1.QuantidadeA;
            txtNumAnimal.Text = P1.QuantidadeA.ToString();

        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            Animais[tam, 0] = txtNome.Text;
            Animais[tam, 1] = txtIdade.Text;
            Animais[tam, 2] = txtSexo.Text;
            Animais[tam, 3] = txtTipo.Text;
            txtNumAnimal.Text = tam.ToString();
            tam--;
            if (tam < 0)
            {
                Form3 F3 = new Form3(Animais,limite,pessoa);
                F3.Show();
            }
        }
    }
}
