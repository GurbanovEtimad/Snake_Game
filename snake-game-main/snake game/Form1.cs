namespace snake_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        int istiqamət = 0;
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            count = 0;
            label2.Text = count.ToString();
            timer1.Tick += timer1_Tick;
            int x = r.Next(0, (panel1.Width - food.Width) / 10) * 10;
            int y = r.Next(0, (panel1.Height - food.Height) / 10) * 10;
            food.Location = new Point(x, y);
            timer1.Interval = 150;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = snake.Location;
            if (istiqamət == 1) p.Y -= 10;
            else if (istiqamət == 2) p.Y += 10;
            else if (istiqamət == 3) p.X -= 10;
            else if (istiqamət == 4) p.X += 10;
            snake.Location = p;
            if (snake.Left < 0 || snake.Top < 0 ||
                snake.Right > panel1.Width || snake.Bottom > panel1.Height)
            {
                timer1.Stop();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            if (snake.Bounds.IntersectsWith(food.Bounds))
            {
                count++;
                label2.Text = count.ToString();

                if (istiqamət == 1 || istiqamət == 2)
                    snake.Height += 10;
                else
                    snake.Width += 10;
                int x = r.Next(0, (panel1.Width - food.Width) / 10) * 10;
                int y = r.Next(0, (panel1.Height - food.Height) / 10) * 10;
                food.Location = new Point(x, y);
            }
        }
        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (istiqamət != 2)
                istiqamət = 1;
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (istiqamət != 1)
                istiqamət = 2;
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (istiqamət != 4)
                istiqamət = 3;
        }
        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (istiqamət != 3)
                istiqamət = 4;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Oyundan çıxış edilsinmi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}