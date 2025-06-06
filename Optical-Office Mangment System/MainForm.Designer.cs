﻿using System.Windows.Forms;

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
            this.numericUpDowntotalBillCost = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.comboBoxGlassesTypeBill = new System.Windows.Forms.ComboBox();
            this.dataGridViewRunTimeBills = new System.Windows.Forms.DataGridView();
            this.GlassesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpticType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cyl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpticPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manfc_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpticCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddIteamToBill = new System.Windows.Forms.Button();
            this.label58 = new System.Windows.Forms.Label();
            this.textBoxBillOpticCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCustomersNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCustomerNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCustomerPayAmount = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxCustomerPaymentRemain = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCustomerPayTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCustomerPayMoney = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewCustomerAccount = new System.Windows.Forms.DataGridView();
            this.DateTimeCustomerAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCustomerAccountInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCustomerMoney = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewBillInfo = new System.Windows.Forms.DataGridView();
            this.comboBoxCustomersNamesInfoBills = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSupplierAddedCost = new System.Windows.Forms.NumericUpDown();
            this.button23 = new System.Windows.Forms.Button();
            this.textBoxTotalSupplierCost = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.comboBoxSupplierAddCost = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSupplierPayAmount = new System.Windows.Forms.NumericUpDown();
            this.button9 = new System.Windows.Forms.Button();
            this.textBoxRemainSupplierPayment = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxSupplierPayTotal = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxPayToSuppliers = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBoxSupplierPhoneNumber = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridViewSupplierInfoPay = new System.Windows.Forms.DataGridView();
            this.DateTimeSupportAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidSupportAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainSupportAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxShowPaymentSuppliers = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabWorkers = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.comboBoxPaymentSalaryWorkerName = new System.Windows.Forms.ComboBox();
            this.textBoxPaymentSalaryDestroyedCost = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBoxPaymentSalary = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDestroyedValue = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAddDestroyedObjectWorkerName = new System.Windows.Forms.ComboBox();
            this.textBoxRemainDestroyed = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.numericUpDownBorrowingAmount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxBorrowWorkersName = new System.Windows.Forms.ComboBox();
            this.textBoxBorrowRemain = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBoxSalaryBorrow = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.numericUpDownRemoveOrEditSalary = new System.Windows.Forms.NumericUpDown();
            this.button13 = new System.Windows.Forms.Button();
            this.comboBoxRemoveOrEditWorker = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.textBoxRemoveOrEditWorkerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.dataGridViewWorkerAccountInformative = new System.Windows.Forms.DataGridView();
            this.DateTimeWorkerAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaonWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryRemain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSalaryTotalInWorkerAccount = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBoxInfoAboutWorkerAccount = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.numericUpDownWorkerSalary = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.textBoxWorkerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxWorkerName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPageReportUpload = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxAddManfcturePrice = new System.Windows.Forms.GroupBox();
            this.button24 = new System.Windows.Forms.Button();
            this.textBoxGlassType = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.numericUpDownGlassTypePrice = new System.Windows.Forms.NumericUpDown();
            this.label63 = new System.Windows.Forms.Label();
            this.groupBoxManfacturePrice = new System.Windows.Forms.GroupBox();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.numericUpDownModifyManfcPrice = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.comboBoxModifyManfcPrice = new System.Windows.Forms.ComboBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.buttonSearchToModifyOpticCode = new System.Windows.Forms.Button();
            this.numericUpDownModifyTheOpticPrice = new System.Windows.Forms.NumericUpDown();
            this.label55 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.textBoxModifyPriceOptic = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBoxModifiyOpticsPriceCode = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.dataGridViewOpticsView = new System.Windows.Forms.DataGridView();
            this.WareHoussGlassType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareHoussGlassCyl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareHoussGlassSph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareHoussGlassTypeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.numericUpDownAddTypeQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAddTypePriceBuy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAddTypePriceSell = new System.Windows.Forms.NumericUpDown();
            this.label61 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.textBoxGlassesSignAddSection = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.textBoxCylAddSection = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.textBoxSphAddSection = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.textBoxGlassTypeCode = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.numericUpDownGlassesType = new System.Windows.Forms.NumericUpDown();
            this.button18 = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.textBoxAddGlassesCodeCount = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.DateTimeBillInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntotalBillCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunTimeBills)).BeginInit();
            this.tabCustomers.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomerPayAmount)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillInfo)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSupplierAddedCost)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSupplierPayAmount)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplierInfoPay)).BeginInit();
            this.tabWorkers.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestroyedValue)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorrowingAmount)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveOrEditSalary)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkerAccountInformative)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkerSalary)).BeginInit();
            this.tabPageReportUpload.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxAddManfcturePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGlassTypePrice)).BeginInit();
            this.groupBoxManfacturePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModifyManfcPrice)).BeginInit();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModifyTheOpticPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpticsView)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddTypeQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddTypePriceBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddTypePriceSell)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGlassesType)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBills);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Controls.Add(this.tabWorkers);
            this.tabControl1.Controls.Add(this.tabPageReportUpload);
            this.tabControl1.Controls.Add(this.tabPage1);
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
            this.tabBills.Controls.Add(this.numericUpDowntotalBillCost);
            this.tabBills.Controls.Add(this.label3);
            this.tabBills.Controls.Add(this.label67);
            this.tabBills.Controls.Add(this.comboBoxGlassesTypeBill);
            this.tabBills.Controls.Add(this.dataGridViewRunTimeBills);
            this.tabBills.Controls.Add(this.buttonAddIteamToBill);
            this.tabBills.Controls.Add(this.label58);
            this.tabBills.Controls.Add(this.textBoxBillOpticCode);
            this.tabBills.Controls.Add(this.button1);
            this.tabBills.Controls.Add(this.comboBoxCustomersNames);
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
            // numericUpDowntotalBillCost
            // 
            this.numericUpDowntotalBillCost.Location = new System.Drawing.Point(1061, 624);
            this.numericUpDowntotalBillCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDowntotalBillCost.Name = "numericUpDowntotalBillCost";
            this.numericUpDowntotalBillCost.ReadOnly = true;
            this.numericUpDowntotalBillCost.Size = new System.Drawing.Size(170, 32);
            this.numericUpDowntotalBillCost.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1237, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "كود المنتج:";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(1206, 98);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(97, 24);
            this.label67.TabIndex = 10;
            this.label67.Text = "نوع الشنبر";
            // 
            // comboBoxGlassesTypeBill
            // 
            this.comboBoxGlassesTypeBill.FormattingEnabled = true;
            this.comboBoxGlassesTypeBill.Location = new System.Drawing.Point(959, 95);
            this.comboBoxGlassesTypeBill.Name = "comboBoxGlassesTypeBill";
            this.comboBoxGlassesTypeBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxGlassesTypeBill.Size = new System.Drawing.Size(241, 32);
            this.comboBoxGlassesTypeBill.TabIndex = 9;
            // 
            // dataGridViewRunTimeBills
            // 
            this.dataGridViewRunTimeBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRunTimeBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRunTimeBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GlassesType,
            this.OpticType,
            this.Sph,
            this.Cyl,
            this.Quantity,
            this.OpticPrice,
            this.Manfc_Price,
            this.TotalPrice,
            this.OpticCode});
            this.dataGridViewRunTimeBills.Location = new System.Drawing.Point(8, 157);
            this.dataGridViewRunTimeBills.Name = "dataGridViewRunTimeBills";
            this.dataGridViewRunTimeBills.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewRunTimeBills.RowHeadersWidth = 51;
            this.dataGridViewRunTimeBills.RowTemplate.Height = 26;
            this.dataGridViewRunTimeBills.Size = new System.Drawing.Size(1343, 426);
            this.dataGridViewRunTimeBills.TabIndex = 8;
            // 
            // GlassesType
            // 
            this.GlassesType.HeaderText = "نوع الشنبر";
            this.GlassesType.MinimumWidth = 6;
            this.GlassesType.Name = "GlassesType";
            this.GlassesType.ReadOnly = true;
            this.GlassesType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GlassesType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OpticType
            // 
            this.OpticType.HeaderText = "نوع العدسة";
            this.OpticType.MinimumWidth = 6;
            this.OpticType.Name = "OpticType";
            this.OpticType.ReadOnly = true;
            // 
            // Sph
            // 
            this.Sph.HeaderText = "Sph";
            this.Sph.MinimumWidth = 6;
            this.Sph.Name = "Sph";
            this.Sph.ReadOnly = true;
            // 
            // Cyl
            // 
            this.Cyl.HeaderText = "Cyl";
            this.Cyl.MinimumWidth = 6;
            this.Cyl.Name = "Cyl";
            this.Cyl.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // OpticPrice
            // 
            this.OpticPrice.HeaderText = "سعر العدسة";
            this.OpticPrice.MinimumWidth = 6;
            this.OpticPrice.Name = "OpticPrice";
            this.OpticPrice.ReadOnly = true;
            // 
            // Manfc_Price
            // 
            this.Manfc_Price.HeaderText = "سعر التركيب";
            this.Manfc_Price.MinimumWidth = 6;
            this.Manfc_Price.Name = "Manfc_Price";
            this.Manfc_Price.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "السعر الأجمالى";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // OpticCode
            // 
            this.OpticCode.HeaderText = "Code";
            this.OpticCode.MinimumWidth = 6;
            this.OpticCode.Name = "OpticCode";
            this.OpticCode.Visible = false;
            // 
            // buttonAddIteamToBill
            // 
            this.buttonAddIteamToBill.ForeColor = System.Drawing.Color.SpringGreen;
            this.buttonAddIteamToBill.Location = new System.Drawing.Point(76, 41);
            this.buttonAddIteamToBill.Name = "buttonAddIteamToBill";
            this.buttonAddIteamToBill.Size = new System.Drawing.Size(173, 47);
            this.buttonAddIteamToBill.TabIndex = 7;
            this.buttonAddIteamToBill.Text = "أضافة";
            this.buttonAddIteamToBill.UseVisualStyleBackColor = true;
            this.buttonAddIteamToBill.Click += new System.EventHandler(this.buttonAddIteamToBill_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(670, 52);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(102, 24);
            this.label58.TabIndex = 6;
            this.label58.Text = "كود المنتج:";
            // 
            // textBoxBillOpticCode
            // 
            this.textBoxBillOpticCode.Location = new System.Drawing.Point(425, 49);
            this.textBoxBillOpticCode.Name = "textBoxBillOpticCode";
            this.textBoxBillOpticCode.Size = new System.Drawing.Size(239, 32);
            this.textBoxBillOpticCode.TabIndex = 5;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCustomersNames
            // 
            this.comboBoxCustomersNames.FormattingEnabled = true;
            this.comboBoxCustomersNames.Location = new System.Drawing.Point(959, 46);
            this.comboBoxCustomersNames.Name = "comboBoxCustomersNames";
            this.comboBoxCustomersNames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxCustomersNames.Size = new System.Drawing.Size(241, 32);
            this.comboBoxCustomersNames.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1206, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "العميل:";
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.groupBox4);
            this.tabCustomers.Controls.Add(this.groupBox3);
            this.tabCustomers.Controls.Add(this.groupBox);
            this.tabCustomers.Controls.Add(this.groupBox1);
            this.tabCustomers.Location = new System.Drawing.Point(4, 33);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(1359, 673);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "العملاء";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.textBoxCompanyName);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBoxCustomerNumber);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBoxCustomerName);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(50, 351);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 282);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "أضافة عميل";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(110, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 44);
            this.button6.TabIndex = 13;
            this.button6.Text = "أضافة";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(22, 167);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(203, 32);
            this.textBoxCompanyName.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "أسم المنشئة:";
            // 
            // textBoxCustomerNumber
            // 
            this.textBoxCustomerNumber.Location = new System.Drawing.Point(22, 109);
            this.textBoxCustomerNumber.Name = "textBoxCustomerNumber";
            this.textBoxCustomerNumber.Size = new System.Drawing.Size(203, 32);
            this.textBoxCustomerNumber.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "رقم التليفون:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(22, 54);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(203, 32);
            this.textBoxCustomerName.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "أسم العميل:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownCustomerPayAmount);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.textBoxCustomerPaymentRemain);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxCustomerPayTotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBoxCustomerPayMoney);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(50, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "دفع حساب";
            // 
            // numericUpDownCustomerPayAmount
            // 
            this.numericUpDownCustomerPayAmount.Location = new System.Drawing.Point(68, 125);
            this.numericUpDownCustomerPayAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCustomerPayAmount.Name = "numericUpDownCustomerPayAmount";
            this.numericUpDownCustomerPayAmount.Size = new System.Drawing.Size(193, 32);
            this.numericUpDownCustomerPayAmount.TabIndex = 16;
            this.numericUpDownCustomerPayAmount.ValueChanged += new System.EventHandler(this.numericUpDownCustomerPayAmount_ValueChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 44);
            this.button5.TabIndex = 12;
            this.button5.Text = "دفع";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxCustomerPaymentRemain
            // 
            this.textBoxCustomerPaymentRemain.Location = new System.Drawing.Point(110, 163);
            this.textBoxCustomerPaymentRemain.Name = "textBoxCustomerPaymentRemain";
            this.textBoxCustomerPaymentRemain.ReadOnly = true;
            this.textBoxCustomerPaymentRemain.Size = new System.Drawing.Size(151, 32);
            this.textBoxCustomerPaymentRemain.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "الباقى:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "المدفوع:";
            // 
            // textBoxCustomerPayTotal
            // 
            this.textBoxCustomerPayTotal.Location = new System.Drawing.Point(110, 87);
            this.textBoxCustomerPayTotal.Name = "textBoxCustomerPayTotal";
            this.textBoxCustomerPayTotal.ReadOnly = true;
            this.textBoxCustomerPayTotal.Size = new System.Drawing.Size(151, 32);
            this.textBoxCustomerPayTotal.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "الأجمالى:";
            // 
            // comboBoxCustomerPayMoney
            // 
            this.comboBoxCustomerPayMoney.FormattingEnabled = true;
            this.comboBoxCustomerPayMoney.Location = new System.Drawing.Point(22, 45);
            this.comboBoxCustomerPayMoney.Name = "comboBoxCustomerPayMoney";
            this.comboBoxCustomerPayMoney.Size = new System.Drawing.Size(263, 32);
            this.comboBoxCustomerPayMoney.TabIndex = 5;
            this.comboBoxCustomerPayMoney.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerPayMoney_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "العميل:";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button4);
            this.groupBox.Controls.Add(this.dataGridViewCustomerAccount);
            this.groupBox.Controls.Add(this.textBoxCustomerAccountInfo);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.comboBoxCustomerMoney);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Location = new System.Drawing.Point(451, 25);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(399, 624);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "أستعلام عن الحساب";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(145, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "طباعة";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomerAccount
            // 
            this.dataGridViewCustomerAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTimeCustomerAccount,
            this.Bill,
            this.Paid,
            this.Remain});
            this.dataGridViewCustomerAccount.Location = new System.Drawing.Point(33, 163);
            this.dataGridViewCustomerAccount.Name = "dataGridViewCustomerAccount";
            this.dataGridViewCustomerAccount.RowHeadersWidth = 51;
            this.dataGridViewCustomerAccount.RowTemplate.Height = 26;
            this.dataGridViewCustomerAccount.Size = new System.Drawing.Size(349, 383);
            this.dataGridViewCustomerAccount.TabIndex = 6;
            // 
            // DateTimeCustomerAccount
            // 
            this.DateTimeCustomerAccount.HeaderText = "التاريخ";
            this.DateTimeCustomerAccount.MinimumWidth = 6;
            this.DateTimeCustomerAccount.Name = "DateTimeCustomerAccount";
            this.DateTimeCustomerAccount.Width = 125;
            // 
            // Bill
            // 
            this.Bill.HeaderText = "الفاتورة";
            this.Bill.MinimumWidth = 6;
            this.Bill.Name = "Bill";
            this.Bill.Width = 125;
            // 
            // Paid
            // 
            this.Paid.HeaderText = "المدفوع";
            this.Paid.MinimumWidth = 6;
            this.Paid.Name = "Paid";
            this.Paid.Width = 125;
            // 
            // Remain
            // 
            this.Remain.HeaderText = "الباقى";
            this.Remain.MinimumWidth = 6;
            this.Remain.Name = "Remain";
            this.Remain.Width = 125;
            // 
            // textBoxCustomerAccountInfo
            // 
            this.textBoxCustomerAccountInfo.Location = new System.Drawing.Point(145, 108);
            this.textBoxCustomerAccountInfo.Name = "textBoxCustomerAccountInfo";
            this.textBoxCustomerAccountInfo.ReadOnly = true;
            this.textBoxCustomerAccountInfo.Size = new System.Drawing.Size(151, 32);
            this.textBoxCustomerAccountInfo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "الأجمالى:";
            // 
            // comboBoxCustomerMoney
            // 
            this.comboBoxCustomerMoney.FormattingEnabled = true;
            this.comboBoxCustomerMoney.Location = new System.Drawing.Point(49, 61);
            this.comboBoxCustomerMoney.Name = "comboBoxCustomerMoney";
            this.comboBoxCustomerMoney.Size = new System.Drawing.Size(263, 32);
            this.comboBoxCustomerMoney.TabIndex = 3;
            this.comboBoxCustomerMoney.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerMoney_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "العميل:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dataGridViewBillInfo);
            this.groupBox1.Controls.Add(this.comboBoxCustomersNamesInfoBills);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(893, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 624);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أستعلام الفواتير";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "طباعة";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBillInfo
            // 
            this.dataGridViewBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBillInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTimeBillInfo,
            this.Total});
            this.dataGridViewBillInfo.Location = new System.Drawing.Point(53, 125);
            this.dataGridViewBillInfo.Name = "dataGridViewBillInfo";
            this.dataGridViewBillInfo.RowHeadersWidth = 45;
            this.dataGridViewBillInfo.RowTemplate.Height = 26;
            this.dataGridViewBillInfo.Size = new System.Drawing.Size(295, 421);
            this.dataGridViewBillInfo.TabIndex = 4;
            // 
            // comboBoxCustomersNamesInfoBills
            // 
            this.comboBoxCustomersNamesInfoBills.FormattingEnabled = true;
            this.comboBoxCustomersNamesInfoBills.Location = new System.Drawing.Point(53, 61);
            this.comboBoxCustomersNamesInfoBills.Name = "comboBoxCustomersNamesInfoBills";
            this.comboBoxCustomersNamesInfoBills.Size = new System.Drawing.Size(295, 32);
            this.comboBoxCustomersNamesInfoBills.TabIndex = 1;
            this.comboBoxCustomersNamesInfoBills.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomersNamesInfoBills_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "العميل:";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.groupBox2);
            this.tabSuppliers.Controls.Add(this.groupBox7);
            this.tabSuppliers.Controls.Add(this.groupBox6);
            this.tabSuppliers.Controls.Add(this.groupBox5);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 33);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(1359, 673);
            this.tabSuppliers.TabIndex = 2;
            this.tabSuppliers.Text = "الموردين";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownSupplierAddedCost);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Controls.Add(this.textBoxTotalSupplierCost);
            this.groupBox2.Controls.Add(this.label59);
            this.groupBox2.Controls.Add(this.label60);
            this.groupBox2.Controls.Add(this.comboBoxSupplierAddCost);
            this.groupBox2.Controls.Add(this.label62);
            this.groupBox2.Location = new System.Drawing.Point(133, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 229);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اضافة مستحق";
            // 
            // numericUpDownSupplierAddedCost
            // 
            this.numericUpDownSupplierAddedCost.Location = new System.Drawing.Point(76, 80);
            this.numericUpDownSupplierAddedCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSupplierAddedCost.Name = "numericUpDownSupplierAddedCost";
            this.numericUpDownSupplierAddedCost.Size = new System.Drawing.Size(203, 32);
            this.numericUpDownSupplierAddedCost.TabIndex = 16;
            this.numericUpDownSupplierAddedCost.ValueChanged += new System.EventHandler(this.numericUpDownSupplierAddedCost_ValueChanged);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(152, 166);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(101, 44);
            this.button23.TabIndex = 12;
            this.button23.Text = "أضافة";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // textBoxTotalSupplierCost
            // 
            this.textBoxTotalSupplierCost.Location = new System.Drawing.Point(128, 118);
            this.textBoxTotalSupplierCost.Name = "textBoxTotalSupplierCost";
            this.textBoxTotalSupplierCost.ReadOnly = true;
            this.textBoxTotalSupplierCost.Size = new System.Drawing.Size(151, 32);
            this.textBoxTotalSupplierCost.TabIndex = 11;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(285, 118);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(91, 24);
            this.label59.TabIndex = 10;
            this.label59.Text = "الأجمالى:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(285, 80);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(71, 24);
            this.label60.TabIndex = 8;
            this.label60.Text = "المضاف";
            // 
            // comboBoxSupplierAddCost
            // 
            this.comboBoxSupplierAddCost.FormattingEnabled = true;
            this.comboBoxSupplierAddCost.Location = new System.Drawing.Point(16, 42);
            this.comboBoxSupplierAddCost.Name = "comboBoxSupplierAddCost";
            this.comboBoxSupplierAddCost.Size = new System.Drawing.Size(263, 32);
            this.comboBoxSupplierAddCost.TabIndex = 5;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(291, 45);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(65, 24);
            this.label62.TabIndex = 4;
            this.label62.Text = "المورد:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numericUpDownSupplierPayAmount);
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Controls.Add(this.textBoxRemainSupplierPayment);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.textBox12);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.textBoxSupplierPayTotal);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.comboBoxPayToSuppliers);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Location = new System.Drawing.Point(530, 284);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(391, 284);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "دفع حساب";
            // 
            // numericUpDownSupplierPayAmount
            // 
            this.numericUpDownSupplierPayAmount.Location = new System.Drawing.Point(76, 124);
            this.numericUpDownSupplierPayAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSupplierPayAmount.Name = "numericUpDownSupplierPayAmount";
            this.numericUpDownSupplierPayAmount.Size = new System.Drawing.Size(203, 32);
            this.numericUpDownSupplierPayAmount.TabIndex = 16;
            this.numericUpDownSupplierPayAmount.ValueChanged += new System.EventHandler(this.numericUpDownSupplierPayAmount_ValueChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(140, 217);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 44);
            this.button9.TabIndex = 12;
            this.button9.Text = "دفع";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBoxRemainSupplierPayment
            // 
            this.textBoxRemainSupplierPayment.Location = new System.Drawing.Point(125, 161);
            this.textBoxRemainSupplierPayment.Name = "textBoxRemainSupplierPayment";
            this.textBoxRemainSupplierPayment.ReadOnly = true;
            this.textBoxRemainSupplierPayment.Size = new System.Drawing.Size(151, 32);
            this.textBoxRemainSupplierPayment.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(282, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 24);
            this.label17.TabIndex = 10;
            this.label17.Text = "الباقى:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(125, 123);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(151, 32);
            this.textBox12.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(282, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 24);
            this.label20.TabIndex = 8;
            this.label20.Text = "المدفوع:";
            // 
            // textBoxSupplierPayTotal
            // 
            this.textBoxSupplierPayTotal.Location = new System.Drawing.Point(125, 85);
            this.textBoxSupplierPayTotal.Name = "textBoxSupplierPayTotal";
            this.textBoxSupplierPayTotal.ReadOnly = true;
            this.textBoxSupplierPayTotal.Size = new System.Drawing.Size(151, 32);
            this.textBoxSupplierPayTotal.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(282, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 24);
            this.label21.TabIndex = 6;
            this.label21.Text = "الأجمالى:";
            // 
            // comboBoxPayToSuppliers
            // 
            this.comboBoxPayToSuppliers.FormattingEnabled = true;
            this.comboBoxPayToSuppliers.Location = new System.Drawing.Point(16, 42);
            this.comboBoxPayToSuppliers.Name = "comboBoxPayToSuppliers";
            this.comboBoxPayToSuppliers.Size = new System.Drawing.Size(263, 32);
            this.comboBoxPayToSuppliers.TabIndex = 5;
            this.comboBoxPayToSuppliers.SelectedIndexChanged += new System.EventHandler(this.comboBoxPayToSuppliers_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(291, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 24);
            this.label22.TabIndex = 4;
            this.label22.Text = "العميل:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Controls.Add(this.textBoxSupplierPhoneNumber);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBoxSupplierName);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(530, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(391, 241);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "أضافة مورد";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(131, 179);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 44);
            this.button8.TabIndex = 13;
            this.button8.Text = "أضافة";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBoxSupplierPhoneNumber
            // 
            this.textBoxSupplierPhoneNumber.Location = new System.Drawing.Point(38, 108);
            this.textBoxSupplierPhoneNumber.Name = "textBoxSupplierPhoneNumber";
            this.textBoxSupplierPhoneNumber.Size = new System.Drawing.Size(203, 32);
            this.textBoxSupplierPhoneNumber.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(247, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 24);
            this.label18.TabIndex = 9;
            this.label18.Text = "رقم التليفون:";
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(38, 53);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(203, 32);
            this.textBoxSupplierName.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(247, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 24);
            this.label19.TabIndex = 5;
            this.label19.Text = "أسم المورد:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.dataGridViewSupplierInfoPay);
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.comboBoxShowPaymentSuppliers);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(939, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(399, 624);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "أستعلام عن الحساب";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(145, 564);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 44);
            this.button7.TabIndex = 9;
            this.button7.Text = "طباعة";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSupplierInfoPay
            // 
            this.dataGridViewSupplierInfoPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplierInfoPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTimeSupportAccount,
            this.PaidSupportAccount,
            this.RemainSupportAccount});
            this.dataGridViewSupplierInfoPay.Location = new System.Drawing.Point(33, 166);
            this.dataGridViewSupplierInfoPay.Name = "dataGridViewSupplierInfoPay";
            this.dataGridViewSupplierInfoPay.RowHeadersWidth = 51;
            this.dataGridViewSupplierInfoPay.RowTemplate.Height = 26;
            this.dataGridViewSupplierInfoPay.Size = new System.Drawing.Size(320, 380);
            this.dataGridViewSupplierInfoPay.TabIndex = 6;
            // 
            // DateTimeSupportAccount
            // 
            this.DateTimeSupportAccount.HeaderText = "التاريخ";
            this.DateTimeSupportAccount.MinimumWidth = 6;
            this.DateTimeSupportAccount.Name = "DateTimeSupportAccount";
            this.DateTimeSupportAccount.Width = 125;
            // 
            // PaidSupportAccount
            // 
            this.PaidSupportAccount.HeaderText = "المدفوع";
            this.PaidSupportAccount.MinimumWidth = 6;
            this.PaidSupportAccount.Name = "PaidSupportAccount";
            this.PaidSupportAccount.Width = 125;
            // 
            // RemainSupportAccount
            // 
            this.RemainSupportAccount.HeaderText = "الباقى";
            this.RemainSupportAccount.MinimumWidth = 6;
            this.RemainSupportAccount.Name = "RemainSupportAccount";
            this.RemainSupportAccount.Width = 125;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(145, 108);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(151, 32);
            this.textBox8.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 24);
            this.label15.TabIndex = 4;
            this.label15.Text = "الأجمالى:";
            // 
            // comboBoxShowPaymentSuppliers
            // 
            this.comboBoxShowPaymentSuppliers.FormattingEnabled = true;
            this.comboBoxShowPaymentSuppliers.Location = new System.Drawing.Point(49, 61);
            this.comboBoxShowPaymentSuppliers.Name = "comboBoxShowPaymentSuppliers";
            this.comboBoxShowPaymentSuppliers.Size = new System.Drawing.Size(263, 32);
            this.comboBoxShowPaymentSuppliers.TabIndex = 3;
            this.comboBoxShowPaymentSuppliers.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowPaymentSuppliers_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(318, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 24);
            this.label16.TabIndex = 2;
            this.label16.Text = "المورد:";
            // 
            // tabWorkers
            // 
            this.tabWorkers.Controls.Add(this.groupBox13);
            this.tabWorkers.Controls.Add(this.groupBox12);
            this.tabWorkers.Controls.Add(this.groupBox11);
            this.tabWorkers.Controls.Add(this.groupBox10);
            this.tabWorkers.Controls.Add(this.groupBox9);
            this.tabWorkers.Controls.Add(this.groupBox8);
            this.tabWorkers.Location = new System.Drawing.Point(4, 33);
            this.tabWorkers.Name = "tabWorkers";
            this.tabWorkers.Size = new System.Drawing.Size(1359, 673);
            this.tabWorkers.TabIndex = 3;
            this.tabWorkers.Text = "العاملين";
            this.tabWorkers.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.comboBoxPaymentSalaryWorkerName);
            this.groupBox13.Controls.Add(this.textBoxPaymentSalaryDestroyedCost);
            this.groupBox13.Controls.Add(this.label35);
            this.groupBox13.Controls.Add(this.textBoxPaymentSalary);
            this.groupBox13.Controls.Add(this.label38);
            this.groupBox13.Controls.Add(this.button16);
            this.groupBox13.Controls.Add(this.label39);
            this.groupBox13.Location = new System.Drawing.Point(8, 436);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(399, 266);
            this.groupBox13.TabIndex = 22;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "قبض";
            // 
            // comboBoxPaymentSalaryWorkerName
            // 
            this.comboBoxPaymentSalaryWorkerName.FormattingEnabled = true;
            this.comboBoxPaymentSalaryWorkerName.Location = new System.Drawing.Point(10, 58);
            this.comboBoxPaymentSalaryWorkerName.Name = "comboBoxPaymentSalaryWorkerName";
            this.comboBoxPaymentSalaryWorkerName.Size = new System.Drawing.Size(231, 32);
            this.comboBoxPaymentSalaryWorkerName.TabIndex = 20;
            this.comboBoxPaymentSalaryWorkerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentSalaryWorkerName_SelectedIndexChanged);
            // 
            // textBoxPaymentSalaryDestroyedCost
            // 
            this.textBoxPaymentSalaryDestroyedCost.Location = new System.Drawing.Point(90, 142);
            this.textBoxPaymentSalaryDestroyedCost.Name = "textBoxPaymentSalaryDestroyedCost";
            this.textBoxPaymentSalaryDestroyedCost.ReadOnly = true;
            this.textBoxPaymentSalaryDestroyedCost.Size = new System.Drawing.Size(151, 32);
            this.textBoxPaymentSalaryDestroyedCost.TabIndex = 19;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(247, 142);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(119, 24);
            this.label35.TabIndex = 18;
            this.label35.Text = "قيمة الهوالك:";
            // 
            // textBoxPaymentSalary
            // 
            this.textBoxPaymentSalary.Location = new System.Drawing.Point(38, 100);
            this.textBoxPaymentSalary.Name = "textBoxPaymentSalary";
            this.textBoxPaymentSalary.ReadOnly = true;
            this.textBoxPaymentSalary.Size = new System.Drawing.Size(203, 32);
            this.textBoxPaymentSalary.TabIndex = 15;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(247, 108);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 24);
            this.label38.TabIndex = 14;
            this.label38.Text = "المرتب:";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(114, 187);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(101, 44);
            this.button16.TabIndex = 13;
            this.button16.Text = "تقبيض";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(247, 61);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(113, 24);
            this.label39.TabIndex = 5;
            this.label39.Text = "أسم العامل:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.numericUpDownDestroyedValue);
            this.groupBox12.Controls.Add(this.comboBoxAddDestroyedObjectWorkerName);
            this.groupBox12.Controls.Add(this.textBoxRemainDestroyed);
            this.groupBox12.Controls.Add(this.label34);
            this.groupBox12.Controls.Add(this.label36);
            this.groupBox12.Controls.Add(this.button15);
            this.groupBox12.Controls.Add(this.label37);
            this.groupBox12.Location = new System.Drawing.Point(479, 344);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(391, 266);
            this.groupBox12.TabIndex = 21;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "أضافة هالك";
            // 
            // numericUpDownDestroyedValue
            // 
            this.numericUpDownDestroyedValue.Location = new System.Drawing.Point(38, 106);
            this.numericUpDownDestroyedValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDestroyedValue.Name = "numericUpDownDestroyedValue";
            this.numericUpDownDestroyedValue.Size = new System.Drawing.Size(203, 32);
            this.numericUpDownDestroyedValue.TabIndex = 22;
            this.numericUpDownDestroyedValue.ValueChanged += new System.EventHandler(this.numericUpDownDestroyedValue_ValueChanged);
            // 
            // comboBoxAddDestroyedObjectWorkerName
            // 
            this.comboBoxAddDestroyedObjectWorkerName.FormattingEnabled = true;
            this.comboBoxAddDestroyedObjectWorkerName.Location = new System.Drawing.Point(10, 58);
            this.comboBoxAddDestroyedObjectWorkerName.Name = "comboBoxAddDestroyedObjectWorkerName";
            this.comboBoxAddDestroyedObjectWorkerName.Size = new System.Drawing.Size(231, 32);
            this.comboBoxAddDestroyedObjectWorkerName.TabIndex = 20;
            this.comboBoxAddDestroyedObjectWorkerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddDestroyedObjectWorkerName_SelectedIndexChanged);
            // 
            // textBoxRemainDestroyed
            // 
            this.textBoxRemainDestroyed.Location = new System.Drawing.Point(90, 149);
            this.textBoxRemainDestroyed.Name = "textBoxRemainDestroyed";
            this.textBoxRemainDestroyed.ReadOnly = true;
            this.textBoxRemainDestroyed.Size = new System.Drawing.Size(151, 32);
            this.textBoxRemainDestroyed.TabIndex = 19;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(247, 149);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(69, 24);
            this.label34.TabIndex = 18;
            this.label34.Text = "الباقى:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(247, 108);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(111, 24);
            this.label36.TabIndex = 14;
            this.label36.Text = "قيمة الهالك:";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(140, 200);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(101, 44);
            this.button15.TabIndex = 13;
            this.button15.Text = "أضافة";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(247, 61);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(113, 24);
            this.label37.TabIndex = 5;
            this.label37.Text = "أسم العامل:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.numericUpDownBorrowingAmount);
            this.groupBox11.Controls.Add(this.comboBoxBorrowWorkersName);
            this.groupBox11.Controls.Add(this.textBoxBorrowRemain);
            this.groupBox11.Controls.Add(this.label33);
            this.groupBox11.Controls.Add(this.label31);
            this.groupBox11.Controls.Add(this.textBoxSalaryBorrow);
            this.groupBox11.Controls.Add(this.label30);
            this.groupBox11.Controls.Add(this.button14);
            this.groupBox11.Controls.Add(this.label32);
            this.groupBox11.Location = new System.Drawing.Point(479, 22);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(391, 316);
            this.groupBox11.TabIndex = 16;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "أستلاف";
            // 
            // numericUpDownBorrowingAmount
            // 
            this.numericUpDownBorrowingAmount.Location = new System.Drawing.Point(38, 150);
            this.numericUpDownBorrowingAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownBorrowingAmount.Name = "numericUpDownBorrowingAmount";
            this.numericUpDownBorrowingAmount.Size = new System.Drawing.Size(203, 32);
            this.numericUpDownBorrowingAmount.TabIndex = 21;
            this.numericUpDownBorrowingAmount.ValueChanged += new System.EventHandler(this.numericUpDownBorrowingAmount_ValueChanged);
            // 
            // comboBoxBorrowWorkersName
            // 
            this.comboBoxBorrowWorkersName.FormattingEnabled = true;
            this.comboBoxBorrowWorkersName.Location = new System.Drawing.Point(10, 58);
            this.comboBoxBorrowWorkersName.Name = "comboBoxBorrowWorkersName";
            this.comboBoxBorrowWorkersName.Size = new System.Drawing.Size(231, 32);
            this.comboBoxBorrowWorkersName.TabIndex = 20;
            this.comboBoxBorrowWorkersName.SelectedIndexChanged += new System.EventHandler(this.comboBoxBorrowWorkersName_SelectedIndexChanged);
            // 
            // textBoxBorrowRemain
            // 
            this.textBoxBorrowRemain.Location = new System.Drawing.Point(90, 189);
            this.textBoxBorrowRemain.Name = "textBoxBorrowRemain";
            this.textBoxBorrowRemain.ReadOnly = true;
            this.textBoxBorrowRemain.Size = new System.Drawing.Size(151, 32);
            this.textBoxBorrowRemain.TabIndex = 19;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(247, 189);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(69, 24);
            this.label33.TabIndex = 18;
            this.label33.Text = "الباقى:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(247, 152);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(136, 24);
            this.label31.TabIndex = 16;
            this.label31.Text = "قيمة الأستلاف:";
            // 
            // textBoxSalaryBorrow
            // 
            this.textBoxSalaryBorrow.Location = new System.Drawing.Point(38, 100);
            this.textBoxSalaryBorrow.Name = "textBoxSalaryBorrow";
            this.textBoxSalaryBorrow.ReadOnly = true;
            this.textBoxSalaryBorrow.Size = new System.Drawing.Size(203, 32);
            this.textBoxSalaryBorrow.TabIndex = 15;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(247, 108);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 24);
            this.label30.TabIndex = 14;
            this.label30.Text = "المرتب:";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(140, 247);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(101, 44);
            this.button14.TabIndex = 13;
            this.button14.Text = "أستلاف";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(247, 61);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(113, 24);
            this.label32.TabIndex = 5;
            this.label32.Text = "أسم العامل:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.numericUpDownRemoveOrEditSalary);
            this.groupBox10.Controls.Add(this.button13);
            this.groupBox10.Controls.Add(this.comboBoxRemoveOrEditWorker);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Controls.Add(this.button12);
            this.groupBox10.Controls.Add(this.textBoxRemoveOrEditWorkerPhoneNumber);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Location = new System.Drawing.Point(950, 320);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(391, 291);
            this.groupBox10.TabIndex = 16;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "حذف وتعديل";
            // 
            // numericUpDownRemoveOrEditSalary
            // 
            this.numericUpDownRemoveOrEditSalary.Location = new System.Drawing.Point(38, 165);
            this.numericUpDownRemoveOrEditSalary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRemoveOrEditSalary.Name = "numericUpDownRemoveOrEditSalary";
            this.numericUpDownRemoveOrEditSalary.Size = new System.Drawing.Size(203, 32);
            this.numericUpDownRemoveOrEditSalary.TabIndex = 16;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(77, 225);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(101, 44);
            this.button13.TabIndex = 17;
            this.button13.Text = "حذف";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_ClickAsync);
            // 
            // comboBoxRemoveOrEditWorker
            // 
            this.comboBoxRemoveOrEditWorker.FormattingEnabled = true;
            this.comboBoxRemoveOrEditWorker.Location = new System.Drawing.Point(10, 58);
            this.comboBoxRemoveOrEditWorker.Name = "comboBoxRemoveOrEditWorker";
            this.comboBoxRemoveOrEditWorker.Size = new System.Drawing.Size(231, 32);
            this.comboBoxRemoveOrEditWorker.TabIndex = 16;
            this.comboBoxRemoveOrEditWorker.SelectedIndexChanged += new System.EventHandler(this.comboBoxRemoveOrEditWorker_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(247, 174);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 24);
            this.label27.TabIndex = 14;
            this.label27.Text = "المرتب:";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(230, 225);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(101, 44);
            this.button12.TabIndex = 13;
            this.button12.Text = "تعديل";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBoxRemoveOrEditWorkerPhoneNumber
            // 
            this.textBoxRemoveOrEditWorkerPhoneNumber.Location = new System.Drawing.Point(38, 108);
            this.textBoxRemoveOrEditWorkerPhoneNumber.Name = "textBoxRemoveOrEditWorkerPhoneNumber";
            this.textBoxRemoveOrEditWorkerPhoneNumber.Size = new System.Drawing.Size(203, 32);
            this.textBoxRemoveOrEditWorkerPhoneNumber.TabIndex = 10;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(247, 116);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(116, 24);
            this.label28.TabIndex = 9;
            this.label28.Text = "رقم التليفون:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(247, 61);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(113, 24);
            this.label29.TabIndex = 5;
            this.label29.Text = "أسم العامل:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button11);
            this.groupBox9.Controls.Add(this.dataGridViewWorkerAccountInformative);
            this.groupBox9.Controls.Add(this.textBoxSalaryTotalInWorkerAccount);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.comboBoxInfoAboutWorkerAccount);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Location = new System.Drawing.Point(8, 23);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(399, 407);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "أستعلام عن الحساب";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(145, 355);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 44);
            this.button11.TabIndex = 9;
            this.button11.Text = "طباعة";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWorkerAccountInformative
            // 
            this.dataGridViewWorkerAccountInformative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkerAccountInformative.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTimeWorkerAccount,
            this.LeaonWorker,
            this.SalaryRemain});
            this.dataGridViewWorkerAccountInformative.Location = new System.Drawing.Point(33, 166);
            this.dataGridViewWorkerAccountInformative.Name = "dataGridViewWorkerAccountInformative";
            this.dataGridViewWorkerAccountInformative.ReadOnly = true;
            this.dataGridViewWorkerAccountInformative.RowHeadersWidth = 51;
            this.dataGridViewWorkerAccountInformative.RowTemplate.Height = 26;
            this.dataGridViewWorkerAccountInformative.Size = new System.Drawing.Size(346, 168);
            this.dataGridViewWorkerAccountInformative.TabIndex = 6;
            // 
            // DateTimeWorkerAccount
            // 
            this.DateTimeWorkerAccount.HeaderText = "التاريخ";
            this.DateTimeWorkerAccount.MinimumWidth = 6;
            this.DateTimeWorkerAccount.Name = "DateTimeWorkerAccount";
            this.DateTimeWorkerAccount.ReadOnly = true;
            this.DateTimeWorkerAccount.Width = 125;
            // 
            // LeaonWorker
            // 
            this.LeaonWorker.HeaderText = "الأستلاف";
            this.LeaonWorker.MinimumWidth = 6;
            this.LeaonWorker.Name = "LeaonWorker";
            this.LeaonWorker.ReadOnly = true;
            this.LeaonWorker.Width = 125;
            // 
            // SalaryRemain
            // 
            this.SalaryRemain.HeaderText = "الباقى";
            this.SalaryRemain.MinimumWidth = 6;
            this.SalaryRemain.Name = "SalaryRemain";
            this.SalaryRemain.ReadOnly = true;
            this.SalaryRemain.Width = 125;
            // 
            // textBoxSalaryTotalInWorkerAccount
            // 
            this.textBoxSalaryTotalInWorkerAccount.Location = new System.Drawing.Point(145, 108);
            this.textBoxSalaryTotalInWorkerAccount.Name = "textBoxSalaryTotalInWorkerAccount";
            this.textBoxSalaryTotalInWorkerAccount.ReadOnly = true;
            this.textBoxSalaryTotalInWorkerAccount.Size = new System.Drawing.Size(151, 32);
            this.textBoxSalaryTotalInWorkerAccount.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(302, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 24);
            this.label24.TabIndex = 4;
            this.label24.Text = "الأجمالى:";
            // 
            // comboBoxInfoAboutWorkerAccount
            // 
            this.comboBoxInfoAboutWorkerAccount.FormattingEnabled = true;
            this.comboBoxInfoAboutWorkerAccount.Location = new System.Drawing.Point(49, 61);
            this.comboBoxInfoAboutWorkerAccount.Name = "comboBoxInfoAboutWorkerAccount";
            this.comboBoxInfoAboutWorkerAccount.Size = new System.Drawing.Size(263, 32);
            this.comboBoxInfoAboutWorkerAccount.TabIndex = 3;
            this.comboBoxInfoAboutWorkerAccount.SelectedIndexChanged += new System.EventHandler(this.comboBoxInfoAboutWorkerAccount_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(318, 61);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 24);
            this.label25.TabIndex = 2;
            this.label25.Text = "العامل:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.numericUpDownWorkerSalary);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.button10);
            this.groupBox8.Controls.Add(this.textBoxWorkerPhoneNumber);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.textBoxWorkerName);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Location = new System.Drawing.Point(950, 23);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(391, 270);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "أضافة عامل";
            // 
            // numericUpDownWorkerSalary
            // 
            this.numericUpDownWorkerSalary.Location = new System.Drawing.Point(38, 151);
            this.numericUpDownWorkerSalary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWorkerSalary.Name = "numericUpDownWorkerSalary";
            this.numericUpDownWorkerSalary.Size = new System.Drawing.Size(203, 32);
            this.numericUpDownWorkerSalary.TabIndex = 15;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(247, 151);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 24);
            this.label26.TabIndex = 14;
            this.label26.Text = "المرتب:";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(140, 200);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(101, 44);
            this.button10.TabIndex = 13;
            this.button10.Text = "أضافة";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBoxWorkerPhoneNumber
            // 
            this.textBoxWorkerPhoneNumber.Location = new System.Drawing.Point(38, 99);
            this.textBoxWorkerPhoneNumber.Name = "textBoxWorkerPhoneNumber";
            this.textBoxWorkerPhoneNumber.Size = new System.Drawing.Size(203, 32);
            this.textBoxWorkerPhoneNumber.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 24);
            this.label14.TabIndex = 9;
            this.label14.Text = "رقم التليفون:";
            // 
            // textBoxWorkerName
            // 
            this.textBoxWorkerName.Location = new System.Drawing.Point(38, 53);
            this.textBoxWorkerName.Name = "textBoxWorkerName";
            this.textBoxWorkerName.Size = new System.Drawing.Size(203, 32);
            this.textBoxWorkerName.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(247, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 24);
            this.label23.TabIndex = 5;
            this.label23.Text = "أسم العامل:";
            // 
            // tabPageReportUpload
            // 
            this.tabPageReportUpload.Controls.Add(this.button17);
            this.tabPageReportUpload.Location = new System.Drawing.Point(4, 33);
            this.tabPageReportUpload.Name = "tabPageReportUpload";
            this.tabPageReportUpload.Size = new System.Drawing.Size(1359, 673);
            this.tabPageReportUpload.TabIndex = 5;
            this.tabPageReportUpload.Text = "رفع تقرير اليوم";
            this.tabPageReportUpload.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(579, 257);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(227, 89);
            this.button17.TabIndex = 0;
            this.button17.Text = "رفع تقراير اليوم";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxAddManfcturePrice);
            this.tabPage1.Controls.Add(this.groupBoxManfacturePrice);
            this.tabPage1.Controls.Add(this.groupBox19);
            this.tabPage1.Controls.Add(this.groupBox18);
            this.tabPage1.Controls.Add(this.dataGridViewOpticsView);
            this.tabPage1.Controls.Add(this.groupBox17);
            this.tabPage1.Controls.Add(this.groupBox16);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1359, 673);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "المخزن";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddManfcturePrice
            // 
            this.groupBoxAddManfcturePrice.Controls.Add(this.button24);
            this.groupBoxAddManfcturePrice.Controls.Add(this.textBoxGlassType);
            this.groupBoxAddManfcturePrice.Controls.Add(this.label64);
            this.groupBoxAddManfcturePrice.Controls.Add(this.numericUpDownGlassTypePrice);
            this.groupBoxAddManfcturePrice.Controls.Add(this.label63);
            this.groupBoxAddManfcturePrice.Location = new System.Drawing.Point(8, 276);
            this.groupBoxAddManfcturePrice.Name = "groupBoxAddManfcturePrice";
            this.groupBoxAddManfcturePrice.Size = new System.Drawing.Size(256, 190);
            this.groupBoxAddManfcturePrice.TabIndex = 9;
            this.groupBoxAddManfcturePrice.TabStop = false;
            this.groupBoxAddManfcturePrice.Text = "أضافة أسعار التركيب";
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(6, 142);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(103, 42);
            this.button24.TabIndex = 21;
            this.button24.Text = "أضافة";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // textBoxGlassType
            // 
            this.textBoxGlassType.Location = new System.Drawing.Point(6, 45);
            this.textBoxGlassType.Name = "textBoxGlassType";
            this.textBoxGlassType.Size = new System.Drawing.Size(171, 32);
            this.textBoxGlassType.TabIndex = 20;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(183, 48);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(56, 24);
            this.label64.TabIndex = 19;
            this.label64.Text = "النوع:";
            // 
            // numericUpDownGlassTypePrice
            // 
            this.numericUpDownGlassTypePrice.Location = new System.Drawing.Point(6, 91);
            this.numericUpDownGlassTypePrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGlassTypePrice.Name = "numericUpDownGlassTypePrice";
            this.numericUpDownGlassTypePrice.Size = new System.Drawing.Size(171, 32);
            this.numericUpDownGlassTypePrice.TabIndex = 18;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(183, 99);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(67, 24);
            this.label63.TabIndex = 4;
            this.label63.Text = "السعر:";
            // 
            // groupBoxManfacturePrice
            // 
            this.groupBoxManfacturePrice.Controls.Add(this.button26);
            this.groupBoxManfacturePrice.Controls.Add(this.button25);
            this.groupBoxManfacturePrice.Controls.Add(this.numericUpDownModifyManfcPrice);
            this.groupBoxManfacturePrice.Controls.Add(this.label66);
            this.groupBoxManfacturePrice.Controls.Add(this.label65);
            this.groupBoxManfacturePrice.Controls.Add(this.comboBoxModifyManfcPrice);
            this.groupBoxManfacturePrice.Location = new System.Drawing.Point(8, 476);
            this.groupBoxManfacturePrice.Name = "groupBoxManfacturePrice";
            this.groupBoxManfacturePrice.Size = new System.Drawing.Size(256, 194);
            this.groupBoxManfacturePrice.TabIndex = 8;
            this.groupBoxManfacturePrice.TabStop = false;
            this.groupBoxManfacturePrice.Text = "تعديل أسعار التركيب";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(127, 152);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(94, 36);
            this.button26.TabIndex = 24;
            this.button26.Text = "حذف";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(15, 152);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(94, 36);
            this.button25.TabIndex = 23;
            this.button25.Text = "تعديل";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // numericUpDownModifyManfcPrice
            // 
            this.numericUpDownModifyManfcPrice.Location = new System.Drawing.Point(6, 106);
            this.numericUpDownModifyManfcPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownModifyManfcPrice.Name = "numericUpDownModifyManfcPrice";
            this.numericUpDownModifyManfcPrice.Size = new System.Drawing.Size(171, 32);
            this.numericUpDownModifyManfcPrice.TabIndex = 22;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(183, 114);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(67, 24);
            this.label66.TabIndex = 21;
            this.label66.Text = "السعر:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(204, 54);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(56, 24);
            this.label65.TabIndex = 20;
            this.label65.Text = "النوع:";
            // 
            // comboBoxModifyManfcPrice
            // 
            this.comboBoxModifyManfcPrice.FormattingEnabled = true;
            this.comboBoxModifyManfcPrice.Location = new System.Drawing.Point(0, 51);
            this.comboBoxModifyManfcPrice.Name = "comboBoxModifyManfcPrice";
            this.comboBoxModifyManfcPrice.Size = new System.Drawing.Size(198, 32);
            this.comboBoxModifyManfcPrice.TabIndex = 2;
            this.comboBoxModifyManfcPrice.SelectedIndexChanged += new System.EventHandler(this.comboBoxModifyManfcPrice_SelectedIndexChanged);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.textBox41);
            this.groupBox19.Controls.Add(this.label56);
            this.groupBox19.Controls.Add(this.button21);
            this.groupBox19.Controls.Add(this.textBox42);
            this.groupBox19.Controls.Add(this.label57);
            this.groupBox19.Location = new System.Drawing.Point(270, 476);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(537, 194);
            this.groupBox19.TabIndex = 7;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "تعديل اسعار";
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(14, 51);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(107, 32);
            this.textBox41.TabIndex = 6;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(127, 59);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(145, 24);
            this.label56.TabIndex = 5;
            this.label56.Text = "السعر الأضافى :";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(216, 141);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(103, 42);
            this.button21.TabIndex = 4;
            this.button21.Text = "تعديل";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(280, 51);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(107, 32);
            this.textBox42.TabIndex = 3;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(393, 59);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(138, 24);
            this.label57.TabIndex = 2;
            this.label57.Text = "القيمة الأضافية:";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.buttonSearchToModifyOpticCode);
            this.groupBox18.Controls.Add(this.numericUpDownModifyTheOpticPrice);
            this.groupBox18.Controls.Add(this.label55);
            this.groupBox18.Controls.Add(this.button20);
            this.groupBox18.Controls.Add(this.textBoxModifyPriceOptic);
            this.groupBox18.Controls.Add(this.label53);
            this.groupBox18.Controls.Add(this.textBoxModifiyOpticsPriceCode);
            this.groupBox18.Controls.Add(this.label54);
            this.groupBox18.Location = new System.Drawing.Point(270, 265);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(537, 201);
            this.groupBox18.TabIndex = 3;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "تعديل اسعار";
            // 
            // buttonSearchToModifyOpticCode
            // 
            this.buttonSearchToModifyOpticCode.Location = new System.Drawing.Point(38, 25);
            this.buttonSearchToModifyOpticCode.Name = "buttonSearchToModifyOpticCode";
            this.buttonSearchToModifyOpticCode.Size = new System.Drawing.Size(103, 42);
            this.buttonSearchToModifyOpticCode.TabIndex = 19;
            this.buttonSearchToModifyOpticCode.Text = "بحث";
            this.buttonSearchToModifyOpticCode.UseVisualStyleBackColor = true;
            this.buttonSearchToModifyOpticCode.Click += new System.EventHandler(this.buttonSearchToModifyOpticCode_Click);
            // 
            // numericUpDownModifyTheOpticPrice
            // 
            this.numericUpDownModifyTheOpticPrice.Location = new System.Drawing.Point(38, 89);
            this.numericUpDownModifyTheOpticPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownModifyTheOpticPrice.Name = "numericUpDownModifyTheOpticPrice";
            this.numericUpDownModifyTheOpticPrice.Size = new System.Drawing.Size(134, 32);
            this.numericUpDownModifyTheOpticPrice.TabIndex = 18;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(178, 91);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(145, 24);
            this.label55.TabIndex = 5;
            this.label55.Text = "السعر الأضافى :";
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(216, 141);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(103, 42);
            this.button20.TabIndex = 4;
            this.button20.Text = "تعديل";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // textBoxModifyPriceOptic
            // 
            this.textBoxModifyPriceOptic.Location = new System.Drawing.Point(349, 83);
            this.textBoxModifyPriceOptic.Name = "textBoxModifyPriceOptic";
            this.textBoxModifyPriceOptic.ReadOnly = true;
            this.textBoxModifyPriceOptic.Size = new System.Drawing.Size(107, 32);
            this.textBoxModifyPriceOptic.TabIndex = 3;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(462, 91);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(67, 24);
            this.label53.TabIndex = 2;
            this.label53.Text = "السعر:";
            // 
            // textBoxModifiyOpticsPriceCode
            // 
            this.textBoxModifiyOpticsPriceCode.Location = new System.Drawing.Point(162, 31);
            this.textBoxModifiyOpticsPriceCode.Name = "textBoxModifiyOpticsPriceCode";
            this.textBoxModifiyOpticsPriceCode.Size = new System.Drawing.Size(294, 32);
            this.textBoxModifiyOpticsPriceCode.TabIndex = 1;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(462, 34);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(57, 24);
            this.label54.TabIndex = 0;
            this.label54.Text = "الكود:";
            // 
            // dataGridViewOpticsView
            // 
            this.dataGridViewOpticsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpticsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WareHoussGlassType,
            this.WareHoussGlassCyl,
            this.WareHoussGlassSph,
            this.WareHoussGlassTypeQuantity});
            this.dataGridViewOpticsView.Location = new System.Drawing.Point(813, 276);
            this.dataGridViewOpticsView.Name = "dataGridViewOpticsView";
            this.dataGridViewOpticsView.ReadOnly = true;
            this.dataGridViewOpticsView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewOpticsView.RowHeadersWidth = 51;
            this.dataGridViewOpticsView.RowTemplate.Height = 26;
            this.dataGridViewOpticsView.Size = new System.Drawing.Size(538, 389);
            this.dataGridViewOpticsView.TabIndex = 2;
            // 
            // WareHoussGlassType
            // 
            this.WareHoussGlassType.HeaderText = "توع العدسة";
            this.WareHoussGlassType.MinimumWidth = 6;
            this.WareHoussGlassType.Name = "WareHoussGlassType";
            this.WareHoussGlassType.ReadOnly = true;
            this.WareHoussGlassType.Width = 125;
            // 
            // WareHoussGlassCyl
            // 
            this.WareHoussGlassCyl.HeaderText = "Cyl";
            this.WareHoussGlassCyl.MinimumWidth = 6;
            this.WareHoussGlassCyl.Name = "WareHoussGlassCyl";
            this.WareHoussGlassCyl.ReadOnly = true;
            this.WareHoussGlassCyl.Width = 125;
            // 
            // WareHoussGlassSph
            // 
            this.WareHoussGlassSph.HeaderText = "Sph";
            this.WareHoussGlassSph.MinimumWidth = 6;
            this.WareHoussGlassSph.Name = "WareHoussGlassSph";
            this.WareHoussGlassSph.ReadOnly = true;
            this.WareHoussGlassSph.Width = 125;
            // 
            // WareHoussGlassTypeQuantity
            // 
            this.WareHoussGlassTypeQuantity.HeaderText = "الكمية";
            this.WareHoussGlassTypeQuantity.MinimumWidth = 6;
            this.WareHoussGlassTypeQuantity.Name = "WareHoussGlassTypeQuantity";
            this.WareHoussGlassTypeQuantity.ReadOnly = true;
            this.WareHoussGlassTypeQuantity.Width = 125;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.numericUpDownAddTypeQuantity);
            this.groupBox17.Controls.Add(this.numericUpDownAddTypePriceBuy);
            this.groupBox17.Controls.Add(this.numericUpDownAddTypePriceSell);
            this.groupBox17.Controls.Add(this.label61);
            this.groupBox17.Controls.Add(this.label52);
            this.groupBox17.Controls.Add(this.label51);
            this.groupBox17.Controls.Add(this.textBoxGlassesSignAddSection);
            this.groupBox17.Controls.Add(this.label50);
            this.groupBox17.Controls.Add(this.textBoxCylAddSection);
            this.groupBox17.Controls.Add(this.label49);
            this.groupBox17.Controls.Add(this.button19);
            this.groupBox17.Controls.Add(this.textBoxSphAddSection);
            this.groupBox17.Controls.Add(this.label47);
            this.groupBox17.Controls.Add(this.textBoxGlassTypeCode);
            this.groupBox17.Controls.Add(this.label48);
            this.groupBox17.Location = new System.Drawing.Point(8, 28);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(799, 230);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "أضافة نوع عدسات";
            // 
            // numericUpDownAddTypeQuantity
            // 
            this.numericUpDownAddTypeQuantity.Location = new System.Drawing.Point(509, 131);
            this.numericUpDownAddTypeQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAddTypeQuantity.Name = "numericUpDownAddTypeQuantity";
            this.numericUpDownAddTypeQuantity.Size = new System.Drawing.Size(134, 32);
            this.numericUpDownAddTypeQuantity.TabIndex = 18;
            // 
            // numericUpDownAddTypePriceBuy
            // 
            this.numericUpDownAddTypePriceBuy.Location = new System.Drawing.Point(230, 175);
            this.numericUpDownAddTypePriceBuy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAddTypePriceBuy.Name = "numericUpDownAddTypePriceBuy";
            this.numericUpDownAddTypePriceBuy.Size = new System.Drawing.Size(134, 32);
            this.numericUpDownAddTypePriceBuy.TabIndex = 17;
            // 
            // numericUpDownAddTypePriceSell
            // 
            this.numericUpDownAddTypePriceSell.Location = new System.Drawing.Point(509, 175);
            this.numericUpDownAddTypePriceSell.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAddTypePriceSell.Name = "numericUpDownAddTypePriceSell";
            this.numericUpDownAddTypePriceSell.Size = new System.Drawing.Size(134, 32);
            this.numericUpDownAddTypePriceSell.TabIndex = 16;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(649, 133);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(69, 24);
            this.label61.TabIndex = 14;
            this.label61.Text = "الكمية:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(361, 174);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(114, 24);
            this.label52.TabIndex = 12;
            this.label52.Text = "سعر الشراء:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(649, 174);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(98, 24);
            this.label51.TabIndex = 10;
            this.label51.Text = "سعر البيع:";
            // 
            // textBoxGlassesSignAddSection
            // 
            this.textBoxGlassesSignAddSection.Location = new System.Drawing.Point(536, 79);
            this.textBoxGlassesSignAddSection.Name = "textBoxGlassesSignAddSection";
            this.textBoxGlassesSignAddSection.Size = new System.Drawing.Size(107, 32);
            this.textBoxGlassesSignAddSection.TabIndex = 9;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(649, 79);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(54, 24);
            this.label50.TabIndex = 8;
            this.label50.Text = "الرمز:";
            // 
            // textBoxCylAddSection
            // 
            this.textBoxCylAddSection.Location = new System.Drawing.Point(215, 76);
            this.textBoxCylAddSection.Name = "textBoxCylAddSection";
            this.textBoxCylAddSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCylAddSection.Size = new System.Drawing.Size(107, 32);
            this.textBoxCylAddSection.TabIndex = 7;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(149, 84);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(44, 24);
            this.label49.TabIndex = 6;
            this.label49.Text = ":Cyl";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(43, 182);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(103, 42);
            this.button19.TabIndex = 4;
            this.button19.Text = "أضافة";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // textBoxSphAddSection
            // 
            this.textBoxSphAddSection.Location = new System.Drawing.Point(215, 36);
            this.textBoxSphAddSection.Name = "textBoxSphAddSection";
            this.textBoxSphAddSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSphAddSection.Size = new System.Drawing.Size(107, 32);
            this.textBoxSphAddSection.TabIndex = 3;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(149, 44);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(50, 24);
            this.label47.TabIndex = 2;
            this.label47.Text = ":Sph";
            // 
            // textBoxGlassTypeCode
            // 
            this.textBoxGlassTypeCode.Location = new System.Drawing.Point(440, 31);
            this.textBoxGlassTypeCode.Name = "textBoxGlassTypeCode";
            this.textBoxGlassTypeCode.Size = new System.Drawing.Size(203, 32);
            this.textBoxGlassTypeCode.TabIndex = 1;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(649, 34);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(57, 24);
            this.label48.TabIndex = 0;
            this.label48.Text = "الكود:";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.numericUpDownGlassesType);
            this.groupBox16.Controls.Add(this.button18);
            this.groupBox16.Controls.Add(this.label46);
            this.groupBox16.Controls.Add(this.textBoxAddGlassesCodeCount);
            this.groupBox16.Controls.Add(this.label45);
            this.groupBox16.Location = new System.Drawing.Point(813, 28);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(538, 230);
            this.groupBox16.TabIndex = 0;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "أضافة عدسات";
            // 
            // numericUpDownGlassesType
            // 
            this.numericUpDownGlassesType.Location = new System.Drawing.Point(253, 79);
            this.numericUpDownGlassesType.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGlassesType.Name = "numericUpDownGlassesType";
            this.numericUpDownGlassesType.Size = new System.Drawing.Size(203, 32);
            this.numericUpDownGlassesType.TabIndex = 17;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(253, 133);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(103, 42);
            this.button18.TabIndex = 4;
            this.button18.Text = "أضافة";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(462, 91);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(69, 24);
            this.label46.TabIndex = 2;
            this.label46.Text = "الكمية:";
            // 
            // textBoxAddGlassesCodeCount
            // 
            this.textBoxAddGlassesCodeCount.Location = new System.Drawing.Point(162, 31);
            this.textBoxAddGlassesCodeCount.Name = "textBoxAddGlassesCodeCount";
            this.textBoxAddGlassesCodeCount.Size = new System.Drawing.Size(294, 32);
            this.textBoxAddGlassesCodeCount.TabIndex = 1;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(462, 34);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(57, 24);
            this.label45.TabIndex = 0;
            this.label45.Text = "الكود:";
            // 
            // DateTimeBillInfo
            // 
            this.DateTimeBillInfo.HeaderText = "التاريخ";
            this.DateTimeBillInfo.MinimumWidth = 6;
            this.DateTimeBillInfo.Name = "DateTimeBillInfo";
            this.DateTimeBillInfo.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "الأجمالى";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBills.ResumeLayout(false);
            this.tabBills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntotalBillCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunTimeBills)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomerPayAmount)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillInfo)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSupplierAddedCost)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSupplierPayAmount)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplierInfoPay)).EndInit();
            this.tabWorkers.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestroyedValue)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorrowingAmount)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveOrEditSalary)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkerAccountInformative)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkerSalary)).EndInit();
            this.tabPageReportUpload.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxAddManfcturePrice.ResumeLayout(false);
            this.groupBoxAddManfcturePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGlassTypePrice)).EndInit();
            this.groupBoxManfacturePrice.ResumeLayout(false);
            this.groupBoxManfacturePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModifyManfcPrice)).EndInit();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModifyTheOpticPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpticsView)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddTypeQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddTypePriceBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddTypePriceSell)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGlassesType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBills;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tabWorkers;
        private System.Windows.Forms.TabPage tabPageReportUpload;
        private System.Windows.Forms.ComboBox comboBoxCustomersNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCustomersNamesInfoBills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewBillInfo;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox comboBoxCustomerMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewCustomerAccount;
        private System.Windows.Forms.TextBox textBoxCustomerAccountInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCustomerPayTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCustomerPayMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxCustomerPaymentRemain;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxCustomerNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridViewSupplierInfoPay;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxShowPaymentSuppliers;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBoxSupplierPhoneNumber;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBoxRemainSupplierPayment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxSupplierPayTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBoxPayToSuppliers;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridViewWorkerAccountInformative;
        private System.Windows.Forms.TextBox textBoxSalaryTotalInWorkerAccount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboBoxInfoAboutWorkerAccount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBoxWorkerPhoneNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxWorkerName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox comboBoxRemoveOrEditWorker;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBoxRemoveOrEditWorkerPhoneNumber;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBoxBorrowRemain;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBoxSalaryBorrow;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox comboBoxBorrowWorkersName;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox comboBoxAddDestroyedObjectWorkerName;
        private System.Windows.Forms.TextBox textBoxRemainDestroyed;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox comboBoxPaymentSalaryWorkerName;
        private System.Windows.Forms.TextBox textBoxPaymentSalaryDestroyedCost;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBoxPaymentSalary;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBoxAddGlassesCodeCount;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox textBoxSphAddSection;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBoxGlassTypeCode;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox textBoxGlassesSignAddSection;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBoxCylAddSection;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.DataGridView dataGridViewOpticsView;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox textBoxModifyPriceOptic;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBoxModifiyOpticsPriceCode;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox textBoxBillOpticCode;
        private System.Windows.Forms.Button buttonAddIteamToBill;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeCustomerAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remain;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeSupportAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidSupportAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainSupportAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeWorkerAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaonWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryRemain;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareHoussGlassType;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareHoussGlassCyl;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareHoussGlassSph;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareHoussGlassTypeQuantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox textBoxTotalSupplierCost;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.ComboBox comboBoxSupplierAddCost;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkerSalary;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.NumericUpDown numericUpDownAddTypePriceBuy;
        private System.Windows.Forms.NumericUpDown numericUpDownAddTypePriceSell;
        private System.Windows.Forms.NumericUpDown numericUpDownAddTypeQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownRemoveOrEditSalary;
        private System.Windows.Forms.NumericUpDown numericUpDownBorrowingAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownDestroyedValue;
        private System.Windows.Forms.GroupBox groupBoxManfacturePrice;
        private System.Windows.Forms.GroupBox groupBoxAddManfcturePrice;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox textBoxGlassType;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.NumericUpDown numericUpDownGlassTypePrice;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox comboBoxModifyManfcPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownModifyManfcPrice;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.NumericUpDown numericUpDownSupplierAddedCost;
        private System.Windows.Forms.NumericUpDown numericUpDownSupplierPayAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomerPayAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownGlassesType;
        private System.Windows.Forms.NumericUpDown numericUpDownModifyTheOpticPrice;
        private System.Windows.Forms.Button buttonSearchToModifyOpticCode;
        private DataGridView dataGridViewRunTimeBills;
        private Label label67;
        private ComboBox comboBoxGlassesTypeBill;
        private DataGridViewTextBoxColumn GlassesType;
        private DataGridViewTextBoxColumn OpticType;
        private DataGridViewTextBoxColumn Sph;
        private DataGridViewTextBoxColumn Cyl;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn OpticPrice;
        private DataGridViewTextBoxColumn Manfc_Price;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn OpticCode;
        private Label label3;
        private NumericUpDown numericUpDowntotalBillCost;
        private DataGridViewTextBoxColumn DateTimeBillInfo;
        private DataGridViewTextBoxColumn Total;
    }
}