namespace szamologep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int s = 0; s < 10; s++)
            {
                for (int o = 0; o < 10; o++)
                {
                    SzamoloGomb sz�mol�Gomb = new SzamoloGomb();
                    sz�mol�Gomb.Height = 20;
                    sz�mol�Gomb.Width = 20;
                    sz�mol�Gomb.Top = s * 20;
                    sz�mol�Gomb.Left = o * 20;

                    Controls.Add(sz�mol�Gomb);
                }
            }
        }
    }
}