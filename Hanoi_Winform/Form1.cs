namespace Hanoi_Winform
{
    public partial class Form1 : Form
    {
        private string[] tower = { "tower10.jpg", "tower9.jpg", "tower8.jpg",
            "tower7.jpg", "tower6.jpg", "tower5.jpg", "tower4.jpg", "tower3.jpg",
            "tower2.jpg", "tower1.jpg" };
        
        public Form1()
        {
            InitializeComponent();

            comboBox_init();
            pictureBox_init();
        }

        private void comboBox_init()    // Add comboBox item
        {
            string[] floor = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }; // Ãþ ¼ö
            //string[] time = { };

            cb_floor.Items.Clear();
            cb_floor.Items.AddRange(floor);
        }

        private void pictureBox_init()
        {
            for(int i = 1; i <= 10; i++)
            {
                PictureBox? picture = (Controls.Find("picture_" + i.ToString(), true)[0] as PictureBox);
                picture.BackColor = Color.White;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = getImage(i - 1);
            }
        }

        private Image getImage(int idx)
        {
            return Image.FromFile(@"D:\2022_c_sharp\Virtual-HanoiTower\Hanoi_File\" + tower[idx])
                .GetThumbnailImage(250, 40, null, IntPtr.Zero);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_floor_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void cb_floor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb_time_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            int sel = cb_floor.SelectedIndex;

            
        }
    }
}