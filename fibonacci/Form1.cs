namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
                List<Elem>elemek = new List<Elem>();
                for (int i = 0; i <= 10; i++)
                {
                for (int j = 0; j <= 10; j++)
                {
                   
                    Elem e = new Elem(i,i*j); 
                    elemek.Add(e);
                    dataGridView1.DataSource = elemek;

                    // Button b = new Button();
                    // b.Text = (i * j).ToString();
                    // b.Left = 100 * i;
                    // b.Top = 100 * j;

                    //Controls.Add(b);
                }
            }
                


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}