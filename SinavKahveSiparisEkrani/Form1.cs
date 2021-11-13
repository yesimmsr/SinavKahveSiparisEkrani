using SinavKahveSiparisEkrani.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavKahveSiparisEkrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlBaslik_Paint(object sender, PaintEventArgs e)
        {
            pnlBaslik.BackColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillForm();

        }

        decimal toplam = 0;

        string[] kahveler = { "Misto", "Americano", "Bianco", "Cappucino", "Macchiato", "Con Panna", "Mocha" };
        double[] kahveFiyatlari = { 4.5, 5.75, 6, 7.5, 6.75, 8, 7.75 };

        string[] sogukIceceler = { "Ice Latte", "Limonata", "Milkshake" };
        int[] sogukIceceklerFiyatlari = { 5, 5, 5 };

        string[] sicakIcecekler = { "Çay", "Hot Chocolate", "Chai Tea Latte" };
        double[] sicakIceceklerFiyat = { 3, 4.5, 6.5 };



        public void FillForm()
        {
            //her bir combobox için ayrı metod yerine extension method kullanıldı.
            cmbKahveler.Secim(kahveler);
            cmbSicakIcecekler.Secim(sogukIceceler);
            cmbSogukIcecekler.Secim(sicakIcecekler);

        }




        private void btnHesapla_Click(object sender, EventArgs e)
        {
            

            if (cmbKahveler.SelectedIndex != -1 )
            {
                
              /*  
                if(chbShot1.Checked == true && chbShot2.Checked == false )
                {
                }*/
                
                lstSiparisler.Items.Add(cmbKahveler.SelectedItem +" "+ numKahveler.Value.ToString()+ "Adet" );

            }

            if (cmbSicakIcecekler.SelectedIndex != -1)
            {

                lstSiparisler.Items.Add(cmbSicakIcecekler.SelectedItem + " " + numSicakIcecekler.Value.ToString() + "Adet" + "");

            }

            if (cmbSogukIcecekler.SelectedIndex != -1)
            {

                lstSiparisler.Items.Add(cmbSogukIcecekler.SelectedItem + " " + numSogukIcecekler.Value.ToString() + "Adet" + "");

            }


        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çalışmadan olmuyor. Eksikler tamamlanacak -_-");
        }


    }
}

