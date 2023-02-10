namespace Consultorio
{
    partial class Medicoform
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
            this.Savemed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nomemedico = new System.Windows.Forms.TextBox();
            this.cpfmedico = new System.Windows.Forms.TextBox();
            this.rgmedico = new System.Windows.Forms.TextBox();
            this.senhamedico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Savemed
            // 
            this.Savemed.Location = new System.Drawing.Point(450, 86);
            this.Savemed.Name = "Savemed";
            this.Savemed.Size = new System.Drawing.Size(136, 81);
            this.Savemed.TabIndex = 0;
            this.Savemed.Text = "Entrar";
            this.Savemed.UseVisualStyleBackColor = true;
            this.Savemed.Click += new System.EventHandler(this.Savemed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha";
            // 
            // Nomemedico
            // 
            this.Nomemedico.Location = new System.Drawing.Point(154, 49);
            this.Nomemedico.Name = "Nomemedico";
            this.Nomemedico.Size = new System.Drawing.Size(248, 23);
            this.Nomemedico.TabIndex = 5;
            // 
            // cpfmedico
            // 
            this.cpfmedico.Location = new System.Drawing.Point(154, 86);
            this.cpfmedico.Name = "cpfmedico";
            this.cpfmedico.Size = new System.Drawing.Size(248, 23);
            this.cpfmedico.TabIndex = 6;
            // 
            // rgmedico
            // 
            this.rgmedico.Location = new System.Drawing.Point(154, 125);
            this.rgmedico.Name = "rgmedico";
            this.rgmedico.Size = new System.Drawing.Size(248, 23);
            this.rgmedico.TabIndex = 7;
            // 
            // senhamedico
            // 
            this.senhamedico.Location = new System.Drawing.Point(154, 160);
            this.senhamedico.Name = "senhamedico";
            this.senhamedico.Size = new System.Drawing.Size(248, 23);
            this.senhamedico.TabIndex = 8;
            // 
            // Medicoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.senhamedico);
            this.Controls.Add(this.rgmedico);
            this.Controls.Add(this.cpfmedico);
            this.Controls.Add(this.Nomemedico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Savemed);
            this.Name = "Medicoform";
            this.Text = "Medicoform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Savemed;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nomemedico;
        private TextBox cpfmedico;
        private TextBox rgmedico;
        private TextBox senhamedico;
    }
}