using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;


namespace aracYazilimApp
{
    public partial class frmiletisim : Form
    {
        public frmiletisim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopupNotifier popp = new PopupNotifier();
            popp.ContentText = "https://www.linkedin.com/in/alikper-islam-828b9b18b/";
            popp.BodyColor = Color.Blue;
            popp.ContentColor = Color.White; //yazı rengi değiştirmek için.
            popp.Image = Properties.Resources.link;
            popp.Popup();
        }

        

        private void frmiletisim_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopupNotifier popp = new PopupNotifier();
            popp.ContentText = "www.theblackconsole.com";
            popp.BodyColor = Color.Black;
            popp.ContentColor = Color.White;
            popp.Image = Properties.Resources.web;
            popp.Popup();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PopupNotifier popp = new PopupNotifier();
            popp.ContentText = "https://github.com/alikperislam";
            popp.BodyColor = Color.Gray;
            popp.Image = Properties.Resources.git;
            popp.Popup();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PopupNotifier popp = new PopupNotifier();
            popp.ContentText = "https://bionluk.com/alikperislam";
            popp.BodyColor = Color.Fuchsia;
            popp.Image = Properties.Resources.bionluk;
            popp.Popup();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PopupNotifier popp = new PopupNotifier();
            popp.ContentText = "https://www.instagram.com/alikperislam/?hl=tr";
            popp.BodyColor = Color.Red;
            popp.ContentColor = Color.White;
            popp.Image = Properties.Resources.ins;
            popp.Popup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupNotifier popp = new PopupNotifier();
            popp.ContentText = " +90 (000) 000 00 00";
            popp.BodyColor = Color.Lime;
            popp.ContentColor = Color.Black;
            popp.Image = Properties.Resources.wp;
            popp.Popup();
        }
    }
}
