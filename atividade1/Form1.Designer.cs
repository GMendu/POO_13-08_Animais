
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
            this.labelTituloPessoa.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTituloPessoa.Location = new System.Drawing.Point(14, 11);
            this.labelTituloPessoa.Name = "labelTituloPessoa";
            this.labelTituloPessoa.Size = new System.Drawing.Size(212, 30);
            this.labelTituloPessoa.TabIndex = 0;
            this.labelTituloPessoa.Text = "Cadastro de pessoas";
            // 
            // labelNomeP
            // 
            this.labelNomeP.AutoSize = true;
            this.labelNomeP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomeP.Location = new System.Drawing.Point(14, 57);
            this.labelNomeP.Name = "labelNomeP";
            this.labelNomeP.Size = new System.Drawing.Size(53, 21);
            this.labelNomeP.TabIndex = 1;
            this.labelNomeP.Text = "Nome";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefone.Location = new System.Drawing.Point(14, 92);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(67, 21);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndereco.Location = new System.Drawing.Point(14, 127);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(74, 21);
            this.labelEndereco.TabIndex = 3;
            this.labelEndereco.Text = "Endereço";
            // 
            // txtNomeP
            // 
            this.txtNomeP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeP.Location = new System.Drawing.Point(98, 54);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(128, 29);
            this.txtNomeP.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.Location = new System.Drawing.Point(98, 89);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(128, 29);
            this.txtTelefone.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndereco.Location = new System.Drawing.Point(98, 124);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(128, 29);
            this.txtEndereco.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(47, 210);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(179, 30);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Cadastro de animais ➤";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelQuantA
            // 
            this.labelQuantA.AutoSize = true;
            this.labelQuantA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantA.Location = new System.Drawing.Point(14, 162);
            this.labelQuantA.Name = "labelQuantA";
            this.labelQuantA.Size = new System.Drawing.Size(170, 21);
            this.labelQuantA.TabIndex = 9;
            this.labelQuantA.Text = "Quantidade de animais";
            // 
            // txtQuantA
            // 
            this.txtQuantA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantA.Location = new System.Drawing.Point(190, 159);
            this.txtQuantA.Name = "txtQuantA";
            this.txtQuantA.Size = new System.Drawing.Size(36, 29);
            this.txtQuantA.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 254);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animalindos";
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

