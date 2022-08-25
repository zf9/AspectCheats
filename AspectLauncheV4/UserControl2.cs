using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AspectLauncheV4
{
	// Token: 0x0200000E RID: 14
	public class UserControl2 : Button
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000596E File Offset: 0x00003B6E
		public UserControl2()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000597C File Offset: 0x00003B7C
		private GraphicsPath GetRoundPath(RectangleF Rect, int radius)
		{
			float num = 2.75f;
			float num2 = (float)radius / 2f;
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(Rect.X + num, Rect.Y + num, (float)radius, (float)radius, 180f, 90f);
			graphicsPath.AddLine(Rect.X + num2 + num, Rect.Y + num, Rect.Width - num2 - num, Rect.Y + num);
			graphicsPath.AddArc(Rect.X + Rect.Width - (float)radius - num, Rect.Y + num, (float)radius, (float)radius, 270f, 90f);
			graphicsPath.AddLine(Rect.Width - num, Rect.Y + num2, Rect.Width - num, Rect.Height - num2 - num);
			graphicsPath.AddArc(Rect.X + Rect.Width - (float)radius - num, Rect.Y + Rect.Height - (float)radius - num, (float)radius, (float)radius, 0f, 90f);
			graphicsPath.AddLine(Rect.Width - num2 - num, Rect.Height - num, Rect.X + num2 - num, Rect.Height - num);
			graphicsPath.AddArc(Rect.X + num, Rect.Y + Rect.Height - (float)radius - num, (float)radius, (float)radius, 90f, 90f);
			graphicsPath.AddLine(Rect.X + num, Rect.Height - num2 - num, Rect.X + num, Rect.Y + num2 + num);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005B20 File Offset: 0x00003D20
		protected override void OnPaint(PaintEventArgs e)
		{
			int radius = 30;
			float width = 0.1f;
			base.OnPaint(e);
			RectangleF rect = new RectangleF(0f, 0f, (float)base.Width, (float)base.Height);
			GraphicsPath roundPath = this.GetRoundPath(rect, radius);
			base.Region = new Region(roundPath);
			using (Pen pen = new Pen(Color.FromArgb(82, 82, 82), width))
			{
				pen.Alignment = PenAlignment.Inset;
				e.Graphics.DrawPath(pen, roundPath);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005BB8 File Offset: 0x00003DB8
		private void UserControl2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005BBA File Offset: 0x00003DBA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005BD9 File Offset: 0x00003DD9
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x040002D2 RID: 722
		private IContainer components;
	}
}
