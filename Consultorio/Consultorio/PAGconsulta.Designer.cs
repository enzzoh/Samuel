namespace Consultorio
{
    partial class PAGconsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.confirmcons = new System.Windows.Forms.Button();
            this.datacons = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Horacons = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.senhaaleatoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Aceitarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // confirmcons
            // 
            this.confirmcons.Location = new System.Drawing.Point(503, 30);
            this.confirmcons.Name = "confirmcons";
            this.confirmcons.Size = new System.Drawing.Size(119, 64);
            this.confirmcons.TabIndex = 2;
            this.confirmcons.Text = "Gerar";
            this.confirmcons.UseVisualStyleBackColor = true;
            this.confirmcons.Click += new System.EventHandler(this.button1_Click);
            // 
            // datacons
            // 
            this.datacons.Location = new System.Drawing.Point(137, 38);
            this.datacons.Name = "datacons";
            this.datacons.Size = new System.Drawing.Size(253, 23);
            this.datacons.TabIndex = 3;
            this.datacons.TextChanged += new System.EventHandler(this.datacons_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora";
            // 
            // Horacons
            // 
            this.Horacons.Location = new System.Drawing.Point(137, 79);
            this.Horacons.Name = "Horacons";
            this.Horacons.Size = new System.Drawing.Size(253, 23);
            this.Horacons.TabIndex = 5;
            this.Horacons.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha Aleatoria";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // senhaaleatoria
            // 
            this.senhaaleatoria.Location = new System.Drawing.Point(137, 117);
            this.senhaaleatoria.Name = "senhaaleatoria";
            this.senhaaleatoria.Size = new System.Drawing.Size(253, 23);
            this.senhaaleatoria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha aleatoria é necessaria para entrar no consultorio local";
            // 
            // Aceitarbutton
            // 
            this.Aceitarbutton.Location = new System.Drawing.Point(503, 136);
            this.Aceitarbutton.Name = "Aceitarbutton";
            this.Aceitarbutton.Size = new System.Drawing.Size(119, 64);
            this.Aceitarbutton.TabIndex = 9;
            this.Aceitarbutton.Text = "Aceitar";
            this.Aceitarbutton.UseVisualStyleBackColor = true;
            this.Aceitarbutton.Click += new System.EventHandler(this.Aceitarbutton_Click);
            // 
            // PAGconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aceitarbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.senhaaleatoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Horacons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datacons);
            this.Controls.Add(this.confirmcons);
            this.Controls.Add(this.label1);
            this.Name = "PAGconsulta";
            this.Text = "PAGconsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button confirmcons;
        private TextBox datacons;
        private Label label2;
        private TextBox Horacons;
        private Label label3;
        private TextBox senhaaleatoria;
        private Label label4;
        private Button Aceitarbutton;
    }
}