using System;
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

        async void ПлавноВыкл()
        {
            for (Opacity = Opacity; Opacity > 0; Opacity -= .02)
            {
                await Task.Delay(2).ConfigureAwait(false);
            }
            Close();
        }

        async void ПлавноВкл()
        {
            for (Opacity = 0; Opacity < .93; Opacity += .02)
            {
                await Task.Delay(2).ConfigureAwait(false);
            }
        }

        async void Form2_Load(object sender, EventArgs e)
        {
            ПлавноВкл();
            await Task.Delay(1200);
            ПлавноВыкл();
        }

        void PictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
