using Microsoft.VisualBasic.Devices;

namespace Norex_Mouse_Mover_Extend_AFK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void StartMoving()
        {
            timer1.Start();
        }
        private void StopMoving()
        {
            timer1.Stop();
        }
        bool Start = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Start)
            {
                StartMoving();
                Start = true;
            }
            else
            {
                StopMoving();
                Start = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey(Keys.K, KeyModifiers.Control | KeyModifiers.Alt);
        }
    }
}