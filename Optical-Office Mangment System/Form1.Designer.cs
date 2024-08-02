using System.Windows.Forms;

namespace Optical_Office_Mangment_System
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // DataGridView Setup
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 425);
            this.dataGridView1.TabIndex = 0;
            this.Controls.Add(this.dataGridView1);

            // Setup ComboBox Column
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "ComboBoxColumn";
            comboBoxColumn.HeaderText = "Select Item";
            comboBoxColumn.Items.AddRange("Item1", "Item2", "Item3"); // Add your items here

            // Add the ComboBox column to DataGridView
            this.dataGridView1.Columns.Add(comboBoxColumn);

            // Add a sample row to DataGridView
            this.dataGridView1.Rows.Add(); // Add a row with ComboBox cell

            this.ResumeLayout(false);

            this.Text = "Form1";
        }

        #endregion
    }
}