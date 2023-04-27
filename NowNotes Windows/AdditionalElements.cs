using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowNotes_Windows
{
	public class RoundButton : System.Windows.Forms.Button
	{
		GraphicsPath GetRoundPath(RectangleF Rect, int radius)
		{
			float r2 = radius / 2f;
			GraphicsPath GraphPath = new GraphicsPath();
			GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
			GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
			GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
			GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
			GraphPath.AddArc(Rect.X + Rect.Width - radius,
							 Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
			GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
			GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
			GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
			GraphPath.CloseFigure();
			return GraphPath;
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
			using (GraphicsPath GraphPath = GetRoundPath(Rect, 28))
			{
				this.Region = new Region(GraphPath);
			}
		}
	}
	public class ToolStripSystemRendererNoBorder : ToolStripSystemRenderer
	{

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			//base.OnRenderToolStripBorder(e);
		}

		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
		{
			if (e.Item.Pressed)
			{
				Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
				e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(32, 29, 27, 22)), rectangle);
			}
			else if (e.Item.Selected)
			{
				Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
				e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(20, 29, 27, 22)), rectangle);
			}
			else
			{
				base.OnRenderButtonBackground(e);
			}
		}

		protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
		{
			if (e.Item.Pressed)
			{
				Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
				e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(32, 29, 27, 22)), rectangle);
			}
			else if (e.Item.Selected)
			{
				Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
				e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(20, 29, 27, 22)), rectangle);
			}
			else
			{
				base.OnRenderDropDownButtonBackground(e);
			}
		}
	}
}
