namespace BibliotecaStar
{
    partial class FrmLivroInf
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivroInf));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            TxtTitulo = new Label();
            TxtAutor = new Label();
            TxtEditora = new Label();
            TxtAno = new Label();
            TxtGenero = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnFechar = new Guna.UI2.WinForms.Guna2Button();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtTitulo
            // 
            TxtTitulo.AutoSize = true;
            TxtTitulo.Location = new Point(257, 95);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(16, 25);
            TxtTitulo.TabIndex = 0;
            TxtTitulo.Text = ".";
            // 
            // TxtAutor
            // 
            TxtAutor.AutoSize = true;
            TxtAutor.Location = new Point(257, 136);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(16, 25);
            TxtAutor.TabIndex = 1;
            TxtAutor.Text = ".";
            // 
            // TxtEditora
            // 
            TxtEditora.AutoSize = true;
            TxtEditora.Location = new Point(257, 183);
            TxtEditora.Name = "TxtEditora";
            TxtEditora.Size = new Size(16, 25);
            TxtEditora.TabIndex = 2;
            TxtEditora.Text = ".";
            // 
            // TxtAno
            // 
            TxtAno.AutoSize = true;
            TxtAno.Location = new Point(257, 225);
            TxtAno.Name = "TxtAno";
            TxtAno.Size = new Size(16, 25);
            TxtAno.TabIndex = 3;
            TxtAno.Text = ".";
            // 
            // TxtGenero
            // 
            TxtGenero.AutoSize = true;
            TxtGenero.Location = new Point(257, 272);
            TxtGenero.Name = "TxtGenero";
            TxtGenero.Size = new Size(16, 25);
            TxtGenero.TabIndex = 4;
            TxtGenero.Text = ".";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Gold;
            guna2Button1.Font = new Font("Segoe UI", 14F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(56, 417);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(270, 68);
            guna2Button1.TabIndex = 13;
            guna2Button1.Text = "Alugar";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 95);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 14;
            label1.Text = "titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 183);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 15;
            label2.Text = "editora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 136);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 16;
            label3.Text = "autor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 225);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 17;
            label4.Text = "lançado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 272);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 18;
            label5.Text = "genero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gold;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(160, 373);
            label6.Name = "label6";
            label6.Size = new Size(74, 32);
            label6.TabIndex = 19;
            label6.Text = "15 R$";
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.Transparent;
            BtnFechar.BackgroundImage = (Image)resources.GetObject("BtnFechar.BackgroundImage");
            BtnFechar.CustomizableEdges = customizableEdges3;
            BtnFechar.DisabledState.BorderColor = Color.DarkGray;
            BtnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnFechar.FillColor = Color.Transparent;
            BtnFechar.Font = new Font("Segoe UI", 20F);
            BtnFechar.ForeColor = Color.Black;
            BtnFechar.Location = new Point(583, -1);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnFechar.Size = new Size(66, 68);
            BtnFechar.TabIndex = 20;
            BtnFechar.Text = "X";
            BtnFechar.Click += BtnFechar_Click;
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.BackColor = Color.FromArgb(128, 128, 255);
            guna2GroupBox1.BorderColor = Color.White;
            guna2GroupBox1.BorderRadius = 50;
            guna2GroupBox1.BorderThickness = 0;
            guna2GroupBox1.Controls.Add(guna2Button1);
            guna2GroupBox1.Controls.Add(label6);
            guna2GroupBox1.CustomBorderColor = Color.Transparent;
            guna2GroupBox1.CustomizableEdges = customizableEdges5;
            guna2GroupBox1.Font = new Font("Segoe UI", 9F);
            guna2GroupBox1.ForeColor = Color.White;
            guna2GroupBox1.Location = new Point(127, 59);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GroupBox1.Size = new Size(394, 508);
            guna2GroupBox1.TabIndex = 24;
            // 
            // FrmLivroInf
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(646, 673);
            Controls.Add(BtnFechar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtGenero);
            Controls.Add(TxtAno);
            Controls.Add(TxtEditora);
            Controls.Add(TxtAutor);
            Controls.Add(TxtTitulo);
            Controls.Add(guna2GroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLivroInf";
            Text = "FrmLivroInf";
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TxtTitulo;
        private Label TxtAutor;
        private Label TxtEditora;
        private Label TxtAno;
        private Label TxtGenero;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button BtnFechar;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}