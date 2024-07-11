namespace Optical_Office_Mangment_System
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBills = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.tabWorkers = new System.Windows.Forms.TabPage();
            this.tabAnalytics = new System.Windows.Forms.TabPage();
            this.tabPageReportUpload = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBills);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Controls.Add(this.tabWorkers);
            this.tabControl1.Controls.Add(this.tabAnalytics);
            this.tabControl1.Controls.Add(this.tabPageReportUpload);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1367, 710);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabBills
            // 
            this.tabBills.Controls.Add(this.button2);
            this.tabBills.Controls.Add(this.button1);
            this.tabBills.Controls.Add(this.dataGridView1);
            this.tabBills.Controls.Add(this.comboBox1);
            this.tabBills.Controls.Add(this.label1);
            this.tabBills.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabBills.ForeColor = System.Drawing.Color.Black;
            this.tabBills.Location = new System.Drawing.Point(4, 33);
            this.tabBills.Name = "tabBills";
            this.tabBills.Padding = new System.Windows.Forms.Padding(3);
            this.tabBills.Size = new System.Drawing.Size(1359, 673);
            this.tabBills.TabIndex = 0;
            this.tabBills.Text = "الفواتير";
            this.tabBills.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(232, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(36, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1347, 448);
            this.dataGridView1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(959, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(241, 32);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1219, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "العميل:";
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.groupBox1);
            this.tabCustomers.Location = new System.Drawing.Point(4, 33);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(1359, 673);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "العملاء";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Location = new System.Drawing.Point(4, 33);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(1359, 673);
            this.tabSuppliers.TabIndex = 2;
            this.tabSuppliers.Text = "الموردين";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // tabWorkers
            // 
            this.tabWorkers.Location = new System.Drawing.Point(4, 33);
            this.tabWorkers.Name = "tabWorkers";
            this.tabWorkers.Size = new System.Drawing.Size(1359, 673);
            this.tabWorkers.TabIndex = 3;
            this.tabWorkers.Text = "العاملين";
            this.tabWorkers.UseVisualStyleBackColor = true;
            // 
            // tabAnalytics
            // 
            this.tabAnalytics.Location = new System.Drawing.Point(4, 33);
            this.tabAnalytics.Name = "tabAnalytics";
            this.tabAnalytics.Size = new System.Drawing.Size(1359, 673);
            this.tabAnalytics.TabIndex = 4;
            this.tabAnalytics.Text = "التحليلات";
            this.tabAnalytics.UseVisualStyleBackColor = true;
            // 
            // tabPageReportUpload
            // 
            this.tabPageReportUpload.Location = new System.Drawing.Point(4, 33);
            this.tabPageReportUpload.Name = "tabPageReportUpload";
            this.tabPageReportUpload.Size = new System.Drawing.Size(1359, 673);
            this.tabPageReportUpload.TabIndex = 5;
            this.tabPageReportUpload.Text = "رفع تقرير اليوم";
            this.tabPageReportUpload.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(956, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 624);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 710);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabBills.ResumeLayout(false);
            this.tabBills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBills;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tabWorkers;
        private System.Windows.Forms.TabPage tabAnalytics;
        private System.Windows.Forms.TabPage tabPageReportUpload;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}