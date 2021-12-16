using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPark.Entity
{
    public class ExtComboBox : ComboBox
    {
        private const int WM_PAINT = 0xF;
        const uint RDW_INVALIDATE = 0x1;
        const uint RDW_IUPDATENOW = 0x100;
        const uint RDW_FRAME = 0x400;
        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
        public static Color COLOR_DEFAULT { get { return Color.FromArgb(122, 122, 122); } }

        public ExtComboBox() {
            borderColor = COLOR_DEFAULT;
            IsValid = true;
        }

        private bool isValid;
        public bool IsValid
        {
            get { return isValid; }
            set
            {
                isValid = value;
                ReDraw();
            }
        }

        private Color invalidBorderColor = Color.Red;

        private Color borderColor = COLOR_DEFAULT;
        public Color BorderColor
        {
            get { return IsValid ? borderColor : invalidBorderColor; }
            set
            {
                borderColor = value;
                ReDraw();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT && DropDownStyle != ComboBoxStyle.Simple)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(BorderColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);                       
                    }
                }
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ReDraw();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ReDraw();
        }

        private void ReDraw()
        {
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                    RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
        }
    }
}

