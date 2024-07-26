using Optical_Office_Mangment_System.Models;
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
        private OpticsOfficeContext context;
        public MainForm()
        {
            InitializeComponent();
            //load the customers name to combo box
            context = new OpticsOfficeContext();
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

        private  void button6_Click(object sender, EventArgs e)
        {
            //Validate The Data
            string CustomerName = textBoxCustomerName.Text , CustomerNumber = textBoxCustomerNumber.Text , CompanyName = textBoxCompanyName.Text;
            if (CustomerName == string.Empty || CustomerNumber == string.Empty || CompanyName == string.Empty)
            {
                Helper.EmptyBoxWarning();
            }
            else
            {
                
                context.Customers.Add(new Customers { Name = CustomerName , ComapnyName = CompanyName , PhoneNumber = CustomerNumber });
                context.SaveChanges();

                Helper.AddSuccess();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string SupplierName = textBoxSupplierName.Text, SupplierPhoneNumber = textBoxSupplierPhoneNumber.Text;

            if(SupplierName == string.Empty || SupplierPhoneNumber == string.Empty )
            {
                Helper.EmptyBoxWarning();
            }
            else
            {
                context.Suppliers.Add(new Suppliers {  Name = SupplierName , PhoneNumber = SupplierPhoneNumber });
                context.SaveChanges();

                Helper.AddSuccess();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string WorkerName = textBoxWorkerName.Text,
                WorkerPhoneNumber = textBoxWorkerPhoneNumber.Text;
            decimal WorkerSalary = numericUpDownWorkerSalary.Value;

            if(WorkerSalary == 0 )
            {
                Helper.ZeroValueWarning();
                return;
            }
            if(WorkerName == string.Empty || WorkerPhoneNumber == string.Empty)
            {
                Helper.EmptyBoxWarning();
                return;
            }
            context.Workers.Add(new Workers { 
                Name = WorkerName , 
                PhoneNumber= WorkerPhoneNumber,
                Salary= WorkerSalary
            });

            context.SaveChanges();
            Helper.AddSuccess();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            string GlaassTypeCode = textBoxGlassTypeCode.Text,
                Sph = textBoxSphAddSection.Text,
                Cyl = textBoxCylAddSection.Text,
                Sign = textBoxGlassesSignAddSection.Text;

            decimal PriceSell = numericUpDownAddTypePriceBuy.Value,
                PriceBuy = numericUpDownAddTypePriceBuy.Value;
            int Quantity = (int)numericUpDownAddTypeQuantity.Value;

            if (GlaassTypeCode == string.Empty || 
                Sph == string.Empty || 
                Cyl == string.Empty ||
                Sign == string.Empty)
            {
                Helper.EmptyBoxWarning();
                return;
            }
            if(PriceSell == 0 || 
                PriceBuy == 0 ||
                Quantity == 0)
            {
                Helper.ZeroValueWarning();
                return;
            }

            context.Optics.Add(new Optics
            {
                Code = GlaassTypeCode,
                Cyl = Cyl,
                Sph= Sph,
                PriceBuy= PriceBuy,
                PriceSell= PriceSell,
                Quantity=Quantity,
                Type = Sign
            });

            context.SaveChanges();
            Helper.AddSuccess();

        }
    }
}
