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

            for (int j = 1; j < 11; j++)
            {
                for (int i = 1; i < 11; i++)
                {
                gyak b = new gyak();
                b.Width = 100;
                b.Height = 50;

                b.Left = ClientRectangle.Width /2 - 50;
                b.Top = ClientRectangle.Height /2 - 25;

                b.Text = (i*j).ToString();
                Controls.Add(b);
                }
            }
        }
    }
}