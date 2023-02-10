namespace Consultorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Botaomedico = new System.Windows.Forms.Button();
            this.botaopac = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Botaomedico
            // 
            this.Botaomedico.Location = new System.Drawing.Point(113, 167);
            this.Botaomedico.Name = "Botaomedico";
            this.Botaomedico.Size = new System.Drawing.Size(174, 86);
            this.Botaomedico.TabIndex = 0;
            this.Botaomedico.Text = "médico";
            this.Botaomedico.UseVisualStyleBackColor = true;
            this.Botaomedico.Click += new System.EventHandler(this.Botaomedico_Click);
            // 
            // botaopac
            // 
            this.botaopac.Location = new System.Drawing.Point(313, 167);
            this.botaopac.Name = "botaopac";
            this.botaopac.Size = new System.Drawing.Size(174, 86);
            this.botaopac.TabIndex = 1;
            this.botaopac.Text = "Paciente";
            this.botaopac.UseVisualStyleBackColor = true;
            this.botaopac.Click += new System.EventHandler(this.botaopac_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 265);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botaopac);
            this.Controls.Add(this.Botaomedico);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Botaomedico;
        private Button botaopac;
        private PictureBox pictureBox1;
    }
}