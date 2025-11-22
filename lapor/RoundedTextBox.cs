using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CustomControls
{
    public class RoundedTextBox : TextBox
    {
        // Fields
        private int borderRadius = 15;
        private int borderThickness = 2;
        private Color borderColor = Color.FromArgb(100, 100, 100);
        private Color focusBorderColor = Color.FromArgb(0, 120, 215);
        private bool isFocused = false;

        // Properties
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                UpdateRegion();
                Invalidate();
            }
        }

        public int BorderThickness
        {
            get { return borderThickness; }
            set
            {
                borderThickness = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public Color FocusBorderColor
        {
            get { return focusBorderColor; }
            set
            {
                focusBorderColor = value;
                Invalidate();
            }
        }

        // Constructor
        public RoundedTextBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.Padding = new Padding(8, 8, 8, 8);
            this.Font = new Font("Segoe UI", 10F);
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            // Set multiline untuk padding bekerja dengan baik
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        // Override Paint
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            // Background
            using (GraphicsPath path = GetRoundedRectangle(rect, borderRadius))
            {
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brush, path);
                }
            }

            // Border
            using (GraphicsPath path = GetRoundedRectangle(rect, borderRadius))
            {
                Color currentBorderColor = isFocused ? focusBorderColor : borderColor;
                using (Pen pen = new Pen(currentBorderColor, borderThickness))
                {
                    g.DrawPath(pen, path);
                }
            }

            // Draw text
            TextRenderer.DrawText(g, this.Text, this.Font,
                new Rectangle(this.Padding.Left, this.Padding.Top,
                    Width - this.Padding.Horizontal, Height - this.Padding.Vertical),
                this.ForeColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }

        // Override Resize
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        // Override Enter (Focus)
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            isFocused = true;
            Invalidate();
        }

        // Override Leave (Lost Focus)
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            isFocused = false;
            Invalidate();
        }

        // Override TextChanged
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        // Private Methods
        private void UpdateRegion()
        {
            if (borderRadius > 0)
            {
                IntPtr hRgn = CreateRoundRectRgn(0, 0, Width, Height, borderRadius, borderRadius);
                this.Region = Region.FromHrgn(hRgn);
                DeleteObject(hRgn);
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // Top-left arc
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);

            // Top-right arc
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);

            // Bottom-right arc
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);

            // Bottom-left arc
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }

        // Windows API
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);

        // Override untuk dispose
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.Region != null)
                {
                    this.Region.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}