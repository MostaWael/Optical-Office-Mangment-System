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
    }
}
