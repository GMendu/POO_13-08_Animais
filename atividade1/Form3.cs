using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atividade1
{
    public partial class Form3 : Form
    {
        public Form3(string[,] Dados,int limite,Pessoa P1)
        {
            InitializeComponent();
            dataAnimal.Columns.Add("Index", "Nome");
            dataAnimal.Columns.Add("Value", "Idade");
            dataAnimal.Columns.Add("Value", "Sexo");
            dataAnimal.Columns.Add("Value", "Tipo");

            for (int i = 0; i < limite; i++)
            {
                dataAnimal.Rows.Add(new object[] { Dados[i, 0], Dados[i,1], Dados[i, 2], Dados[i, 3] });
            }

            dataPessoa.Columns.Add("Index", "Nome");
            dataPessoa.Columns.Add("Value", "Telefone");
            dataPessoa.Columns.Add("Value", "Endereço");
            dataPessoa.Rows.Add(new object[] { P1.Nome,P1.Telefone ,P1.Endereco });
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
