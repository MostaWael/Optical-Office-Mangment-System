using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optical_Office_Mangment_System
{
    internal static class Helper
    {
        public static void AddSuccess()
        {
            MessageBox.Show("تمت الأضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void EmptyBoxWarning() 
        {
            MessageBox.Show("مينفعش يكون فيه مكان فاضى", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ZeroValueWarning()
        {
            MessageBox.Show("مينفعش قيمة المرتب تبقى ب صفر", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void NotExistInDataBase()
        {
            MessageBox.Show("غير موجود فى قاعدة البيانات", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UpdatedSuccessfully()
        {
            MessageBox.Show("تمت التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void DeletedSuccessfully()
        {
            MessageBox.Show("تمت الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void BorrowSuccessed()
        {
            MessageBox.Show("تم الأستلاف بنجاح", "أستلاف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DestroyedAdded()
        {
            MessageBox.Show("تم أضافة هالك بنجاح","أضافة هالك",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public static void PaySuccessed()
        {
            MessageBox.Show("تم الدفع بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void NoMoneyExixt()
        {
            MessageBox.Show("خطأ فى عملية الدفع", "فشل",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        public static void NoBillsForThisCustomer()
        {
            MessageBox.Show("لا يوجد فواتير لهذا العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void OpticDoesNotExist()
        {
            MessageBox.Show("هذا النوع غير موجود يرجى أضافته", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void NoPaymentExist()
        {
            MessageBox.Show("لا يوجد مدفوعات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void BiggerThanRemain()
        {
            MessageBox.Show("قوم بأيداع الباقى من الفاتورة أولآ ثم الباقى قم بوضعه مرة أخرى","خطأ" , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
