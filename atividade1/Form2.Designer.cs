
namespace atividade1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTituloAnimal = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelNomeA = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtNumAnimal = new System.Windows.Forms.TextBox();
            this.labelNumA = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTituloAnimal
            // 
            this.labelTituloAnimal.AutoSize = true;
            this.labelTituloAnimal.Location = new System.Drawing.Point(58, 30);
            this.labelTituloAnimal.Name = "labelTituloAnimal";
            this.labelTituloAnimal.Size = new System.Drawing.Size(116, 15);
            this.labelTituloAnimal.TabIndex = 0;
            this.labelTituloAnimal.Text = "Cadastro de Animais";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(48, 114);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(30, 15);
            this.labelTipo.TabIndex = 1;
            this.labelTipo.Text = "Tipo";
            // 
            // labelNomeA
            // 
            this.labelNomeA.AutoSize = true;
            this.labelNomeA.Location = new System.Drawing.Point(38, 150);
            this.labelNomeA.Name = "labelNomeA";
            this.labelNomeA.Size = new System.Drawing.Size(40, 15);
            this.labelNomeA.TabIndex = 2;
            this.labelNomeA.Text = "Nome";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(42, 189);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(36, 15);
            this.labelIdade.TabIndex = 3;
            this.labelIdade.Text = "Idade";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(46, 227);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(32, 15);
            this.labelSexo.TabIndex = 4;
            this.labelSexo.Text = "Sexo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(97, 111);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(92, 23);
            this.txtTipo.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 147);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(92, 23);
            this.txtNome.TabIndex = 6;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(97, 186);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(92, 23);
            this.txtIdade.TabIndex = 7;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(97, 224);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(92, 23);
            this.txtSexo.TabIndex = 8;
            // 
            // txtNumAnimal
            // 
            this.txtNumAnimal.Enabled = false;
            this.txtNumAnimal.Location = new System.Drawing.Point(104, 67);
            this.txtNumAnimal.Name = "txtNumAnimal";
            this.txtNumAnimal.ReadOnly = true;
            this.txtNumAnimal.Size = new System.Drawing.Size(44, 23);
            this.txtNumAnimal.TabIndex = 9;
            // 
            // labelNumA
            // 
            this.labelNumA.AutoSize = true;
            this.labelNumA.Location = new System.Drawing.Point(38, 70);
            this.labelNumA.Name = "labelNumA";
            this.labelNumA.Size = new System.Drawing.Size(60, 15);
            this.labelNumA.TabIndex = 10;
            this.labelNumA.Text = "Animal nº";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(187, 274);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 11;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 313);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.labelNumA);
            this.Controls.Add(this.txtNumAnimal);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelNomeA);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelTituloAnimal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloAnimal;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelNomeA;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtNumAnimal;
        private System.Windows.Forms.Label labelNumA;
        private System.Windows.Forms.Button btnProximo;
    }
}