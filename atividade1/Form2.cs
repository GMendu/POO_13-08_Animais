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
        int x;
        public Form2(int x)
        {
            InitializeComponent();
            this.x = x;
            txtNumAnimal.Text = x.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal A1 = new Animal();
            string[,] animal = new string[4, x];
            for(int j = x; j > 0; j--)
            for (int i = 0; i < 4; i++)
            {
                animal[i, x] = txtTipo.Text;
            }

        }
    }
}
