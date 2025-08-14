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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            BtnFechar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
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
            label5.Size = new Size(61, 25);
            label5.TabIndex = 35;
            label5.Text = "livroid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 165);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 34;
            label4.Text = "alunoid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 76);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 33;
            label3.Text = "devolver";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 123);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 32;
            label2.Text = "status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 35);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 31;
            label1.Text = "alugado";
            // 
            // TxtLivroId
            // 
            TxtLivroId.AutoSize = true;
            TxtLivroId.Location = new Point(511, 165);
            TxtLivroId.Name = "TxtLivroId";
            TxtLivroId.Size = new Size(16, 25);
            TxtLivroId.TabIndex = 30;
            TxtLivroId.Text = ".";
            // 
            // TxtAlunoId
            // 
            TxtAlunoId.AutoSize = true;
            TxtAlunoId.Location = new Point(511, 212);
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
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(-148, 94);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 62;
            guna2DataGridView1.Size = new Size(118, 10);
            guna2DataGridView1.TabIndex = 36;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 33;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // BtnFechar
            // 
            BtnFechar.CustomizableEdges = customizableEdges5;
            BtnFechar.DisabledState.BorderColor = Color.DarkGray;
            BtnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnFechar.FillColor = Color.WhiteSmoke;
            BtnFechar.Font = new Font("Segoe UI", 20F);
            BtnFechar.ForeColor = Color.Black;
            BtnFechar.Location = new Point(592, -8);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BtnFechar.Size = new Size(66, 68);
            BtnFechar.TabIndex = 37;
            BtnFechar.Text = "X";
            BtnFechar.Click += BtnFechar_Click;
            // 
            // FrmAluguelCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 626);
            Controls.Add(BtnFechar);
            Controls.Add(guna2DataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button BtnFechar;
    }
}