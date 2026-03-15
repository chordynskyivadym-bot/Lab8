using System.Diagnostics;

namespace Lab8
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Stopwatch stopwatch = new Stopwatch();
        int countClick = 0;

        private void button1_Click(object sender, EventArgs e) {
            countClick++;

            if (countClick >= 10) {
                stopwatch.Stop();   
                double averageTime = stopwatch.Elapsed.TotalSeconds / 10.0;
                MessageBox.Show("Гра закінчена! Середній час реакції: " + Math.Round(averageTime, 3) + " секунд.");
                countClick = 0;
                stopwatch.Restart();
            }

            MoveButtonToRandomLocation();
        }

        private void Form1_Load(object sender, EventArgs e) {
            MoveButtonToRandomLocation();
            stopwatch.Start();
        }
        private void MoveButtonToRandomLocation() {
            int X = new Random().Next(0, ClientSize.Width - button1.Width);
            int Y = new Random().Next(0, ClientSize.Height - button1.Height);

            button1.Location = new Point(X,Y);
        }
    }
}
