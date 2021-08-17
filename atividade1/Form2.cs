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
        public int tam, limite;
        public string numerodeanimais;
        Pessoa pessoa;
        public Form2(Pessoa P1)
        {
            InitializeComponent();
            pessoa = P1;
            this.tam = P1.QuantidadeA;
            this.limite = P1.QuantidadeA;
            numerodeanimais = $"{limite - (tam - 1)} de {limite}";
            txtNumAnimal.Text = numerodeanimais;

        }
        Animal A1 = new Animal();
        private void btnProximo_Click(object sender, EventArgs e)
        {
            tam--;
            A1.Animais[tam, 0] = txtNome.Text;
            A1.Animais[tam, 1] = txtIdade.Text;
            A1.Animais[tam, 2] = txtSexo.Text;
            A1.Animais[tam, 3] = txtTipo.Text;
            numerodeanimais = $"{limite - (tam - 1)} de {limite}";
            txtNumAnimal.Text = numerodeanimais;
            txtNome.Text = "";
            txtIdade.Text = "";
            txtSexo.Text = "";
            txtTipo.Text = "";
            if (tam < 1)
            {
                txtNumAnimal.Text = "limite";
                Form3 F3 = new Form3(A1,limite,pessoa);
                F3.FormClosed += new FormClosedEventHandler(Form3_FormClosed);
                F3.Show();
                this.Hide();
            }
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
