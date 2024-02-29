namespace gyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            { 
                for (int j = 1; j <= 10; j++)
                {
                    gyak b = new gyak();
                    b.Width = 100;
                    b.Height = 50;

                    b.Left = i * 110;
                    b.Top = j * 55;

                    b.Text = (i*j).ToString();
                    Controls.Add(b);
                }
            }
        }
    }
}