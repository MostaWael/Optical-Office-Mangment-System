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
        private Workers BorrowWorkerObject;
        public MainForm()
        {
            InitializeComponent();
            //load the customers name to combo box
            context = new OpticsOfficeContext();
            LoadDataIntowCustomerComboBoxName();
            //Load Workers DataInto the Workers ComboBox
            LoadDataIntoWorkersComboBox();
            this.dateTimePickerAnalyticsMonthley.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerAnalyticsMonthley.CustomFormat = "MMMM yyyy";
        }

        private void LoadDataIntoWorkersComboBox()
        {
            var WorkersName = context.Workers.Select(x => x.Name).ToList();
            comboBoxRemoveOrEditWorker.DataSource = WorkersName;
            comboBoxAddDestroyedObjectWorkerName.DataSource = WorkersName;
            comboBoxBorrowWorkersName.DataSource = WorkersName;
            comboBoxInfoAboutWorkerAccount.DataSource = WorkersName;
            comboBoxPaymentSalaryWorkerName.DataSource= WorkersName;
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

            LoadDataIntoWorkersComboBox();

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

        private async Task<Workers> GetWorkerAsync(string workerName)
        {
            return await Task.Run(() =>
            {
                using (var context1 = new OpticsOfficeContext())
                {
                    return context1.Workers.FirstOrDefault(w => w.Name == workerName);
                }
            });
        }

        private async void comboBoxRemoveOrEditWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string WorkerName = comboBoxRemoveOrEditWorker.SelectedItem.ToString();

            var worker = await GetWorkerAsync(WorkerName);

            if (worker != null)
            {
                textBoxRemoveOrEditWorkerPhoneNumber.Text = worker.PhoneNumber;
                numericUpDownRemoveOrEditSalary.Value = worker.Salary;

            }
            else
            {
                Helper.NotExistInDataBase();
            }
        }

        //Modify the Worker
        private async void button12_Click(object sender, EventArgs e)
        {
            string WorkerName = comboBoxRemoveOrEditWorker.SelectedItem.ToString();

            var worker = await GetWorkerAsync(WorkerName);

            if (worker != null)
            {
                using (var context1 = new OpticsOfficeContext())
                {
                    context1.Workers.Attach(worker); //now i attch the worker i get to this context , no i can save changes

                    worker.Salary = numericUpDownRemoveOrEditSalary.Value;
                    worker.PhoneNumber = textBoxRemoveOrEditWorkerPhoneNumber.Text;

                    context1.SaveChanges();
                }

                //This Run Faster because it's outside the thread
                Helper.UpdatedSuccessfully();
            }
            else
            {
                Helper.NotExistInDataBase();
            }

        }

        //Remove Worker
        private async void button13_ClickAsync(object sender, EventArgs e)
        {
            string WorkerName = comboBoxRemoveOrEditWorker.SelectedItem.ToString();

            var worker = await GetWorkerAsync(WorkerName);

            context.Workers.Attach(worker);
            await Task.Run(() =>
            {
                context.Workers.Remove(worker);
                context.SaveChanges();
            });

            Helper.DeletedSuccessfully();
            LoadDataIntoWorkersComboBox();

        }

        //button Bowrroing
        private async void button14_Click(object sender, EventArgs e)
        {
            string WorkerName = comboBoxRemoveOrEditWorker.SelectedItem.ToString();

            
            context.Workers.Attach(BorrowWorkerObject);

            await Task.Run(() =>
            {
                BorrowWorkerObject.Borrowers.Add(new Borrowers
                {
                    cost = numericUpDownBorrowingAmount.Value,
                    remain = BorrowWorkerObject.Salary - numericUpDownBorrowingAmount.Value,
                });

                BorrowWorkerObject.Salary = BorrowWorkerObject.Salary - numericUpDownBorrowingAmount.Value;

                context.SaveChanges();
            });

            Helper.BorrowSuccessed();

        }

        //change the value in the borrow groupbox
        private void numericUpDownBorrowingAmount_ValueChanged(object sender, EventArgs e)
        {
            //var worker = await GetWorkerAsync(WorkerName);
            
            textBoxSalaryBorrow.Text = BorrowWorkerObject.Salary.ToString();
            textBoxBorrowRemain.Text = (BorrowWorkerObject.Salary - numericUpDownBorrowingAmount.Value).ToString();

           
        }

        private async void comboBoxBorrowWorkersName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string WorkerName = comboBoxRemoveOrEditWorker.SelectedItem.ToString();

            BorrowWorkerObject = await GetWorkerAsync(WorkerName);

            textBoxSalaryBorrow.Text = BorrowWorkerObject.Salary.ToString();
            textBoxBorrowRemain.Text = (BorrowWorkerObject.Salary - numericUpDownBorrowingAmount.Value).ToString();
        }
    }
}
