using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracYazilimApp
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            
            
            
            

            // İLK GRAFİK VERİLERİ :
            chartMarka.Series["Marka"].Points.Clear(); // VERİLERİN ÜST ÜSTE BİNMESİNİ ENGELLEMEK İÇİN KULLANDIK CLEAR METHODUNU.

            chartMarka.Series["Marka"].Points.AddXY("BMW",5);
            chartMarka.Series["Marka"].Points.AddXY("AUDI",4);
            chartMarka.Series["Marka"].Points.AddXY("MERCEDES",1);
            chartMarka.Series["Marka"].Points.AddXY("HONDA",1);
            chartMarka.Series["Marka"].Points.AddXY("WOLKSVAGEN",0);
            chartMarka.Series["Marka"].Points.AddXY("FERRARI",0);
            chartMarka.Series["Marka"].Points.AddXY("LAMBORGINI",1);
   
            chartMarka.Series["Marka"].Points.AddXY("MUSTANG",2);
            chartMarka.Series["Marka"].Points.AddXY("FORD",0);

            /////////////////////////////////////////////////////////////////
            // 2. GRAFİK VERİLERİ :

            chartSatislar.Series["Satışlar"].Points.Clear();

            chartSatislar.Series["Satışlar"].Points.AddXY("Erp Arıza Çözümü",4);
            chartSatislar.Series["Satışlar"].Points.AddXY("Yakıt Tasarrufu",4);
            chartSatislar.Series["Satışlar"].Points.AddXY("Beygir Yükseltme",7);





        }
    }
}
