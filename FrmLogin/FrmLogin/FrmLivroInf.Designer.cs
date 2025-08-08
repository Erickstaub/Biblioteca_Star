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
            TxtTitulo = new Label();
            TxtAutor = new Label();
            TxtEditora = new Label();
            TxtAno = new Label();
            TxtGenero = new Label();
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
            // FrmLivroInf
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 673);
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
    }
}