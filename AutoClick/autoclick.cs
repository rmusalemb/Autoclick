using System; 
using System.Text; 
using System.Windows.Forms;
using System.Runtime.InteropServices;
 
namespace AutoClick
{
    public partial class autoclick : Form
    { 
        int inicia = 0;

        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);


        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }


        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        public autoclick()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public static void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        public static void SetCursorPosition(MousePoint point)
        {
            SetCursorPos(point.X, point.Y);
        }

        public static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        public static void MouseEvent(MouseEventFlags value)
        {
            MousePoint position = GetCursorPosition();
            mouse_event  ((int)value,  position.X,  position.Y,  0,   0)  ;
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            TimerClick.Stop();
            inicia = 0;
            
        }

        private void TimerClick_Tick(object sender, EventArgs e)
        {
            try
            {
                string Titulo = GetActiveWindowTitle();
                if (Titulo != null && (Titulo.Contains(TxtTitulo.Text)  ))//solo si la ventana asociada al texto corresponde, entonces habilita los clic, esto es para evitar que realice click sobre todas las ventanas
                {
                    inicia = 1;
                }
                else
                {
                    inicia = 0;
                }

                if (inicia == 1)
                {
                    if (radioclick.Checked)
                    {
                        MouseEvent(MouseEventFlags.LeftDown);
                        MouseEvent(MouseEventFlags.LeftUp);
                    }

                    if (radioButton1.Checked)
                    {
                        MouseEvent(MouseEventFlags.RightDown);
                        MouseEvent(MouseEventFlags.RightUp);
                    }

                    if (radioButton2.Checked)
                    {
                        MouseEvent(MouseEventFlags.MiddleDown);
                        MouseEvent(MouseEventFlags.MiddleUp);
                    }

                }
            }
            catch (Exception ex)
            {
                lblmsg.Text ="Notificaciones " + ex.Message;
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try { 
            if ((radioButton1.Checked || radioButton2.Checked || radioclick.Checked)&& (radioButton3.Checked || radioButton4.Checked || radioButton5.Checked) && !TxtTitulo.Text.Contains("AutoClick"))
            {
                    lblmsg.Text = "";
                TimerClick.Start();
                inicia = 1;
                 
                if (radioButton3.Checked)
                {
                    TimerClick.Interval = 100;
                }
                if (radioButton4.Checked)
                {
                    TimerClick.Interval = 50;
                }
                if (radioButton5.Checked)
                {
                    TimerClick.Interval = 10;
                }

            }
            else
            {
                    if(TxtTitulo.Text.Contains("AutoClick") || TxtTitulo.Text=="")
                        MessageBox.Show("Por favor selecciona un nombre de ventana diferente \n Please, must be select a different window title");
                    else
                        MessageBox.Show("Por favor selecciona las opciones de velocidad y tipo de click. \n  Please, must be select the speed option and select click type option");
            }
            }
            catch (Exception ex)
            {
                lblmsg.Text = "Notificaciones " + ex.Message;
            }

        }

        
    }
}
