using EnvDetection;
using System;
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
            OsinfoAsync();
            ProcmodelAsync();
            RazryadAsync();
            ProccountAsync();
            PathAsync();
            UsernameAsync();
            for (Opacity = 0; Opacity < .95; Opacity += .03)
            {
                await Task.Delay(5).ConfigureAwait(false);
            }
            await Task.Delay(800).ConfigureAwait(false);
            button1.Enabled = true;
        }

        // Узнаем версию операционной системы
        async void OsinfoAsync()
        {
            char[] ch_osversion = ("Операционная система: " + Environment.OSVersion.ToString()).ToCharArray();
            foreach (char chars in ch_osversion)
            {
                label2.Text += chars;
                await Task.Delay(12);
            }
            button2.Enabled = true;
        }

        // Узнаем модель процессора
        async void ProcmodelAsync()
        {
            char[] ch_procmodel = ("Модель процессора: " + Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")).ToCharArray();
            foreach(char chars in ch_procmodel)
            {
                label3.Text += chars;
                await Task.Delay(12);
            }
            button3.Enabled = true;
        }   
        
        // Узнаем разрядность
        async void RazryadAsync()
        {
            char[] ch_procmodel = ("Разрядность: " + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")).ToCharArray();
            foreach (char chars in ch_procmodel)
            {
                label4.Text += chars;
                await Task.Delay(12);
            }
            button4.Enabled = true;
        }

        // Узнаем кол-во ядер
        async void ProccountAsync()
        {
            char[] ch_proccount = ("Кол-во ядер: " + Environment.ProcessorCount.ToString()).ToCharArray();
            foreach (char chars in ch_proccount)
            {
                label5.Text += chars;
                await Task.Delay(12);
            }
            button5.Enabled = true;
        }
        
        // Узнаем путь к системному каталогу
        async void PathAsync()
        {
            char[] ch_path = ("Путь к системному каталогу: " + Environment.SystemDirectory).ToCharArray();
            foreach (char chars in ch_path)
            {
                label6.Text += chars;
                await Task.Delay(12);
            }
            button6.Enabled = true;
        }

        // Узнаем имя пользователя
        async void UsernameAsync()
        {
            char[] ch_name = (("Имя пользователя: " + Environment.UserName).ToCharArray());
            foreach (char chars in ch_name)
            {
                label7.Text += chars;
                await Task.Delay(12);
            }
            button7.Enabled = true;
        }

        void Notification()
        {
        Form2 childForm = new Form2();
        childForm.Show();
            Activate();
        }

        void Button2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label2.Text);
            Notification();
        }

        void Button3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label3.Text);
            Notification();
        }

        void Button4_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label4.Text);
            Notification();
        }

        void Button5_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label5.Text);
            Notification();
        }

        void Button6_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label6.Text);
            Notification();
        }

        void Button7_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label7.Text);
            Notification();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(label2.Text + "\n" + label3.Text + "\n" + label4.Text + "\n" + label5.Text + "\n" + label6.Text + "\n" +label7.Text);
            Notification();
        }
    }
}