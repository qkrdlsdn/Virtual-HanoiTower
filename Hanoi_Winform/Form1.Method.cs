using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_Winform
{
    public partial class Form1 : Form
    {
        private string[] tower = { "tower10.jpg", "tower9.jpg", "tower8.jpg",
            "tower7.jpg", "tower6.jpg", "tower5.jpg", "tower4.jpg", "tower3.jpg",
            "tower2.jpg", "tower1.jpg" };

        private string imagePath = @"D:\2022_c_sharp\Virtual-HanoiTower\Hanoi_File\";
        private string textPath = @"D:\2022_c_sharp\Virtual-HanoiTower\Hanoi_File\Hanoi.txt";

        private string[] hanoiText = new string[] { };

        private void comboBox_init()    // Add comboBox item
        {
            string[] floor = { "3", "4", "5", "6", "7", "8", "9", "10" }; // 층 수
            string[] time = { "1", "2", "4", "6", "8", "10"};

            cb_floor.Items.Clear();
            cb_floor.Items.AddRange(floor);

            cb_time.Items.Clear();
            cb_time.Items.AddRange(time);
        }

        public void pictureBox_init()
        {
            for (int i = 1; i <= 10; i++)
            {
                PictureBox? picture = controlArray<PictureBox>("picture_", i);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = getImage(i - 1);
            }
        }

        public void clearPictureBox(string key)
        {
            for (int i = 1; i <= 10; i++)
            {
                PictureBox? picture = controlArray<PictureBox>(key, i);
                picture.Image = null;
            }
        }

        protected T? controlArray<T>(string key, int idx) where T : class
        {
            if (idx <= 0)
                return (Controls.Find(key + 1, true)[0] as T);

            T? con = (Controls.Find(key + idx.ToString(), true)[0] as T);
            return con;
        }

        public Image? getImage(int idx)
        {
            return Image.FromFile(imagePath + tower[idx])
                .GetThumbnailImage(250, 40, null, IntPtr.Zero);
        }

        public int topPictureIndex(string key)
        {
            for(int i = 1; i <= 10; i++)
            {
                PictureBox? box = controlArray<PictureBox>(key, i);
                if(box.Image == null)
                {
                    return i-1;
                }
            }

            return 10;
        }

        private int[] textPassing(int line)
        {
            string[] spstr = hanoiText[line].Split("\t");
            int[] result = Array.ConvertAll(hanoiText[line].Split("\t"), (e) => int.Parse(e));

            return result;
        }

        private void writeProcess(int[] process, int DiskNum, int count)
        {
            string text = count + "/" + (Math.Pow(2, DiskNum)-1);

            textBox.Text = text;

            tb_A.Text = process[3].ToString();
            tb_B.Text = process[4].ToString();
            tb_C.Text = process[5].ToString();
        }

        private void rangeOfHanoi(int DiskNum, out int start, out int end)
        {
            int skip = 0;

            if (DiskNum == 3)
            {
                start = 0; end = 7;
                return;
            }

            for(int i = 3; i < DiskNum; i++)
            {
                skip += (((int)Math.Pow(2, i))-1);
            }

            start = skip;   end = (skip-1) + (int)Math.Pow(2, DiskNum);
        }
    }
}
