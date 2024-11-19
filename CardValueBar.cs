using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingCards
{
    internal class CardValueBar : ProgressBar
    {
        public event EventHandler ValueChanged;
        public Color ProgressBarColor { get; set; } = Color.Green;

        public CardValueBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics g = e.Graphics;

            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            rect.Inflate(-3, -3);

            if (Value > 0)
            {
                Rectangle clip = new Rectangle(rect.X, rect.Y, (int)Math.Round((float)rect.Width * ((float)this.Value / this.Maximum)), rect.Height);
                using (SolidBrush brush = new SolidBrush(ProgressBarColor))
                {
                    g.FillRectangle(brush, clip);
                }
            }
        }

        public new int Value
        {
            get => base.Value;
            set
            {
                if (base.Value != value)
                {
                    base.Value = value;
                    OnValueChanged(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
    }
}
