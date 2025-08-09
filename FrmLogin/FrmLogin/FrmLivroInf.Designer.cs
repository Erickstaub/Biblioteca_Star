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
            TxtTitulo = new Label();
            TxtAutor = new Label();
            TxtEditora = new Label();
            TxtAno = new Label();
            TxtGenero = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // TxtTitulo
            // 
            TxtTitulo.AutoSize = true;
            TxtTitulo.Location = new Point(225, 96);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(59, 25);
            TxtTitulo.TabIndex = 0;
            TxtTitulo.Text = "label1";
            // 
            // TxtAutor
            // 
            TxtAutor.AutoSize = true;
            TxtAutor.Location = new Point(225, 141);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(59, 25);
            TxtAutor.TabIndex = 1;
            TxtAutor.Text = "label1";
            // 
            // TxtEditora
            // 
            TxtEditora.AutoSize = true;
            TxtEditora.Location = new Point(225, 186);
            TxtEditora.Name = "TxtEditora";
            TxtEditora.Size = new Size(59, 25);
            TxtEditora.TabIndex = 2;
            TxtEditora.Text = "label1";
            // 
            // TxtAno
            // 
            TxtAno.AutoSize = true;
            TxtAno.Location = new Point(225, 224);
            TxtAno.Name = "TxtAno";
            TxtAno.Size = new Size(59, 25);
            TxtAno.TabIndex = 3;
            TxtAno.Text = "label1";
            // 
            // TxtGenero
            // 
            TxtGenero.AutoSize = true;
            TxtGenero.Location = new Point(225, 269);
            TxtGenero.Name = "TxtGenero";
            TxtGenero.Size = new Size(45, 25);
            TxtGenero.TabIndex = 4;
            TxtGenero.Text = "ddd";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(128, 255, 128);
            guna2Button1.Font = new Font("Segoe UI", 14F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(225, 497);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(270, 68);
            guna2Button1.TabIndex = 13;
            guna2Button1.Text = "+ Item";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // FrmLivroInf
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 673);
            Controls.Add(guna2Button1);
            Controls.Add(TxtGenero);
            Controls.Add(TxtAno);
            Controls.Add(TxtEditora);
            Controls.Add(TxtAutor);
            Controls.Add(TxtTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLivroInf";
            Text = "FrmLivroInf";
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
    }
}