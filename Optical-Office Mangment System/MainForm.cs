using Optical_Office_Mangment_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        private Workers DestroyedWorker;

        public MainForm()
        {
            InitializeComponent();
            //load the customers name to combo box
            context = new OpticsOfficeContext();
            LoadDataIntowCustomerComboBoxName();
            loadDataIntoSuppliersNameComboBox();
            //Load Workers DataInto the Workers ComboBox
            LoadDataIntoWorkersComboBox();
            loadDataIntoGlassTypeComboBox();
            this.dateTimePickerAnalyticsMonthley.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerAnalyticsMonthley.CustomFormat = "MMMM yyyy";
        }

        #region LoadDataFunctions

        private void LoadDataIntoWorkersComboBox()
        {
            var WorkersName = context.Workers.Select(x => x.Name).ToList();
            comboBoxRemoveOrEditWorker.DataSource = WorkersName;
            comboBoxAddDestroyedObjectWorkerName.DataSource = WorkersName;
            comboBoxBorrowWorkersName.DataSource = WorkersName;
            comboBoxInfoAboutWorkerAccount.DataSource = WorkersName;
            comboBoxPaymentSalaryWorkerName.DataSource= WorkersName;
        }
        
        private void LoadDataIntoOpticsGridView()
        {
            dataGridViewOpticsView.Rows.Clear();
            var Optics = context.Optics.OrderBy(op => op.Cyl).ToList();

            foreach (var opt in Optics)
            {
                dataGridViewOpticsView.Rows.Add(opt.Type, opt.Cyl, opt.Sph, opt.Quantity);
            }
        }

        private void LoadDataIntowCustomerComboBoxName()
        {
            var CustomersNames = context.Customers.Select(x => x.Name).ToList();
            comboBoxCustomersNames.DataSource = CustomersNames;
            comboBoxCustomersNamesInfoBills.DataSource = CustomersNames;
            comboBoxCustomerMoney.DataSource = CustomersNames;
            comboBoxCustomerPayMoney.DataSource = CustomersNames;
        }

        //Load Name Type Into the ComboBox

        private void loadDataIntoGlassTypeComboBox()
        {
            var TypesNameList = context.GlassesTypes.Select(g => g.Name).ToList();
            comboBoxModifyManfcPrice.DataSource = TypesNameList;
        }

        private void loadDataIntoSuppliersNameComboBox()
        {
            var SuppliersName = context.Suppliers.Select(x => x.Name).ToList();
            comboBoxShowPaymentSuppliers.DataSource = SuppliersName;
            comboBoxPayToSuppliers.DataSource= SuppliersName;
            comboBoxShowPaymentSuppliers.DataSource = SuppliersName;
            comboBoxSupplierAddCost.DataSource = SuppliersName;
        }

        #endregion

        #region SupplierTab

        //Add Suppliers
        private void button8_Click(object sender, EventArgs e)
        {
            string SupplierName = textBoxSupplierName.Text, SupplierPhoneNumber = textBoxSupplierPhoneNumber.Text;

            if (SupplierName == string.Empty || SupplierPhoneNumber == string.Empty)
            {
                Helper.EmptyBoxWarning();
            }
            else
            {
                context.Suppliers.Add(new Suppliers { Name = SupplierName, PhoneNumber = SupplierPhoneNumber });
                context.SaveChanges();

                Helper.AddSuccess();

                loadDataIntoSuppliersNameComboBox();
            }
        }

        //Add Cost Suppliers
        private void button23_Click(object sender, EventArgs e)
        {
            string SuppkierName = comboBoxSupplierAddCost.Text;

            var Supplier = context.Suppliers.FirstOrDefault(s => s.Name == SuppkierName);

            Supplier.Money += numericUpDownSupplierAddedCost.Value;

            context.SaveChanges();

            Helper.AddSuccess();

        }


        private void numericUpDownSupplierAddedCost_ValueChanged(object sender, EventArgs e)
        {
            string SuppkierName = comboBoxSupplierAddCost.Text;

            var Supplier = context.Suppliers.FirstOrDefault(s => s.Name == SuppkierName);

            textBoxTotalSupplierCost.Text = (numericUpDownSupplierAddedCost.Value + Supplier.Money).ToString();

        }

        //SupplierPay
        private void button9_Click(object sender, EventArgs e)
        {
            string name = comboBoxPayToSuppliers.Text;

            var Supplier = context.Suppliers.FirstOrDefault(s => s.Name == name);

            if(Supplier.Money > 0)
            {
                Supplier.Money -= numericUpDownSupplierPayAmount.Value;

                Supplier.Payments.Add(new SuppliersPayment { cost = numericUpDownSupplierPayAmount.Value, remain = Supplier.Money });

                context.SaveChanges();

                Helper.PaySuccessed();
            }
            else
            {
                Helper.NoMoneyExixt();
            }

        }

        private void numericUpDownSupplierPayAmount_ValueChanged(object sender, EventArgs e)
        {
            string name = comboBoxPayToSuppliers.Text;
            var Supplier = context.Suppliers.FirstOrDefault(s => s.Name == name);

            textBoxRemainSupplierPayment.Text = (Supplier.Money - numericUpDownSupplierPayAmount.Value).ToString();
        }

        private void comboBoxPayToSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBoxPayToSuppliers.Text;
            var Supplier = context.Suppliers.FirstOrDefault(s => s.Name == name);
            
            textBoxSupplierPayTotal.Text = Supplier.Money.ToString();
        }

        //PaymentsSupplier
        private void comboBoxShowPaymentSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewSupplierInfoPay.Rows.Clear();
            string supplierName = comboBoxShowPaymentSuppliers.Text;
            var supplier = context.Suppliers.Include(s => s.Payments).FirstOrDefault(s=>s.Name == supplierName);
        
            foreach(var payment in supplier.Payments)
            {
                dataGridViewSupplierInfoPay.Rows.Add(payment.PaymentTime.ToString("dd/MM/yyyy"), payment.cost, payment.remain);
            }
        }

        #endregion


        #region WorkerTab

        private void button10_Click(object sender, EventArgs e)
        {
            string WorkerName = textBoxWorkerName.Text,
                WorkerPhoneNumber = textBoxWorkerPhoneNumber.Text;
            decimal WorkerSalary = numericUpDownWorkerSalary.Value;

            if (WorkerSalary == 0)
            {
                Helper.ZeroValueWarning();
                return;
            }
            if (WorkerName == string.Empty || WorkerPhoneNumber == string.Empty)
            {
                Helper.EmptyBoxWarning();
                return;
            }
            context.Workers.Add(new Workers
            {
                Name = WorkerName,
                PhoneNumber = WorkerPhoneNumber,
                Salary = WorkerSalary
            });

            context.SaveChanges();
            Helper.AddSuccess();

            LoadDataIntoWorkersComboBox();

        }

        private async Task<Workers> GetWorkerAsync(string workerName)
        {
            return await Task.Run(() =>
            {
                using (var context1 = new OpticsOfficeContext())
                {
                    return context1.Workers.Include(w => w.Borrowers).FirstOrDefault(w => w.Name == workerName);
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
                context.Borrowers.RemoveRange(worker.Borrowers);
                context.Workers.Remove(worker);
                context.SaveChanges();
            });

            Helper.DeletedSuccessfully();
            LoadDataIntoWorkersComboBox();
            textBoxRemoveOrEditWorkerPhoneNumber.Clear();
            numericUpDownRemoveOrEditSalary.Value = 0;

        }

        //button Bowrroing
        private async void button14_Click(object sender, EventArgs e)
        {

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

                context.Entry(BorrowWorkerObject).State = EntityState.Detached;

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
            string WorkerName = comboBoxBorrowWorkersName.SelectedItem.ToString();

            BorrowWorkerObject = await GetWorkerAsync(WorkerName);

            textBoxSalaryBorrow.Text = BorrowWorkerObject.Salary.ToString();
            textBoxBorrowRemain.Text = (BorrowWorkerObject.Salary - numericUpDownBorrowingAmount.Value).ToString();
        }

        private async void comboBoxInfoAboutWorkerAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewWorkerAccountInformative.Rows.Clear();
            string workerName = comboBoxInfoAboutWorkerAccount.SelectedItem.ToString();
            var worker = await GetWorkerAsync(workerName);

            textBoxSalaryTotalInWorkerAccount.Text = worker.Salary.ToString();

            foreach (var Borrow in worker.Borrowers)
            {
                dataGridViewWorkerAccountInformative.Rows.Add(Borrow.BorrowTime.ToString("dd/MM/yyyy"), Borrow.cost, Borrow.remain);
            }

        }

        private async void comboBoxAddDestroyedObjectWorkerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string WorkerName = comboBoxAddDestroyedObjectWorkerName.SelectedItem.ToString();
            DestroyedWorker = await GetWorkerAsync(WorkerName);

            numericUpDownDestroyedValue.Value = 0;
            textBoxRemainDestroyed.Text = DestroyedWorker.Salary.ToString();

        }

        private void numericUpDownDestroyedValue_ValueChanged(object sender, EventArgs e)
        {
            textBoxRemainDestroyed.Text = (DestroyedWorker.Salary - numericUpDownDestroyedValue.Value).ToString();
        }

        //Add Destroyed Object
        private void button15_Click(object sender, EventArgs e)
        {
            context.Workers.Attach(DestroyedWorker);

            DestroyedWorker.loses += numericUpDownDestroyedValue.Value;
            context.SaveChanges();

            context.Entry(DestroyedWorker).State = EntityState.Detached;

            Helper.DestroyedAdded();
        }

        private async void comboBoxPaymentSalaryWorkerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string WorkerName = comboBoxPaymentSalaryWorkerName.Text;

            var worker = await GetWorkerAsync(WorkerName);
            textBoxPaymentSalary.Text = worker.Salary.ToString();
            textBoxPaymentSalaryDestroyedCost.Text = worker.loses.ToString();
        }
        #endregion

        #region Customer Tab

        //Select Cuatomer for Pay
        private void comboBoxCustomerPayMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CustomerName = comboBoxCustomerPayMoney.Text;
            var customer = context.Customers.FirstOrDefault(x => x.Name == CustomerName);

            int lastBillNumber;

            if (customer.Bills.LastOrDefault() == null)
            {
                Helper.NoBillsForThisCustomer();
                return;
            }
            else
            {
                lastBillNumber = customer.Bills.LastOrDefault().Number;
            }



            if (customer.Bills.Count == 0 || customer.Bills[lastBillNumber].TotalCost == 0 || customer.Bills == null)
            {
                Helper.NoBillsForThisCustomer();
                return;
            }

            textBoxCustomerPayTotal.Text = customer.TotalCost.ToString();
            
        }

        //Set Payment Amount
        private void numericUpDownCustomerPayAmount_ValueChanged(object sender, EventArgs e)
        {
            string CustomerName = comboBoxCustomerPayMoney.Text;
            var customer = context.Customers.FirstOrDefault(x => x.Name == CustomerName);

            textBoxCustomerPaymentRemain.Text = (customer.TotalCost - numericUpDownCustomerPayAmount.Value).ToString();
        }

        //Customer Pay
        private void button5_Click(object sender, EventArgs e)
        {
            string CustomerName = comboBoxCustomerPayMoney.Text;
            var customer = context.Customers.FirstOrDefault(x => x.Name == CustomerName);

            customer.TotalCost -= numericUpDownCustomerPayAmount.Value;

            int lastBillNumber = customer.Bills.LastOrDefault().Number;

            string BillStateValue = (customer.TotalCost > 0) ? "باقى منها" : "مكتملة";

            customer.CustomerPayments.Add(
                new CustomerPayments { 
                    BillNumber = customer.Bills[lastBillNumber].Number, 
                    PaidTotal = numericUpDownCustomerPayAmount.Value, 
                    Remain = customer.TotalCost, 
                    BillState = BillStateValue
                });
            context.SaveChanges();
        }

        //Add Customer
        private void button6_Click(object sender, EventArgs e)
        {
            //Validate The Data
            string CustomerName = textBoxCustomerName.Text, CustomerNumber = textBoxCustomerNumber.Text, CompanyName = textBoxCompanyName.Text;
            if (CustomerName == string.Empty || CustomerNumber == string.Empty || CompanyName == string.Empty)
            {
                Helper.EmptyBoxWarning();
            }
            else
            {

                context.Customers.Add(new Customers { Name = CustomerName, ComapnyName = CompanyName, PhoneNumber = CustomerNumber });
                context.SaveChanges();

                Helper.AddSuccess();
            }

        }
        #endregion

        #region WareHouse


        //Add GlassType
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
            if (PriceSell == 0 ||
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
                Sph = Sph,
                PriceBuy = PriceBuy,
                PriceSell = PriceSell,
                Quantity = Quantity,
                Type = Sign
            });

            context.SaveChanges();
            Helper.AddSuccess();
            LoadDataIntoOpticsGridView();

        }


        //Add Manfacture Price
        private void button24_Click(object sender, EventArgs e)
        {
            string name = textBoxGlassType.Text;
            decimal price = numericUpDownGlassTypePrice.Value;

            context.GlassesTypes.Add(new GlassesType { Name = name, ManfacuturePrice = price });
            context.SaveChanges();
            Helper.AddSuccess();
        }

        //Modifiy Manfacturer Price
        private void button25_Click(object sender, EventArgs e)
        {
            string TypeName = comboBoxModifyManfcPrice.Text;
            var Type = context.GlassesTypes.FirstOrDefault(g => g.Name == TypeName);

            decimal price = numericUpDownModifyManfcPrice.Value;

            Type.ManfacuturePrice = price;

            context.SaveChanges();
            Helper.UpdatedSuccessfully();
            numericUpDownModifyManfcPrice.Value = 0;


        }


        //Change The ManfcPrice
        private void comboBoxModifyManfcPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TypeName = comboBoxModifyManfcPrice.Text;
            var Type = context.GlassesTypes.FirstOrDefault(g => g.Name == TypeName);

            numericUpDownModifyManfcPrice.Value = Type.ManfacuturePrice;
        }


        private void button26_Click(object sender, EventArgs e)
        {
            string TypeName = comboBoxModifyManfcPrice.Text;
            var Type = context.GlassesTypes.FirstOrDefault(g => g.Name == TypeName);

            context.GlassesTypes.Remove(Type);
            context.SaveChanges();

            Helper.DeletedSuccessfully();
        }




        //Add GlassesType in WareHous
        private void button18_Click(object sender, EventArgs e)
        {
            string Code = textBoxAddGlassesCodeCount.Text;

            var optic = context.Optics.FirstOrDefault(opt => opt.Code == Code);

            if(optic == null)
            {
                Helper.OpticDoesNotExist();
            }
            else
            {
                optic.Quantity += (int)numericUpDownGlassesType.Value;
            }

            context.SaveChanges();

            Helper.AddSuccess();
            LoadDataIntoOpticsGridView();
        }


        //Modify The GlassesPrice
        private void button20_Click(object sender, EventArgs e)
        {
            string Code = textBoxModifiyOpticsPriceCode.Text;

            var optic = context.Optics.FirstOrDefault(opt => opt.Code == Code);

            optic.PriceSell += numericUpDownModifyTheOpticPrice.Value;

            context.SaveChanges();
            Helper.UpdatedSuccessfully();
        }

        //Search For The Type You will modify
        private void buttonSearchToModifyOpticCode_Click(object sender, EventArgs e)
        {
            string Code = textBoxModifiyOpticsPriceCode.Text;

            var optic = context.Optics.FirstOrDefault(opt => opt.Code == Code);

            textBoxModifyPriceOptic.Text = optic.PriceSell.ToString();
        }

        //Modify Collection of prices to a collection of prices
        private void button21_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoOpticsGridView();
        }


    }
}
