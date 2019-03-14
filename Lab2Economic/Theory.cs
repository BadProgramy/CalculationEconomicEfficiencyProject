using Lab2Economic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Economic
{
    public partial class Theory : Form
    {
        public Theory()
        {
            InitializeComponent();
        }

        private void Theorycs_Load(object sender, EventArgs e)
        {
            
        }

        public void setPicture(Bitmap picture)
        {
            Width = 1033;
            Height = 545;
            if (Width > picture.Width)
                Width = picture.Width + 17;
            
            if (Height > picture.Height)
                Height = picture.Height + 40;
            


            pictureBox1.Image = picture;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
