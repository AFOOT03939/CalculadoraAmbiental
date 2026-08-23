using Sunny.UI;

namespace CalculadoraAmbienta.PantallaReportes
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiGroupBox1 = new UIGroupBox();
            panel3 = new Panel();
            uiCheckBoxGroup2 = new UICheckBoxGroup();
            panel1 = new Panel();
            uiCheckBoxGroup1 = new UICheckBoxGroup();
            Submit = new UIButton();
            uiDataGridView1 = new UIDataGridView();
            downloadExcel = new UIButton();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            panel10 = new Panel();
            panel12 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel8 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            panel7 = new Panel();
            label8 = new Label();
            label7 = new Label();
            panel9 = new Panel();
            panel4 = new Panel();
            uiGroupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            panel12.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Anchor = AnchorStyles.Right;
            uiGroupBox1.Controls.Add(panel3);
            uiGroupBox1.Controls.Add(panel1);
            uiGroupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox1.Location = new Point(53, 7);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.RectColor = Color.FromArgb(57, 131, 48);
            uiGroupBox1.Size = new Size(240, 457);
            uiGroupBox1.TabIndex = 2;
            uiGroupBox1.Text = "Filtros";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(uiCheckBoxGroup2);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(15, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 280);
            panel3.TabIndex = 5;
            // 
            // uiCheckBoxGroup2
            // 
            uiCheckBoxGroup2.CheckBoxColor = Color.FromArgb(57, 131, 48);
            uiCheckBoxGroup2.Font = new Font("Microsoft Sans Serif", 12F);
            uiCheckBoxGroup2.Location = new Point(4, 5);
            uiCheckBoxGroup2.Margin = new Padding(4, 5, 4, 5);
            uiCheckBoxGroup2.MinimumSize = new Size(1, 1);
            uiCheckBoxGroup2.Name = "uiCheckBoxGroup2";
            uiCheckBoxGroup2.Padding = new Padding(0, 32, 0, 0);
            uiCheckBoxGroup2.RectColor = Color.White;
            uiCheckBoxGroup2.SelectedIndexes = (List<int>)resources.GetObject("uiCheckBoxGroup2.SelectedIndexes");
            uiCheckBoxGroup2.Size = new Size(187, 400);
            uiCheckBoxGroup2.TabIndex = 1;
            uiCheckBoxGroup2.Text = "Meses";
            uiCheckBoxGroup2.TextAlignment = ContentAlignment.MiddleLeft;
            uiCheckBoxGroup2.ValueChanged += uiCheckBoxGroup2_ValueChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(uiCheckBoxGroup1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(15, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 96);
            panel1.TabIndex = 4;
            // 
            // uiCheckBoxGroup1
            // 
            uiCheckBoxGroup1.CheckBoxColor = Color.FromArgb(57, 131, 48);
            uiCheckBoxGroup1.Font = new Font("Microsoft Sans Serif", 12F);
            uiCheckBoxGroup1.Location = new Point(4, 5);
            uiCheckBoxGroup1.Margin = new Padding(4, 5, 4, 5);
            uiCheckBoxGroup1.MinimumSize = new Size(1, 1);
            uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            uiCheckBoxGroup1.Padding = new Padding(0, 32, 0, 0);
            uiCheckBoxGroup1.RectColor = Color.White;
            uiCheckBoxGroup1.SelectedIndexes = (List<int>)resources.GetObject("uiCheckBoxGroup1.SelectedIndexes");
            uiCheckBoxGroup1.Size = new Size(187, 410);
            uiCheckBoxGroup1.TabIndex = 0;
            uiCheckBoxGroup1.Text = "Años";
            uiCheckBoxGroup1.TextAlignment = ContentAlignment.MiddleLeft;
            uiCheckBoxGroup1.ValueChanged += uiCheckBoxGroup1_ValueChanged;
            // 
            // Submit
            // 
            Submit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Submit.FillColor = Color.FromArgb(57, 131, 48);
            Submit.FillHoverColor = Color.FromArgb(72, 150, 62);
            Submit.FillPressColor = Color.FromArgb(45, 108, 38);
            Submit.FillSelectedColor = Color.FromArgb(45, 108, 38);
            Submit.Font = new Font("Microsoft Sans Serif", 12F);
            Submit.Location = new Point(55, 474);
            Submit.MinimumSize = new Size(1, 1);
            Submit.Name = "Submit";
            Submit.RectColor = Color.FromArgb(57, 131, 48);
            Submit.RectHoverColor = Color.FromArgb(72, 150, 62);
            Submit.RectPressColor = Color.FromArgb(45, 108, 38);
            Submit.RectSelectedColor = Color.FromArgb(45, 108, 38);
            Submit.Size = new Size(239, 35);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            Submit.Click += Submit_Click;
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.Anchor = AnchorStyles.None;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.GridColor = Color.FromArgb(57, 131, 48);
            uiDataGridView1.Location = new Point(12, 22);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.RectColor = Color.FromArgb(57, 131, 48);
            uiDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.ScrollBarColor = Color.FromArgb(57, 131, 48);
            uiDataGridView1.ScrollBarRectColor = Color.FromArgb(57, 131, 48);
            uiDataGridView1.ScrollBarStyleInherited = false;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(892, 493);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 3;
            uiDataGridView1.CellContentClick += uiDataGridView1_CellContentClick;
            // 
            // downloadExcel
            // 
            downloadExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            downloadExcel.FillColor = Color.FromArgb(57, 131, 48);
            downloadExcel.FillHoverColor = Color.FromArgb(72, 150, 62);
            downloadExcel.FillPressColor = Color.FromArgb(45, 108, 38);
            downloadExcel.FillSelectedColor = Color.FromArgb(45, 108, 38);
            downloadExcel.Font = new Font("Microsoft Sans Serif", 12F);
            downloadExcel.Location = new Point(895, 77);
            downloadExcel.MinimumSize = new Size(1, 1);
            downloadExcel.Name = "downloadExcel";
            downloadExcel.RectColor = Color.FromArgb(57, 131, 48);
            downloadExcel.RectHoverColor = Color.FromArgb(72, 150, 62);
            downloadExcel.RectPressColor = Color.FromArgb(45, 108, 38);
            downloadExcel.RectSelectedColor = Color.FromArgb(45, 108, 38);
            downloadExcel.Size = new Size(100, 35);
            downloadExcel.TabIndex = 4;
            downloadExcel.Text = "Descargar";
            downloadExcel.TipsFont = new Font("Microsoft Sans Serif", 9F);
            downloadExcel.Click += downloadExcel_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 518);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.97152F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.02848F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel5, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 91.89189F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.10810852F));
            tableLayoutPanel2.Size = new Size(1264, 518);
            tableLayoutPanel2.TabIndex = 3;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(Submit, 0, 1);
            tableLayoutPanel3.Controls.Add(uiGroupBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 91.99219F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.0078125F));
            tableLayoutPanel3.Size = new Size(297, 512);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel12);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(306, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(955, 512);
            panel5.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(955, 16);
            panel10.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(uiDataGridView1);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(955, 512);
            panel12.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1264, 125);
            panel6.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.810126F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.1424F));
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
            // 
            // panel8
            // 
            panel8.Controls.Add(tableLayoutPanel5);
            panel8.Controls.Add(downloadExcel);
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(127, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(1007, 119);
            panel8.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.98044F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.01956F));
            tableLayoutPanel5.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel5.Controls.Add(panel7, 1, 0);
            tableLayoutPanel5.Location = new Point(3, 47);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(624, 65);
            tableLayoutPanel5.TabIndex = 5;
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
            panel9.Size = new Size(1007, 2);
            panel9.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 643);
            panel4.Name = "panel4";
            panel4.Size = new Size(1264, 38);
            panel4.TabIndex = 8;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Name = "Reportes";
            Text = "PantallaReportes";
            Load += Reportes_Load;
            uiGroupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private UIGroupBox uiGroupBox1;
        private UICheckBoxGroup uiCheckBoxGroup2;
        private UICheckBoxGroup uiCheckBoxGroup1;
        private Panel panel1;
        private UIDataGridView uiDataGridView1;
        private UIButton Submit;
        private UIButton downloadExcel;
        private Panel panel2;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox pictureBox3;
        private Panel panel7;
        private Label label8;
        private Label label7;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel5;
        private Panel panel10;
        private Panel panel12;
    }
}