using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //drop target
            pictureBox4.AllowDrop = true;
            lblDropHere.Visible = false;
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            lblDropHere.Visible = true;

            if(e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox4_DragLeave(object sender, EventArgs e)
        {
            lblDropHere.Visible = false;
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            lblDropHere.Visible = false;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox4.Image = getPicture;
        }
    }
}
