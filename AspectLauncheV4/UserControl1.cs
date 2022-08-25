using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AspectLauncheV4
{
	// Token: 0x0200000D RID: 13
	public class UserControl1 : Button
	{
		// Token: 0x06000045 RID: 69 RVA: 0x000056FA File Offset: 0x000038FA
		public UserControl1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005708 File Offset: 0x00003908
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

		// Token: 0x06000047 RID: 71 RVA: 0x000058AC File Offset: 0x00003AAC
		protected override void OnPaint(PaintEventArgs e)
		{
			int radius = 30;
			float width = 0.1f;
			base.OnPaint(e);
			RectangleF rect = new RectangleF(0f, 0f, (float)base.Width, (float)base.Height);
			GraphicsPath roundPath = this.GetRoundPath(rect, radius);
			base.Region = new Region(roundPath);
			using (Pen pen = new Pen(Color.Black, width))
			{
				pen.Alignment = PenAlignment.Inset;
				e.Graphics.DrawPath(pen, roundPath);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005940 File Offset: 0x00003B40
		private void UserControl1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005942 File Offset: 0x00003B42
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005961 File Offset: 0x00003B61
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x040002D1 RID: 721
		private IContainer components;
	}
}
