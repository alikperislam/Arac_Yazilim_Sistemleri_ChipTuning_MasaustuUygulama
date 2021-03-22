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
    public partial class frmsatislar : Form
    {
        public frmsatislar()
        {
            InitializeComponent();
        }

        public void SATISLAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SATISLAR.Items.Clear();
            SATISLAR.Items.Add("BMW | 520i special edition | 2020 | 170 hp | 1597 cc | arkadan itiş | benzin | 79 as 125 -----> beygir yükseltme işlemi yapıldı");
            SATISLAR.Items.Add("AUDI | A7 3.0 TDİ | 2011 | 245 hp | 2967 cc | 4WD çekiş | dizel | 39 alf 12 -----> beygir yükseltme işlemi yapıldı");
            SATISLAR.Items.Add("BMW | 530d | 2004 | 231 hp | 2993 cc | arkadan itiş | dizel | 14 th 348 -----> erp arızası giderildi");
            SATISLAR.Items.Add("MUSTANG | 2.3 FASTBACK | 2016 | 317 hp | 2300 cc | arkadan itiş | BENZİN | 77 ty 897 -----> beygir yükseltme işlemi yapıldı");
            SATISLAR.Items.Add("MUSTANG | 5.0 convertible | 2012 | 421 hp | 4951 cc | arkadan itiş | benzin | 34 cjf 349 -----> erp arızası giderildi");
            SATISLAR.Items.Add("BMW | 418i coupe | 2017 | 136 hp | 1499 cc | arkadan itiş | benzin | 16 tv 7569 -----> %35 yakıt tasarrufu uygulandı");
            SATISLAR.Items.Add("HONDA | civic vtec | 2020 | 125 hp | 1597 cc | önden çekiş | benzin & lpg | 06 yhc 147 -----> beygir yükseltme işlemi yapıldı");
            SATISLAR.Items.Add("LAMBORGINI | Huracan | 2014 | 610 hp | 5204 cc | 4WD çekiş | benzin | 35 nzt 17 -----> %35 yakıt tasarrufu uygulandı");
            SATISLAR.Items.Add("BMW | 420d xDrive M sport | 2015 | 190 hp | 1995 cc | 4WD çekiş | dizel | 34 bh 537 -----> beygir yükseltme işlemi yapıldı");
            SATISLAR.Items.Add("MERCEDES | E serisi | 2014 | 204 hp | 2143 cc | 4WD çekiş | dizel | 07 jv 156 -----> %35 yakıt tasarrufu uygulandı");
            SATISLAR.Items.Add("BMW | 216i grand coupe | 2020 | 116 hp | 1496 cc | önden çekiş | dizel | 35 py 913 -----> %35 yakıt tasarrufu uygulandı");
            SATISLAR.Items.Add("AUDI | A3 sportback | 2017 | 116 hp | 999 cc | önden çekiş | benzin | 35 tı 487 -----> beygir yükseltme işlemi yapıldı");
            SATISLAR.Items.Add("AUDI | A6 quattro | 2016 | 190 hp | 1968 cc | 4WD çekiş | dizel | 41 ar 357 -----> erp arızası giderildi");
            SATISLAR.Items.Add("AUDI | A4 | 2012 | 177 hp | 1968 cc | önden çekiş | dizel | 34 lst 78 -----> beygir yükseltme işlemi yapıldı");
        }
    }
}
