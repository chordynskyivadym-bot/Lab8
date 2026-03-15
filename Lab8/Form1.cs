namespace Lab8
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int maxCountClick = 10;
            for (int i = 0; i < maxCountClick; i++) {
                int RandomX = new Random().Next(75, 1205);
                int RandomY = new Random().Next(50, 600);
                button1.Location = new Point(RandomX, RandomY);
            }
        }
    }
}
