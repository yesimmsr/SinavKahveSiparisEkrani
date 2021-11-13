using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavKahveSiparisEkrani.Extension
{
    public static class CustomExtension
    {
        public static void Secim(this ComboBox cmb, string[] items)
        {
            cmb.Items.Clear();
            cmb.Items.Add("Seciniz");
            for (int i = 0; i < items.Length; i++)
            {
                cmb.Items.Add(items[i]);
            }
            cmb.SelectedIndex = 0;
        }
    }
}
