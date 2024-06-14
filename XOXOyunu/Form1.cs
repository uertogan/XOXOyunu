namespace XOXOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ButonlariKapat();
            btnYenidenBaslat.Enabled = false;

        }
        Random rnd = new Random();
        List<string> XOList = new List<string>() { "X", "O" };
        List<string> OyuncuSirasiListesi = new List<string>() { "Oyun Sýrasý: 1. Oyuncu", "Oyun Sýrasý: 2. Oyuncu" };
        string secilen1;
        string secilen2;
        private void ButonlariKapat()
        {
            btnS1K1.Enabled = false;
            btnS1K2.Enabled = false;
            btnS1K3.Enabled = false;
            btnS2K1.Enabled = false;
            btnS2K2.Enabled = false;
            btnS2K3.Enabled = false;
            btnS3K1.Enabled = false;
            btnS3K2.Enabled = false;
            btnS3K3.Enabled = false;
        }
        private void ButonlariAc()
        {
            btnS1K1.Enabled = true;
            btnS1K2.Enabled = true;
            btnS1K3.Enabled = true;
            btnS2K1.Enabled = true;
            btnS2K2.Enabled = true;
            btnS2K3.Enabled = true;
            btnS3K1.Enabled = true;
            btnS3K2.Enabled = true;
            btnS3K3.Enabled = true;
        }
        private void OyunuYenidenBaslat()
        {
            btnS1K1.Enabled = true;
            btnS1K2.Enabled = true;
            btnS1K3.Enabled = true;
            btnS2K1.Enabled = true;
            btnS2K2.Enabled = true;
            btnS2K3.Enabled = true;
            btnS3K1.Enabled = true;
            btnS3K2.Enabled = true;
            btnS3K3.Enabled = true;

            btnS1K1.Text = string.Empty;
            btnS1K2.Text = string.Empty;
            btnS1K3.Text = string.Empty;
            btnS2K1.Text = string.Empty;
            btnS2K2.Text = string.Empty;
            btnS2K3.Text = string.Empty;
            btnS3K1.Text = string.Empty;
            btnS3K2.Text = string.Empty;
            btnS3K3.Text = string.Empty;

            lblOyuncuSirasi.Text = "Oyuncu Sýrasý: ";

            lblOyuncu1.Text = "1. Oyuncu:";
            lblOyuncu1.BackColor = Control.DefaultBackColor;
            lblOyuncu2.Text = "2. Oyuncu:";
            lblOyuncu2.BackColor = Control.DefaultBackColor;


            btnXOSec.Enabled = true;

            lblKazanan.Text = "Kazanan: ";
            lblKazanan.BackColor = Control.DefaultBackColor;
        }
        private void KazananOluncaYap()
        {
            if (lblKazanan.Text == "Kazanan: 1. Oyuncu ")
                lblKazanan.BackColor = Color.Red;
            else if (lblKazanan.Text == "Kazanan: 2. Oyuncu ")
                lblKazanan.BackColor = Color.Blue;
            else
                lblKazanan.BackColor = Color.Green;

            ButonlariKapat();
            btnYenidenBaslat.Enabled = true;
        }
        private void btnXOSec_Click(object sender, EventArgs e)
        {
            secilen1 = XOList[rnd.Next(0, 2)];

            if (XOList[0] == secilen1)
                secilen2 = XOList[1];
            else
                secilen2 = XOList[0];

            lblOyuncu1.Text = "1. Oyuncu: " + secilen1;
            lblOyuncu1.BackColor = Color.Red;
            lblOyuncu2.Text = "2. Oyuncu: " + secilen2;
            lblOyuncu2.BackColor = Color.Blue;

            lblOyuncuSirasi.Text = OyuncuSirasiListesi[0];

            btnXOSec.Enabled = false;
            btnXOSec.BackColor = Control.DefaultBackColor;
            ButonlariAc();
        }

        private void XOTiklama_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (lblOyuncuSirasi.Text == OyuncuSirasiListesi[0])
            {
                bt.Text = secilen1;
                bt.Enabled = false;
                lblOyuncuSirasi.Text = OyuncuSirasiListesi[1];
            }
            else
            {
                bt.Text = secilen2;
                bt.Enabled = false;
                lblOyuncuSirasi.Text = OyuncuSirasiListesi[0];
            }

            if (btnS1K1.Text == secilen1 && btnS1K2.Text == secilen1 && btnS1K3.Text == secilen1)
            {
                lblKazanan.Text = "Kazanan: 1. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K1.Text == secilen2 && btnS1K2.Text == secilen2 && btnS1K3.Text == secilen2)
            {
                lblKazanan.Text = "Kazanan: 2. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS2K1.Text == secilen1 && btnS2K2.Text == secilen1 && btnS2K3.Text == secilen1)
            {
                lblKazanan.Text = "Kazanan: 1. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS2K1.Text == secilen2 && btnS2K2.Text == secilen2 && btnS2K3.Text == secilen2)
            {
                lblKazanan.Text = "Kazanan: 2. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS3K1.Text == secilen1 && btnS3K2.Text == secilen1 && btnS3K3.Text == secilen1)
            {
                lblKazanan.Text = "Kazanan: 1. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS3K1.Text == secilen2 && btnS3K2.Text == secilen2 && btnS3K3.Text == secilen2)
            {
                lblKazanan.Text = "Kazanan: 2. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K1.Text == secilen1 && btnS2K1.Text == secilen1 && btnS3K1.Text == secilen1)
            {
                lblKazanan.Text = "Kazanan: 1. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K1.Text == secilen2 && btnS2K1.Text == secilen2 && btnS3K1.Text == secilen2)
            {
                lblKazanan.Text = "Kazanan: 2. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K2.Text == secilen1 && btnS2K2.Text == secilen1 && btnS3K2.Text == secilen1)
            {
                lblKazanan.Text = "Kazanan: 1. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K2.Text == secilen2 && btnS2K2.Text == secilen2 && btnS3K2.Text == secilen2)
            {
                lblKazanan.Text = "Kazanan: 2. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K3.Text == secilen1 && btnS2K3.Text == secilen1 && btnS3K3.Text == secilen1)
            {
                lblKazanan.Text = "Kazanan: 1. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K3.Text == secilen2 && btnS2K3.Text == secilen2 && btnS3K3.Text == secilen2)
            {
                lblKazanan.Text = "Kazanan: 2. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K1.Text == secilen1 && btnS2K2.Text == secilen1 && btnS3K3.Text == secilen1)
            {
                lblKazanan.Text = "Kazanan: 1. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K1.Text == secilen2 && btnS2K2.Text == secilen2 && btnS3K3.Text == secilen2)
            {
                lblKazanan.Text = "Kazanan: 2. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K3.Text == secilen1 && btnS2K2.Text == secilen1 && btnS3K1.Text == secilen1)
            {
                lblKazanan.Text = "Kazanan: 1. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K3.Text == secilen2 && btnS2K2.Text == secilen2 && btnS3K1.Text == secilen2)
            {
                lblKazanan.Text = "Kazanan: 2. Oyuncu ";
                KazananOluncaYap();
            }
            else if (btnS1K1.Enabled == false && btnS2K1.Enabled == false && btnS3K1.Enabled == false && btnS1K2.Enabled == false && btnS2K2.Enabled == false && btnS3K2.Enabled == false && btnS1K3.Enabled == false && btnS2K3.Enabled == false && btnS3K3.Enabled == false)
            {
                lblKazanan.Text = "Kazanan: Berabere";
                KazananOluncaYap();
            }
        }

        private void btnYenidenBaslat_Click(object sender, EventArgs e)
        {
            OyunuYenidenBaslat();
            btnYenidenBaslat.Enabled = false;
            btnXOSec.BackColor = Color.Orange;
            ButonlariKapat();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
