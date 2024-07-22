using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optical_Office_Mangment_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //load the customers name to combo box
            LoadDataIntowCustomerComboBoxName();
            this.dateTimePickerAnalyticsMonthley.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerAnalyticsMonthley.CustomFormat = "MMMM yyyy";
        }

        private void LoadDataIntowCustomerComboBoxName()
        {
            comboBoxCustomersNames.Items.AddRange(new object[] { "مصطفى" , "خالد", "على", "وائل" });
            comboBoxCustomersNamesInfoBills.Items.AddRange(new object[] { "مصطفى", "خالد", "على", "وائل" });
            comboBoxCustomerMoney.Items.AddRange(new object[] { "مصطفى", "خالد", "على", "وائل" });
            comboBoxCustomerPayMoney.Items.AddRange(new object[] { "مصطفى", "خالد", "على", "وائل" });
        }
    }
}
