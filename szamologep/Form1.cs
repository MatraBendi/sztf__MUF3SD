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
                    SzamoloGomb számolóGomb = new SzamoloGomb();
                    számolóGomb.Height = 20;
                    számolóGomb.Width = 20;
                    számolóGomb.Top = s * 20;
                    számolóGomb.Left = o * 20;

                    Controls.Add(számolóGomb);
                }
            }
        }
    }
}