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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            uiGroupBox1 = new UIGroupBox();
            Submit = new UIButton();
            uiCheckBoxGroup2 = new UICheckBoxGroup();
            panel1 = new Panel();
            uiCheckBoxGroup1 = new UICheckBoxGroup();
            uiDataGridView1 = new UIDataGridView();
            downloadExcel = new UIButton();
            uiGroupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(Submit);
            uiGroupBox1.Controls.Add(uiCheckBoxGroup2);
            uiGroupBox1.Controls.Add(panel1);
            uiGroupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox1.Location = new Point(22, 34);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(240, 643);
            uiGroupBox1.TabIndex = 2;
            uiGroupBox1.Text = "Filtros";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // Submit
            // 
            Submit.Font = new Font("Microsoft Sans Serif", 12F);
            Submit.Location = new Point(66, 590);
            Submit.MinimumSize = new Size(1, 1);
            Submit.Name = "Submit";
            Submit.Size = new Size(100, 35);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            Submit.Click += Submit_Click;
            // 
            // uiCheckBoxGroup2
            // 
            uiCheckBoxGroup2.Font = new Font("Microsoft Sans Serif", 12F);
            uiCheckBoxGroup2.Location = new Point(15, 178);
            uiCheckBoxGroup2.Margin = new Padding(4, 5, 4, 5);
            uiCheckBoxGroup2.MinimumSize = new Size(1, 1);
            uiCheckBoxGroup2.Name = "uiCheckBoxGroup2";
            uiCheckBoxGroup2.Padding = new Padding(0, 32, 0, 0);
            uiCheckBoxGroup2.SelectedIndexes = (List<int>)resources.GetObject("uiCheckBoxGroup2.SelectedIndexes");
            uiCheckBoxGroup2.Size = new Size(210, 404);
            uiCheckBoxGroup2.TabIndex = 1;
            uiCheckBoxGroup2.Text = "Meses";
            uiCheckBoxGroup2.TextAlignment = ContentAlignment.MiddleLeft;
            uiCheckBoxGroup2.ValueChanged += uiCheckBoxGroup2_ValueChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(uiCheckBoxGroup1);
            panel1.ForeColor = Color.FromArgb(80, 160, 255);
            panel1.Location = new Point(15, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 114);
            panel1.TabIndex = 4;
            // 
            // uiCheckBoxGroup1
            // 
            uiCheckBoxGroup1.Font = new Font("Microsoft Sans Serif", 12F);
            uiCheckBoxGroup1.Location = new Point(4, 5);
            uiCheckBoxGroup1.Margin = new Padding(4, 5, 4, 5);
            uiCheckBoxGroup1.MinimumSize = new Size(1, 1);
            uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            uiCheckBoxGroup1.Padding = new Padding(0, 32, 0, 0);
            uiCheckBoxGroup1.SelectedIndexes = (List<int>)resources.GetObject("uiCheckBoxGroup1.SelectedIndexes");
            uiCheckBoxGroup1.Size = new Size(187, 400);
            uiCheckBoxGroup1.TabIndex = 0;
            uiCheckBoxGroup1.Text = "Años";
            uiCheckBoxGroup1.TextAlignment = ContentAlignment.MiddleLeft;
            uiCheckBoxGroup1.ValueChanged += uiCheckBoxGroup1_ValueChanged;
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(332, 49);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            uiDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(992, 628);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 3;
            uiDataGridView1.CellContentClick += uiDataGridView1_CellContentClick;
            // 
            // downloadExcel
            // 
            downloadExcel.Font = new Font("Microsoft Sans Serif", 12F);
            downloadExcel.Location = new Point(1224, 8);
            downloadExcel.MinimumSize = new Size(1, 1);
            downloadExcel.Name = "downloadExcel";
            downloadExcel.Size = new Size(100, 35);
            downloadExcel.TabIndex = 4;
            downloadExcel.Text = "Descargar";
            downloadExcel.TipsFont = new Font("Microsoft Sans Serif", 9F);
            downloadExcel.Click += downloadExcel_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 681);
            Controls.Add(downloadExcel);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiGroupBox1);
            Name = "Reportes";
            Text = "PantallaReportes";
            Load += Reportes_Load;
            uiGroupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
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
    }
}