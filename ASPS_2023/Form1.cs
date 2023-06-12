namespace ASPS_2023
{
    public partial class Form1 : Form
    {
        Form2 fr2 = new Form2();
        String fullPath = Application.StartupPath.ToString();
        public Form1()
        {
            InitializeComponent();
        }
        private void showForm2()
        {
            Screen[] sc;
            sc = Screen.AllScreens;
            if (sc.Length > 1)
            {
                fr2.FormBorderStyle = FormBorderStyle.Sizable;
                fr2.Left = sc[1].Bounds.Width;
                fr2.Top = sc[1].Bounds.Height;
                fr2.StartPosition = FormStartPosition.Manual;
                fr2.Location = sc[1].Bounds.Location;
                Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
                fr2.Location = p;
                fr2.WindowState = FormWindowState.Maximized;
                fr2.Show();
            }
            else
            {
                MessageBox.Show("Не подсоеденен второй монитор !!!", "Пиздец", MessageBoxButtons.YesNo);

            }
        }
        private void button_add_sportsmen_Click(object sender, EventArgs e)
        {
            fr2.label_red_name.Text = " ";
            fr2.label_blue_name.Text = " ";
            showForm2();
        }

        private void button_timer_start_Click(object sender, EventArgs e)
        {
            fr2.timer1.Enabled = true;

        }

        private void button_add_file_weigth_Click(object sender, EventArgs e)
        {
            string[] files = new DirectoryInfo(fullPath).GetFiles("*.txt", SearchOption.AllDirectories)
            .Select(f => f.Name).ToArray();
            this.listBox_files_weigt.Items.AddRange(files);
        }
    }
}