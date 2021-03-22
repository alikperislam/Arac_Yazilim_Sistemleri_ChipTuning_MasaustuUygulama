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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal) // windows penceresi eğer kodlandığı şekilde yani normal vaziyette ise.
            {
                WindowState = FormWindowState.Maximized; // ekranı en büyük yap.

                //int btndelx =btnDelete.Location.X;
                
                // tamamen kod ile ekran büyüyü küçüldüğü zaman butonların yerinin bozulmamasını yine sağ yukarı çaprazda kalmalarını sağlaıdk bu kod sayesinde.
                

                Point pt = new Point();
                Point pt0 = new Point();
                Point pt1 = new Point();

                pt.X =btnDelete.Location.X+240;
                pt.Y =btnDelete.Location.Y;

                
                pt0.X =btnMinimum.Location.X  + 240;
                pt0.Y =btnMinimum.Location.Y ;

                
                pt1.X =  btnMinMax.Location.X+ 240;
                pt1.Y =  btnMinMax.Location.Y;

                btnDelete.Location =pt;
               btnMinimum.Location =pt0;
                btnMinMax.Location =pt1;

            }
            else
            {
                // eğer büyük vaziyetteyse ekran yani normal vaziyette değil ise o zaman;
                WindowState = FormWindowState.Normal;

                int btndelx = btnDelete.Location.X;
                int btndely = btnDelete.Location.Y;
                int btnminx = btnMinimum.Location.X;
                int btnminy = btnMinimum.Location.Y;
                int btnmaxx = btnMinMax.Location.X;
                int btnmaxy = btnMinMax.Location.Y;

                Point pt = new Point();
                Point pt0 = new Point();
                Point pt1 = new Point();

                pt.X = btndelx - 240;
                pt.Y = btndely;


                pt0.X = btnminx - 240;
                pt0.Y = btnminy;


                pt1.X = btnmaxx - 240;
                pt1.Y = btnmaxy;

                btnDelete.Location = pt;
                btnMinimum.Location = pt0;
                btnMinMax.Location = pt1;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // bir ekranın alta geömesi, büyüp eski haline gelmesi için windowstate = formwindowsstate.(min max) methodunu kullanıyoruz büyültme için if şartı gerekli sadece.
            WindowState = FormWindowState.Minimized;
        }

        // panel içerisinde form çağırmak için :
        // not ---> öncelikle ana dorm içeriisndeki mdi = true yapmamız gerekiyor tasarım kısmındna yani izin vermemiz gerekiyor başka formu form içerisinde çağırabilmek için.
        private void panelform(Form frm) // bir method içeriisnde belirtip formdan gelen veriyi methoda göndereceğiz.
        {
            anaPanel.Controls.Clear(); // üst üste formlar gelmemesi için panelin içerisini her seferinde temizliyoruz.
            frm.MdiParent = this; // gelen formu yani açılacak olan formu burada açacağına dair Mdi=this; yapıyoruz.
            anaPanel.Controls.Add(frm);//formu nerede açacaksa o panelin controlune ekliyoruz.
            frm.Show(); // formu ekranda göstermesi için klasik .show methodunu kullnmamız gerek.
        }



        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            pictureİstatistik.BackColor = Color.FromArgb(172, 126, 241);
            pictureHome.BackColor = Color.FromArgb(172, 126, 241);
            lblHome.ForeColor = Color.FromArgb(172, 126, 241);
            
            frmistatistik frista = new frmistatistik();
            panelform(frista); // form üzerinden bir nesne tanımladık ve o nesneyi methodumuzun içeirisne gönderdik artık kullanıcı butona tıkladığı sırada formu açacak içerisindeki verilere ulaşabilecek üzerinde değişiklikler yapabiledek.

            
        }

        private void btnÜrün_Click(object sender, EventArgs e)
        {
            pictureUrun.BackColor = Color.FromArgb(249,118,176);
            pictureHome.BackColor = Color.FromArgb(249, 118, 176);
            lblHome.ForeColor = Color.FromArgb(249, 118, 176);

            frmürünler frurun = new frmürünler();
            panelform(frurun);
        }

        private void btnMüsteri_Click(object sender, EventArgs e)
        {
            pictureMüsteri.BackColor = Color.FromArgb(253,138,114);
            pictureHome.BackColor = Color.FromArgb(253, 138, 114);
            lblHome.ForeColor = Color.FromArgb(253, 138, 114);

            frmmüsterikayit frmusteri = new frmmüsterikayit();
            panelform(frmusteri);
        }

        
        

        private void btnSatışlar_Click(object sender, EventArgs e)
        {
            pictureSatışlar.BackColor = Color.FromArgb(95,77,221);
            pictureHome.BackColor = Color.FromArgb(95, 77, 221);
            lblHome.ForeColor = Color.FromArgb(95, 77, 221);

            frmsatislar frsatıs = new frmsatislar();
            panelform(frsatıs);

           


        }

        private void btnİletişim_Click(object sender, EventArgs e)
        {
            Pictureİletişim.BackColor = Color.FromArgb(249,88,155);
            pictureHome.BackColor = Color.FromArgb(249, 88, 155);
            lblHome.ForeColor = Color.FromArgb(249, 88, 155);

            frmiletisim frilet = new frmiletisim();
            panelform(frilet);
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            PictureAyarlar.BackColor = Color.FromArgb(24,161,251);
            pictureHome.BackColor = Color.FromArgb(24, 161, 251);
            lblHome.ForeColor = Color.FromArgb(24, 161, 251);

            frmayarlar frayar = new frmayarlar();
            panelform(frayar);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureho.BackColor = Color.FromArgb(9, 237, 237);
            pictureHome.BackColor = Color.FromArgb(9, 237, 237);
            lblHome.ForeColor = Color.FromArgb(9, 237, 237);

            homePage hm = new homePage();
            panelform(hm);
        }
    }
}
