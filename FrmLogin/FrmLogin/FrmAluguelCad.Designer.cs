namespace BibliotecaStar
{
    partial class FrmAluguelCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAluguelCad));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            TxtISBN = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtLivroId = new Label();
            TxtAlunoId = new Label();
            TxtStatus = new Label();
            TxtData2 = new Label();
            TxtData1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 319);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 17F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Entregue", "Atrasado", "Renovado" });
            comboBox1.Location = new Point(370, 382);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 54);
            comboBox1.TabIndex = 24;
            // 
            // TxtISBN
            // 
            TxtISBN.BorderColor = Color.FromArgb(224, 224, 224);
            TxtISBN.CustomizableEdges = customizableEdges1;
            TxtISBN.DefaultText = ".";
            TxtISBN.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxtISBN.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxtISBN.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxtISBN.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxtISBN.FillColor = Color.WhiteSmoke;
            TxtISBN.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtISBN.Font = new Font("Segoe UI", 1F);
            TxtISBN.ForeColor = Color.Black;
            TxtISBN.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtISBN.Location = new Point(584, -58);
            TxtISBN.Margin = new Padding(1);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.PlaceholderForeColor = Color.Black;
            TxtISBN.PlaceholderText = "Autor";
            TxtISBN.SelectedText = "";
            TxtISBN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TxtISBN.Size = new Size(22, 7);
            TxtISBN.TabIndex = 23;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 192, 0);
            guna2Button1.Font = new Font("Segoe UI", 14F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(370, 529);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(270, 68);
            guna2Button1.TabIndex = 22;
            guna2Button1.Text = "+ Item";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(437, 212);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 35;
            label5.Text = "genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 165);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 34;
            label4.Text = "lançado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 76);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 33;
            label3.Text = "autor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 123);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 32;
            label2.Text = "editora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 35);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 31;
            label1.Text = "titulo:";
            // 
            // TxtLivroId
            // 
            TxtLivroId.AutoSize = true;
            TxtLivroId.Location = new Point(511, 212);
            TxtLivroId.Name = "TxtLivroId";
            TxtLivroId.Size = new Size(16, 25);
            TxtLivroId.TabIndex = 30;
            TxtLivroId.Text = ".";
            // 
            // TxtAlunoId
            // 
            TxtAlunoId.AutoSize = true;
            TxtAlunoId.Location = new Point(511, 165);
            TxtAlunoId.Name = "TxtAlunoId";
            TxtAlunoId.Size = new Size(16, 25);
            TxtAlunoId.TabIndex = 29;
            TxtAlunoId.Text = ".";
            // 
            // TxtStatus
            // 
            TxtStatus.AutoSize = true;
            TxtStatus.Location = new Point(511, 123);
            TxtStatus.Name = "TxtStatus";
            TxtStatus.Size = new Size(16, 25);
            TxtStatus.TabIndex = 28;
            TxtStatus.Text = ".";
            // 
            // TxtData2
            // 
            TxtData2.AutoSize = true;
            TxtData2.Location = new Point(511, 76);
            TxtData2.Name = "TxtData2";
            TxtData2.Size = new Size(16, 25);
            TxtData2.TabIndex = 27;
            TxtData2.Text = ".";
            // 
            // TxtData1
            // 
            TxtData1.AutoSize = true;
            TxtData1.Location = new Point(511, 35);
            TxtData1.Name = "TxtData1";
            TxtData1.Size = new Size(16, 25);
            TxtData1.TabIndex = 26;
            TxtData1.Text = ".";
            // 
            // FrmAluguelCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 626);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtLivroId);
            Controls.Add(TxtAlunoId);
            Controls.Add(TxtStatus);
            Controls.Add(TxtData2);
            Controls.Add(TxtData1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(TxtISBN);
            Controls.Add(guna2Button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAluguelCad";
            Text = "FrmAluguelCad";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2TextBox TxtISBN;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label TxtLivroId;
        private Label TxtAlunoId;
        private Label TxtStatus;
        private Label TxtData2;
        private Label TxtData1;
    }
}