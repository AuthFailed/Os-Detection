﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvDetection
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        async void Plavno()
        {
            for (Opacity = Opacity; Opacity > 0; Opacity -= .03)
            {
                await Task.Delay(5).ConfigureAwait(false);
            }
            Close();
        }

        async void Form2_Load(object sender, EventArgs e)
        {
            for (Opacity = 0; Opacity < .93; Opacity += .03)
            {
                await Task.Delay(5).ConfigureAwait(false);
            }
            await Task.Delay(1200);
            Plavno();
        }

        void Label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Form2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
