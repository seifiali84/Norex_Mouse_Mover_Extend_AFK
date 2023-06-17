using Microsoft.VisualBasic.Devices;
using System.Net;
using System.Runtime.InteropServices;

namespace Norex_Mouse_Mover_Extend_AFK
{
    public partial class Form1 : Form
    {
   //     private static IntPtr hookId = IntPtr.Zero;

   //     private delegate IntPtr LowLevelKeyboardProc(
   //int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

   //     [StructLayout(LayoutKind.Sequential)]
   //     private struct KBDLLHOOKSTRUCT
   //     {
   //         public Keys vkCode;
   //         public uint scanCode;
   //         public uint flags;
   //         public uint time;
   //         public UIntPtr dwExtraInfo;
   //     }
   //     [DllImport("user32.dll", SetLastError = true)]
   //     private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

   //     [DllImport("kernel32.dll")]
   //     private static extern IntPtr GetModuleHandle(string lpModuleName);

   //     [DllImport("user32.dll", CharSet = CharSet.Auto,
   //                CallingConvention = CallingConvention.StdCall)]
   //     private static extern bool PostMessage(IntPtr hwnd, int msg,
   //                                            IntPtr wparam,
   //                                            IntPtr lparam);

   //     [DllImport("user32.dll", CharSet = CharSet.Auto,
   //                 CallingConvention = CallingConvention.StdCall)]
   //     private static extern bool SendMessage(IntPtr hwnd, int msg,
   //                                             int wparam, int lparam);
   //     [DllImportAttribute("user32.dll")]
   //     private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn,
   //                                       IntPtr hMod, uint dwThreadId);


   //     [DllImportAttribute("User32.dll")]
   //     public static extern IntPtr FindWindow(String ClassName, String WindowName);

   //     [DllImportAttribute("user32.dll")]
   //     public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

   //     [DllImportAttribute("user32.dll")]
   //     public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

   //     const int WH_KEYBOARD_LL = 13;
   //     const int WM_HOTKEY = 0x0312;
   //     [DllImport("user32.dll", SetLastError = true)]
   //     private static extern bool RegisterHotKey(IntPtr hWnd,
   //             int id, KeyModifiers fsModifiers, Keys vk);
   //     [DllImport("user32.dll", SetLastError = true)]
   //     private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
   //                                                 IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);
   //     private IntPtr HookCallback(
   //         int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam)
   //     {
   //         // Check if the hotkey was pressed
   //         if (nCode >= 0 && wParam == (IntPtr)WM_HOTKEY)
   //         {
   //             Console.WriteLine("Hotkey pressed: " + lParam.vkCode);

   //             // Call the ClickButton function here
   //             button1.PerformClick();
   //         }

   //         // Pass the message along to other applications
   //         return CallNextHookEx(hookId, nCode, wParam, ref lParam);
   //     }
   //     [DllImport("kernel32.dll", SetLastError = true)]
   //     private static extern short GlobalAddAtom(string lpString);

   //     [DllImport("kernel32.dll", SetLastError = true)]
   //     private static extern short GlobalDeleteAtom(short nAtom);

   //     const string AtomPrefix = "MyApp";

   //     private static int GenerateUniqueId()
   //     {
   //         // Generate a random suffix for our atom name
   //         string suffix = Guid.NewGuid().ToString("N");

   //         // Concatenate the prefix and suffix to create our unique atom name
   //         string atomName = $"{AtomPrefix}_{suffix}";

   //         // Add the atom to the global atom table
   //         short atomId = GlobalAddAtom(atomName);

   //         if (atomId == 0)
   //             throw new InvalidOperationException($"Couldn't add global atom: {Marshal.GetLastWin32Error()}");

   //         return (int)atomId;
   //     }
   //     private void RegisterHotKey(Keys key,
   //                                        KeyModifiers modifiers = KeyModifiers.None)
   //     {
   //         // Generate a unique ID for our hotkey
   //         int id = GenerateUniqueId();

   //         bool success = RegisterHotKey(IntPtr.Zero, id,
   //             modifiers | KeyModifiers.NoRepeat, key);

   //         if (!success)
   //             throw new InvalidOperationException("Couldn't register hotkey");

   //         hookId = SetWindowsHookEx(WH_KEYBOARD_LL,
   //                                   HookCallback,
   //                                   GetModuleHandle(System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName),
   //                                   0);
   //     }


   //     [Flags]
   //     public enum KeyModifiers : uint
   //     {
   //         None = 0x0000,
   //         Alt = 0x0001,
   //         Control = 0x0002,

   //         // ... add any additional modifiers you need here

   //         NoRepeat = 0x4000
   //     }

   //     public enum Keys : uint
   //     {

   //         // ... add all of your desired keys here

   //         K = 75,
   //         F10 = 121,

   //         // ... and so on

   //     }

   //     public enum WM
   //     {
   //         COMMAND = 0x0111,
   //         HOTKEY = 0x0312,
   //     }

   //     const int ID_CLICK_BUTTON = 100;
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
                button1.Text = "Stop";
            }
            else
            {
                StopMoving();
                Start = false;
                button1.Text = "Start";
            }
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            Cursor.Position = new Point((num%4)*100 , (num % 4)*100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  RegisterHotKey(Keys.F10 , KeyModifiers.Control | KeyModifiers.Alt);
        }
    }
}