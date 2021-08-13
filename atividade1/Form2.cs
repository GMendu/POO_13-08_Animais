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
        public Form2(int x)
        {
            InitializeComponent();
            txtNumAnimal.Text = x.ToString();
            string[] Animais = new string[4,x];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Animal A1 = new Animal();

        }
    }
}
