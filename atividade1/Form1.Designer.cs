
namespace atividade1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTituloPessoa = new System.Windows.Forms.Label();
            this.labelNomeP = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelQuantA = new System.Windows.Forms.Label();
            this.txtQuantA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTituloPessoa
            // 
            this.labelTituloPessoa.AutoSize = true;
            this.labelTituloPessoa.Location = new System.Drawing.Point(47, 30);
            this.labelTituloPessoa.Name = "labelTituloPessoa";
            this.labelTituloPessoa.Size = new System.Drawing.Size(114, 15);
            this.labelTituloPessoa.TabIndex = 0;
            this.labelTituloPessoa.Text = "Cadastro de pessoas";
            // 
            // labelNomeP
            // 
            this.labelNomeP.AutoSize = true;
            this.labelNomeP.Location = new System.Drawing.Point(32, 72);
            this.labelNomeP.Name = "labelNomeP";
            this.labelNomeP.Size = new System.Drawing.Size(40, 15);
            this.labelNomeP.TabIndex = 1;
            this.labelNomeP.Text = "Nome";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(32, 101);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(51, 15);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(32, 130);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 15);
            this.labelEndereco.TabIndex = 3;
            this.labelEndereco.Text = "Endereço";
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(103, 69);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(100, 23);
            this.txtNomeP.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(103, 98);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(103, 127);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(100, 23);
            this.txtEndereco.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(77, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(168, 30);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar e cadastrar animais ->";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelQuantA
            // 
            this.labelQuantA.AutoSize = true;
            this.labelQuantA.Location = new System.Drawing.Point(32, 164);
            this.labelQuantA.Name = "labelQuantA";
            this.labelQuantA.Size = new System.Drawing.Size(129, 15);
            this.labelQuantA.TabIndex = 9;
            this.labelQuantA.Text = "Quantidade de animais";
            // 
            // txtQuantA
            // 
            this.txtQuantA.Location = new System.Drawing.Point(167, 161);
            this.txtQuantA.Name = "txtQuantA";
            this.txtQuantA.Size = new System.Drawing.Size(36, 23);
            this.txtQuantA.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 247);
            this.Controls.Add(this.txtQuantA);
            this.Controls.Add(this.labelQuantA);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNomeP);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelNomeP);
            this.Controls.Add(this.labelTituloPessoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloPessoa;
        private System.Windows.Forms.Label labelNomeP;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labelQuantA;
        private System.Windows.Forms.TextBox txtQuantA;
    }
}

