namespace pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            int size = 10;
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col <= row; col++)
                    {
                        Button b = new Button();
                        b.Top = row * 60;
                        b.Left = col * 60;
                        b.Height = 60;
                        b.Width = 60;
                        this.Controls.Add(b);

                        int p = Faktorialis(row) / (Faktorialis(col) * (Faktorialis(row - col)));
                        b.Text = p.ToString();
                    }
                }
            }

            int Faktorialis(int n)
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                    result *= i;

                return result;
            }

            int Faktorialis2(int n)
            {
                if (n == 0) return 1;
                return n * Faktorialis2(n - 1);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
