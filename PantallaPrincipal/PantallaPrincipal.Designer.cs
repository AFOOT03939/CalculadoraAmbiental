namespace CalculadoraAmbienta.PantallaPrincipal
{
    partial class PantallaPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            uiButton1 = new Sunny.UI.UIButton();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            uiButton2 = new Sunny.UI.UIButton();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel10 = new Panel();
            panel11 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel8 = new Panel();
            label11 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            panel7 = new Panel();
            label8 = new Label();
            label7 = new Label();
            panel9 = new Panel();
            panel1 = new Panel();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 218);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 218);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 476);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Controls.Add(panel5, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1264, 476);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint_1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Right;
            panel4.Controls.Add(tableLayoutPanel4);
            panel4.Location = new Point(372, 88);
            panel4.Margin = new Padding(10);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 300);
            panel4.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(uiButton1, 0, 3);
            tableLayoutPanel4.Controls.Add(label5, 0, 2);
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel4.Location = new Point(1, -2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 75.35211F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 24.6478882F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(248, 305);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(57, 131, 48);
            label3.Location = new Point(39, 159);
            label3.Name = "label3";
            label3.Size = new Size(169, 37);
            label3.TabIndex = 2;
            label3.Text = "Calculadora";
            // 
            // uiButton1
            // 
            uiButton1.Anchor = AnchorStyles.None;
            uiButton1.FillColor = Color.FromArgb(57, 131, 48);
            uiButton1.FillHoverColor = Color.FromArgb(72, 150, 62);
            uiButton1.FillPressColor = Color.FromArgb(45, 108, 38);
            uiButton1.FillSelectedColor = Color.FromArgb(45, 108, 38);
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(29, 257);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.FromArgb(57, 131, 48);
            uiButton1.RectHoverColor = Color.FromArgb(72, 150, 62);
            uiButton1.RectPressColor = Color.FromArgb(45, 108, 38);
            uiButton1.RectSelectedColor = Color.FromArgb(45, 108, 38);
            uiButton1.Size = new Size(190, 37);
            uiButton1.TabIndex = 0;
            uiButton1.Text = "Calculadora";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton1.Click += uiButton1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(4, 206);
            label5.Name = "label5";
            label5.Size = new Size(240, 38);
            label5.TabIndex = 3;
            label5.Text = "Ingresa tus datos y calcula tu impacto ambiental";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(31, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left;
            panel5.Controls.Add(tableLayoutPanel3);
            panel5.Location = new Point(642, 88);
            panel5.Margin = new Padding(10);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 300);
            panel5.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(uiButton2, 0, 3);
            tableLayoutPanel3.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(label6, 0, 2);
            tableLayoutPanel3.Location = new Point(1, -2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 74.28571F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25.7142849F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel3.Size = new Size(248, 305);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // uiButton2
            // 
            uiButton2.Anchor = AnchorStyles.None;
            uiButton2.FillColor = Color.FromArgb(57, 131, 48);
            uiButton2.FillHoverColor = Color.FromArgb(72, 150, 62);
            uiButton2.FillPressColor = Color.FromArgb(45, 108, 38);
            uiButton2.FillSelectedColor = Color.FromArgb(45, 108, 38);
            uiButton2.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton2.Location = new Point(29, 257);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.RectColor = Color.FromArgb(57, 131, 48);
            uiButton2.RectHoverColor = Color.FromArgb(72, 150, 62);
            uiButton2.RectPressColor = Color.FromArgb(45, 108, 38);
            uiButton2.RectSelectedColor = Color.FromArgb(45, 108, 38);
            uiButton2.Size = new Size(190, 37);
            uiButton2.TabIndex = 4;
            uiButton2.Text = "Reportes";
            uiButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton2.Click += uiButton2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(57, 131, 48);
            label4.Location = new Point(57, 158);
            label4.Name = "label4";
            label4.Size = new Size(133, 37);
            label4.TabIndex = 4;
            label4.Text = "Reportes";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(53, 206);
            label6.Name = "label6";
            label6.Size = new Size(142, 38);
            label6.TabIndex = 5;
            label6.Text = "Consulta y analiza tus\n reportes generados";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel6);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 601);
            panel3.Name = "panel3";
            panel3.Size = new Size(1264, 80);
            panel3.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.None;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.Controls.Add(panel10, 1, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(1264, 80);
            tableLayoutPanel6.TabIndex = 0;
            tableLayoutPanel6.Paint += tableLayoutPanel6_Paint;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(tableLayoutPanel7);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(129, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(1005, 74);
            panel10.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(57, 131, 48);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1005, 2);
            panel11.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Left;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.38820648F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.61179F));
            tableLayoutPanel7.Controls.Add(label9, 1, 0);
            tableLayoutPanel7.Controls.Add(pictureBox4, 0, 0);
            tableLayoutPanel7.Location = new Point(6, 19);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(407, 33);
            tableLayoutPanel7.TabIndex = 6;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(57, 131, 48);
            label9.Location = new Point(29, 10);
            label9.Name = "label9";
            label9.Size = new Size(149, 13);
            label9.TabIndex = 6;
            label9.Text = "Calculadora Ambiental v1.0";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel1);
            panel6.Controls.Add(panel1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1264, 125);
            panel6.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(panel8, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1264, 125);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel8
            // 
            panel8.Controls.Add(label11);
            panel8.Controls.Add(tableLayoutPanel5);
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(129, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(1005, 119);
            panel8.TabIndex = 4;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(57, 131, 48);
            label11.Location = new Point(730, 90);
            label11.Name = "label11";
            label11.Size = new Size(308, 13);
            label11.TabIndex = 7;
            label11.Text = "Subdirección de Igualdad, Inclusión y Derechos Humanos.";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.98044F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.01956F));
            tableLayoutPanel5.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel5.Controls.Add(panel7, 1, 0);
            tableLayoutPanel5.Location = new Point(3, 46);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(624, 65);
            tableLayoutPanel5.TabIndex = 5;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(77, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(544, 59);
            panel7.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(3, 37);
            label8.Name = "label8";
            label8.Size = new Size(368, 19);
            label8.TabIndex = 5;
            label8.Text = "Herramienta para Analizar y Calcular tu Impacto Ambiental";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(57, 131, 48);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(310, 37);
            label7.TabIndex = 5;
            label7.Text = "Calculadora Ambiental";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(57, 131, 48);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 117);
            panel9.Name = "panel9";
            panel9.Size = new Size(1005, 2);
            panel9.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 131, 48);
            panel1.Location = new Point(22, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 2);
            panel1.TabIndex = 0;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(label1);
            Name = "PantallaPrincipal";
            Text = "PantallaPrincipal";
            Load += PantallaPrincipal_Load;
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Panel panel6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Panel panel8;
        private Panel panel9;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel10;
        private Label label9;
        private Panel panel11;
        private TableLayoutPanel tableLayoutPanel7;
        private PictureBox pictureBox4;
        private Label label11;
    }
}