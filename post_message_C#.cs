public class MyProgram
		{
            [DllImport("user32.dll", CharSet = CharSet.Unicode)]
            public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
 
            [DllImport("user32.dll")]
            public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
 
            public static void Keyboard()
            {
                IntPtr WindowName = FindWindow(null, "Battlefield 4");
                if (WindowName == IntPtr.Zero)
                {
                    MessageBox.Show("Game is not running."); return;
                }
 
                PostMessage(WindowName, 0x100, (IntPtr)Keys.W, IntPtr.Zero);
                System.Threading.Thread.Sleep(100);
                PostMessage(WindowName, 0x101, (IntPtr)Keys.W, IntPtr.Zero);
            }
        }
