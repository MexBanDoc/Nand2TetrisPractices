using System;
using System.Runtime.InteropServices;
using System.Threading;
// using System.Windows.Forms;

namespace WinApiExample 
{
    internal class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out POINT point);
        
        [StructLayout(LayoutKind.Sequential)]
        struct POINT
        {
            public Int32 X;
            public Int32 Y;
        }
        
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetCursorPos(int x, int y);
        
        [STAThread]
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(10);
                GetCursorPos(out var point);
                // var point = Control.MousePosition;
                point.X += (int) (5 * Math.Cos(i * 0.05));
                point.Y += (int) (5 * Math.Sin(i * 0.05));
                // Cursor.Position = point;
                SetCursorPos(point.X, point.Y);

            }
        }
    }
}