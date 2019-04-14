using System;
using System.Collections.Generic;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Environment_Detection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async void Form1_Load(object sender, EventArgs e)
        {
            osinfo();
            procmodel();
            razryad();
            proccount();
            path();
            name();
            for (Opacity = 0; Opacity < .95; Opacity += .03)
            {
                await Task.Delay(5);
            }
            button1.Enabled = true;
        }

        async void osinfo()
        {

            char[] ch_osversion = ("Операционная система: " + Environment.OSVersion.ToString()).ToCharArray();
            foreach (char chars in ch_osversion)
            {
                label2.Text += chars;
                await Task.Delay(12);
            }
            button2.Enabled = true;
        }

        async void procmodel()
        {
            char[] ch_procmodel = ("Модель процессора: " + Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")).ToCharArray();
            foreach(char chars in ch_procmodel)
            {
                label3.Text += chars;
                await Task.Delay(12);
            }
            button3.Enabled = true;
        }   

        async void razryad()
        {
            char[] ch_procmodel = ("Разрядность: " + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")).ToCharArray();
            foreach (char chars in ch_procmodel)
            {
                label4.Text += chars;
                await Task.Delay(12);
            }
            button4.Enabled = true;
        }

        async void proccount()
        {
            char[] ch_proccount = ("Число процессоров: " + Environment.ProcessorCount.ToString()).ToCharArray();
            foreach (char chars in ch_proccount)
            {
                label5.Text += chars;
                await Task.Delay(12);
            }
            button5.Enabled = true;
        }
        async void path()
        {
            char[] ch_path = ("Путь к системному каталогу: " + Environment.SystemDirectory).ToCharArray();
            foreach (char chars in ch_path)
            {
                label6.Text += chars;
                await Task.Delay(12);
            }
            button6.Enabled = true;
        }
        async void name()
        {
            char[] ch_name = (("Имя пользователя: " + Environment.UserName).ToCharArray());
            foreach (char chars in ch_name)
            {
                label7.Text += chars;
                await Task.Delay(12);
            }
            button7.Enabled = true;
        }

        void Button2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label2.Text);
        }

        void Button3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label3.Text);
        }

        void Button4_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label4.Text);
        }

        void Button5_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label5.Text);
        }

        void Button6_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label6.Text);
        }

        void Button7_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label7.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label2.Text + "\n" + label3.Text + "\n" + label4.Text + "\n" + label5.Text + "\n" + label6.Text + "\n" +label7.Text);
        }
    }
}