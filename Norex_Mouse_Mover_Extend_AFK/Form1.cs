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

        }
        private void StopMoving()
        {

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
    }
}