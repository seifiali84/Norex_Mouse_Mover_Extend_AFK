using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;

namespace Norex_Mouse_Mover_Extend_AFK
{
    public partial class Form1 : Form
    {
        private delegate IntPtr LowLevelKeyboardProc(
   int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys vkCode;
            public uint scanCode;
            public uint flags;
            public uint time;
            public UIntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd,
                int id, KeyModifiers fsModifiers, Keys vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", CharSet = CharSet.Auto,
                   CallingConvention = CallingConvention.StdCall)]
        private static extern bool PostMessage(IntPtr hwnd, int msg,
                                                IntPtr wparam,
                                                IntPtr lparam);

        [DllImport("user32.dll", CharSet = CharSet.Auto,
                    CallingConvention = CallingConvention.StdCall)]
        private static extern bool SendMessage(IntPtr hwnd, int msg,
                                               int wparam, int lparam);

        [DllImportAttribute("User32.dll")]
        private static extern IntPtr FindWindow(String ClassName, String WindowName);


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