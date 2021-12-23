using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreUretenUygulama
{
    public partial class Form1 : Form
    {
        bool kucukHarfVarMi, buyukHarfVarMi, rakamVarMi, ozelKarakterVarMi;
        int sifreUzunlugu, sifreSayisi;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            txtSifreler.Text = "";
            kucukHarfVarMi = chkKucukHarf.Checked;
            buyukHarfVarMi = chkBuyukHarf.Checked;
            rakamVarMi = chkRakam.Checked;
            ozelKarakterVarMi = chkOzelKarakter.Checked;

            sifreUzunlugu = (int)nudSifreUzunlugu.Value;//convet.toint32
            sifreSayisi = (int)nudSifreSayisi.Value;
            if (!(kucukHarfVarMi||buyukHarfVarMi||rakamVarMi||ozelKarakterVarMi))
            {
                MessageBox.Show("Lütfen bir parametre seçiniz.");
                return;
            }
            string secilenKarakterler = "";
            if (ozelKarakterVarMi)
            {
                for (int i = 33; i < 48; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
                for (int i = 58; i < 65; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
                for (int i = 123; i < 127; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            if (rakamVarMi)
            {
                for (int i = 0; i < 10; i++)
                {
                    secilenKarakterler += i;
                }
            }
            if (buyukHarfVarMi)
            {
                for (int i = 65; i < 91; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            if (kucukHarfVarMi)
            {
                for (int i = 97; i < 123; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            for (int i = 0; i < sifreSayisi; i++)
            {
                string sifre = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sifre += secilenKarakterler[rnd.Next(secilenKarakterler.Length)];
                }
                txtSifreler.Text += sifre;
                txtSifreler.Text += "\r\n\r\n";
            }
        }
    }
}
