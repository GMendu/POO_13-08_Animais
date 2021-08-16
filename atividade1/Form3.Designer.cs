
namespace atividade1
{
    partial class Form3
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
            this.dataAnimal = new System.Windows.Forms.DataGridView();
            this.dataPessoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAnimal
            // 
            this.dataAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAnimal.Location = new System.Drawing.Point(12, 12);
            this.dataAnimal.Name = "dataAnimal";
            this.dataAnimal.Size = new System.Drawing.Size(409, 426);
            this.dataAnimal.TabIndex = 0;
            // 
            // dataPessoa
            // 
            this.dataPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPessoa.Location = new System.Drawing.Point(427, 12);
            this.dataPessoa.Name = "dataPessoa";
            this.dataPessoa.RowTemplate.Height = 25;
            this.dataPessoa.Size = new System.Drawing.Size(361, 426);
            this.dataPessoa.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPessoa);
            this.Controls.Add(this.dataAnimal);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAnimal;
        private System.Windows.Forms.DataGridView dataPessoa;
    }
}