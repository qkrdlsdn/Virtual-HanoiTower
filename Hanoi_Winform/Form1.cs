namespace Hanoi_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if (cb_time == null || cb_floor == null)
            {
                btn_move.Enabled = false;
            }

            int sel_floor = cb_floor.SelectedIndex;
            sel_floor += 3;

            textBox.Text = 0 + "/" + (Math.Pow(2, sel_floor)-1);

            pictureBox_init();

            for (int i = 10; i > 10 - sel_floor; i--)
            {
                PictureBox? picture = controlArray<PictureBox>("picture_", i);
                picture.Image = null;
            }

            clearPictureBox("pb_A_");
            clearPictureBox("pb_B_");
            clearPictureBox("pb_C_");

            for (int i = 1; i <= sel_floor; i++)
            {
                PictureBox? pb_A = controlArray<PictureBox>("pb_A_", i);
                pb_A.Image = getImage(10 - (sel_floor - (i - 1)));
            }
        }

        private void cb_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_time == null || cb_floor == null)
            {
                btn_move.Enabled = false;
            }
        }

        private async void btn_move_Click(object sender, EventArgs e)
        {
            int sel_floor = cb_floor.SelectedIndex + 3;
            string[] pole = { "pb_A_", "pb_B_", "pb_C_" };
            int gap_time = 50 * int.Parse((string)cb_time.SelectedItem);
            int start = 0, end = 0, count = 1;
            PictureBox? picture1, picture2;

            if ((int.Parse((string)cb_time.SelectedItem)) == 1)
                gap_time = 10;

            if (sel_floor < 3)
            {
                textBox.Text = "층 수를 선택하지 않았습니다.";
            }

            new EventHandler(cb_floor_SelectedIndexChanged)?.Invoke(this, e);

            rangeOfHanoi(sel_floor, out start, out end);

            for(int i = start; i < end; i++)
            {
                int[] hanoi_process = textPassing(i);

                writeProcess(hanoi_process, sel_floor, count);

                picture2 = controlArray<PictureBox>
                    (pole[hanoi_process[2]], topPictureIndex(pole[hanoi_process[2]]) + 1);

                picture1 = controlArray<PictureBox>
                    (pole[hanoi_process[1]], topPictureIndex(pole[hanoi_process[1]]));
            
                picture2.Image = picture1.Image;

                picture1.Image = null;

                await Task.Delay(gap_time);
                count++;
            }
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