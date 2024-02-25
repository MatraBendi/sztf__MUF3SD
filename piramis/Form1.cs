namespace piramis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int sorokSzama = 10;
            int gombMeret = 60; // A gombok sz�less�ge �s magass�ga
            int maxGombokSzamaSorban = sorokSzama; // A legals� sorban l�v� maxim�lis gombok sz�ma

            for (int sor = 0; sor < sorokSzama; sor++)
            {
                int gombokSzamaEbbenASorban = sor + 1;
                int kezdoLeft = (this.Width - (gombokSzamaEbbenASorban * gombMeret)) / 2; // K�z�pre igaz�t�s

                for (int oszlop = 0; oszlop <= sor; oszlop++) // Csak a f��tl� alatti elemekhez
                {
                    Button b = new Button();
                    b.Top = sor * gombMeret;
                    b.Left = kezdoLeft + (oszlop * gombMeret); // M�dos�tva a k�z�pre igaz�t�shoz
                    b.Height = gombMeret;
                    b.Width = gombMeret;
                    this.Controls.Add(b);

                    int p = Faktorialis(sor) / (Faktorialis(oszlop) * Faktorialis(sor - oszlop));
                    b.Text = p.ToString();
                }
            }
        }

        int Faktorialis(int n)
        {
            int eredmeny = 1;
            for (int i = 1; i <= n; i++)
            {
                eredmeny *= i;
            }
            return eredmeny;
        }
    


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}