namespace Consultorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.botaopac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nomepac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teletex = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLID = new System.Windows.Forms.Label();
            this.labelfudida = new System.Windows.Forms.Label();
            this.senhapac = new System.Windows.Forms.TextBox();
            this.DescProb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaopac
            // 
            this.botaopac.Location = new System.Drawing.Point(470, 24);
            this.botaopac.Name = "botaopac";
            this.botaopac.Size = new System.Drawing.Size(123, 78);
            this.botaopac.TabIndex = 0;
            this.botaopac.Text = "Save";
            this.botaopac.UseVisualStyleBackColor = true;
            this.botaopac.Click += new System.EventHandler(this.botaopac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // Nomepac
            // 
            this.Nomepac.Location = new System.Drawing.Point(199, 15);
            this.Nomepac.Name = "Nomepac";
            this.Nomepac.Size = new System.Drawing.Size(250, 23);
            this.Nomepac.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // teletex
            // 
            this.teletex.Location = new System.Drawing.Point(199, 53);
            this.teletex.Name = "teletex";
            this.teletex.Size = new System.Drawing.Size(250, 23);
            this.teletex.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Location = new System.Drawing.Point(193, 9);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(0, 15);
            this.LBLID.TabIndex = 8;
            this.LBLID.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelfudida
            // 
            this.labelfudida.AutoSize = true;
            this.labelfudida.Location = new System.Drawing.Point(143, 92);
            this.labelfudida.Name = "labelfudida";
            this.labelfudida.Size = new System.Drawing.Size(39, 15);
            this.labelfudida.TabIndex = 9;
            this.labelfudida.Text = "Senha";
            // 
            // senhapac
            // 
            this.senhapac.Location = new System.Drawing.Point(199, 84);
            this.senhapac.Name = "senhapac";
            this.senhapac.Size = new System.Drawing.Size(250, 23);
            this.senhapac.TabIndex = 10;
            this.senhapac.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DescProb
            // 
            this.DescProb.Location = new System.Drawing.Point(199, 125);
            this.DescProb.Name = "DescProb";
            this.DescProb.Size = new System.Drawing.Size(250, 23);
            this.DescProb.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descrição Breve do Problema";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescProb);
            this.Controls.Add(this.senhapac);
            this.Controls.Add(this.labelfudida);
            this.Controls.Add(this.LBLID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.teletex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nomepac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaopac);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button botaopac;
        private Label label1;
        private TextBox Nomepac;
        private Button botaotele;
        private Label label2;
        private TextBox teletex;
        private PictureBox pictureBox1;
        private Label Iddrop1;
        private Label LBLID;
        private TextBox ID12;
        private Label labelfudida;
        private TextBox senhapac;
        private TextBox DescProb;
        private Label label3;
    }
}