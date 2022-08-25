namespace AspectLauncheV4
{
	// Token: 0x0200000B RID: 11
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00004024 File Offset: 0x00002224
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004044 File Offset: 0x00002244
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AspectLauncheV4.Form1));
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox5 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox6 = new global::System.Windows.Forms.PictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.userControl14 = new global::AspectLauncheV4.UserControl1();
			this.userControl13 = new global::AspectLauncheV4.UserControl1();
			this.userControl224 = new global::AspectLauncheV4.UserControl2();
			this.userControl223 = new global::AspectLauncheV4.UserControl2();
			this.userControl222 = new global::AspectLauncheV4.UserControl2();
			this.userControl221 = new global::AspectLauncheV4.UserControl2();
			this.userControl220 = new global::AspectLauncheV4.UserControl2();
			this.userControl219 = new global::AspectLauncheV4.UserControl2();
			this.userControl218 = new global::AspectLauncheV4.UserControl2();
			this.userControl217 = new global::AspectLauncheV4.UserControl2();
			this.userControl216 = new global::AspectLauncheV4.UserControl2();
			this.userControl215 = new global::AspectLauncheV4.UserControl2();
			this.userControl214 = new global::AspectLauncheV4.UserControl2();
			this.userControl213 = new global::AspectLauncheV4.UserControl2();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
			base.SuspendLayout();
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new global::System.Drawing.Point(-4, -22);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(808, 476);
			this.tabControl1.TabIndex = 5;
			this.tabPage1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("tabPage1.BackgroundImage");
			this.tabPage1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.tabPage1.Controls.Add(this.userControl14);
			this.tabPage1.Controls.Add(this.userControl13);
			this.tabPage1.Controls.Add(this.checkBox1);
			this.tabPage1.Controls.Add(this.textBox2);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(800, 450);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = " ";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseDown);
			this.tabPage1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseMove);
			this.tabPage1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseUp);
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = global::System.Drawing.Color.FromArgb(82, 82, 82);
			this.checkBox1.Location = new global::System.Drawing.Point(344, 373);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(106, 17);
			this.checkBox1.TabIndex = 11;
			this.checkBox1.Text = "Save Credentials";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.textBox2.BackColor = global::System.Drawing.Color.FromArgb(82, 82, 82);
			this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.textBox2.ForeColor = global::System.Drawing.Color.FromArgb(255, 120, 1);
			this.textBox2.Location = new global::System.Drawing.Point(309, 289);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '•';
			this.textBox2.Size = new global::System.Drawing.Size(185, 16);
			this.textBox2.TabIndex = 8;
			this.textBox2.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(82, 82, 82);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.textBox1.ForeColor = global::System.Drawing.Color.FromArgb(255, 120, 1);
			this.textBox1.Location = new global::System.Drawing.Point(309, 253);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(185, 16);
			this.textBox1.TabIndex = 7;
			this.textBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.tabPage2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("tabPage2.BackgroundImage");
			this.tabPage2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.tabPage2.Controls.Add(this.userControl224);
			this.tabPage2.Controls.Add(this.userControl223);
			this.tabPage2.Controls.Add(this.userControl222);
			this.tabPage2.Controls.Add(this.userControl221);
			this.tabPage2.Controls.Add(this.userControl220);
			this.tabPage2.Controls.Add(this.userControl219);
			this.tabPage2.Controls.Add(this.userControl218);
			this.tabPage2.Controls.Add(this.userControl217);
			this.tabPage2.Controls.Add(this.userControl216);
			this.tabPage2.Controls.Add(this.userControl215);
			this.tabPage2.Controls.Add(this.userControl214);
			this.tabPage2.Controls.Add(this.userControl213);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.pictureBox3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.pictureBox4);
			this.tabPage2.Controls.Add(this.pictureBox5);
			this.tabPage2.Controls.Add(this.pictureBox6);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(800, 450);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.tabPage2_MouseDown);
			this.tabPage2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.tabPage2_MouseMove);
			this.tabPage2.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.tabPage2_MouseUp);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = global::System.Drawing.Color.Yellow;
			this.label1.Location = new global::System.Drawing.Point(467, 58);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(83, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "Unknown";
			this.pictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new global::System.Drawing.Point(519, 24);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(63, 58);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 17;
			this.pictureBox3.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = global::System.Drawing.Color.Yellow;
			this.label2.Location = new global::System.Drawing.Point(652, 58);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(83, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "Unknown";
			this.pictureBox4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new global::System.Drawing.Point(717, 24);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(63, 58);
			this.pictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 16;
			this.pictureBox4.TabStop = false;
			this.pictureBox5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox5.Image");
			this.pictureBox5.Location = new global::System.Drawing.Point(471, 56);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new global::System.Drawing.Size(94, 34);
			this.pictureBox5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 18;
			this.pictureBox5.TabStop = false;
			this.pictureBox6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox6.Image");
			this.pictureBox6.Location = new global::System.Drawing.Point(662, 55);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new global::System.Drawing.Size(107, 34);
			this.pictureBox6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 19;
			this.pictureBox6.TabStop = false;
			this.timer1.Interval = 5000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick_1);
			this.userControl14.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.userControl14.FlatAppearance.BorderSize = 0;
			this.userControl14.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl14.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl14.Location = new global::System.Drawing.Point(297, 316);
			this.userControl14.Name = "userControl14";
			this.userControl14.Size = new global::System.Drawing.Size(102, 34);
			this.userControl14.TabIndex = 13;
			this.userControl14.UseVisualStyleBackColor = true;
			this.userControl14.Click += new global::System.EventHandler(this.userControl14_Click);
			this.userControl13.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.userControl13.FlatAppearance.BorderSize = 0;
			this.userControl13.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl13.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl13.Location = new global::System.Drawing.Point(400, 316);
			this.userControl13.Name = "userControl13";
			this.userControl13.Size = new global::System.Drawing.Size(102, 34);
			this.userControl13.TabIndex = 12;
			this.userControl13.UseVisualStyleBackColor = true;
			this.userControl13.Click += new global::System.EventHandler(this.userControl13_Click);
			this.userControl224.FlatAppearance.BorderSize = 0;
			this.userControl224.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl224.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl224.Location = new global::System.Drawing.Point(523, 400);
			this.userControl224.Name = "userControl224";
			this.userControl224.Size = new global::System.Drawing.Size(140, 37);
			this.userControl224.TabIndex = 31;
			this.userControl224.UseVisualStyleBackColor = true;
			this.userControl224.Click += new global::System.EventHandler(this.userControl224_Click);
			this.userControl223.FlatAppearance.BorderSize = 0;
			this.userControl223.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl223.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl223.Location = new global::System.Drawing.Point(662, 400);
			this.userControl223.Name = "userControl223";
			this.userControl223.Size = new global::System.Drawing.Size(127, 37);
			this.userControl223.TabIndex = 30;
			this.userControl223.UseVisualStyleBackColor = true;
			this.userControl223.Click += new global::System.EventHandler(this.userControl223_Click);
			this.userControl222.FlatAppearance.BorderSize = 0;
			this.userControl222.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl222.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl222.Location = new global::System.Drawing.Point(397, 400);
			this.userControl222.Name = "userControl222";
			this.userControl222.Size = new global::System.Drawing.Size(127, 37);
			this.userControl222.TabIndex = 29;
			this.userControl222.UseVisualStyleBackColor = true;
			this.userControl222.Click += new global::System.EventHandler(this.userControl222_Click);
			this.userControl221.FlatAppearance.BorderSize = 0;
			this.userControl221.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl221.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl221.Location = new global::System.Drawing.Point(592, 361);
			this.userControl221.Name = "userControl221";
			this.userControl221.Size = new global::System.Drawing.Size(196, 37);
			this.userControl221.TabIndex = 28;
			this.userControl221.UseVisualStyleBackColor = true;
			this.userControl221.Click += new global::System.EventHandler(this.userControl221_Click);
			this.userControl220.FlatAppearance.BorderSize = 0;
			this.userControl220.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl220.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl220.Location = new global::System.Drawing.Point(397, 361);
			this.userControl220.Name = "userControl220";
			this.userControl220.Size = new global::System.Drawing.Size(196, 37);
			this.userControl220.TabIndex = 27;
			this.userControl220.UseVisualStyleBackColor = true;
			this.userControl220.Click += new global::System.EventHandler(this.userControl220_Click);
			this.userControl219.FlatAppearance.BorderSize = 0;
			this.userControl219.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl219.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl219.Location = new global::System.Drawing.Point(397, 322);
			this.userControl219.Name = "userControl219";
			this.userControl219.Size = new global::System.Drawing.Size(391, 37);
			this.userControl219.TabIndex = 26;
			this.userControl219.UseVisualStyleBackColor = true;
			this.userControl219.Click += new global::System.EventHandler(this.userControl219_Click);
			this.userControl218.FlatAppearance.BorderSize = 0;
			this.userControl218.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl218.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl218.Font = new global::System.Drawing.Font("Raleway", 12f, global::System.Drawing.FontStyle.Bold);
			this.userControl218.ForeColor = global::System.Drawing.Color.FromArgb(158, 158, 158);
			this.userControl218.Location = new global::System.Drawing.Point(266, 373);
			this.userControl218.Name = "userControl218";
			this.userControl218.Size = new global::System.Drawing.Size(114, 50);
			this.userControl218.TabIndex = 25;
			this.userControl218.UseVisualStyleBackColor = true;
			this.userControl218.Click += new global::System.EventHandler(this.userControl218_Click);
			this.userControl217.FlatAppearance.BorderSize = 0;
			this.userControl217.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl217.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl217.Font = new global::System.Drawing.Font("Raleway", 12f, global::System.Drawing.FontStyle.Bold);
			this.userControl217.ForeColor = global::System.Drawing.Color.FromArgb(158, 158, 158);
			this.userControl217.Location = new global::System.Drawing.Point(145, 373);
			this.userControl217.Name = "userControl217";
			this.userControl217.Size = new global::System.Drawing.Size(114, 50);
			this.userControl217.TabIndex = 24;
			this.userControl217.UseVisualStyleBackColor = true;
			this.userControl217.Click += new global::System.EventHandler(this.userControl217_Click);
			this.userControl216.FlatAppearance.BorderSize = 0;
			this.userControl216.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl216.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl216.Font = new global::System.Drawing.Font("Raleway", 12f, global::System.Drawing.FontStyle.Bold);
			this.userControl216.ForeColor = global::System.Drawing.Color.FromArgb(158, 158, 158);
			this.userControl216.Location = new global::System.Drawing.Point(24, 373);
			this.userControl216.Name = "userControl216";
			this.userControl216.Size = new global::System.Drawing.Size(114, 50);
			this.userControl216.TabIndex = 23;
			this.userControl216.UseVisualStyleBackColor = true;
			this.userControl216.Click += new global::System.EventHandler(this.userControl216_Click);
			this.userControl215.FlatAppearance.BorderSize = 0;
			this.userControl215.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl215.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl215.Font = new global::System.Drawing.Font("Raleway", 12f, global::System.Drawing.FontStyle.Bold);
			this.userControl215.ForeColor = global::System.Drawing.Color.FromArgb(158, 158, 158);
			this.userControl215.Location = new global::System.Drawing.Point(24, 169);
			this.userControl215.Name = "userControl215";
			this.userControl215.Size = new global::System.Drawing.Size(114, 50);
			this.userControl215.TabIndex = 22;
			this.userControl215.UseVisualStyleBackColor = true;
			this.userControl215.Click += new global::System.EventHandler(this.userControl215_Click);
			this.userControl214.FlatAppearance.BorderSize = 0;
			this.userControl214.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl214.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl214.Font = new global::System.Drawing.Font("Raleway", 12f, global::System.Drawing.FontStyle.Bold);
			this.userControl214.ForeColor = global::System.Drawing.Color.FromArgb(158, 158, 158);
			this.userControl214.Location = new global::System.Drawing.Point(145, 169);
			this.userControl214.Name = "userControl214";
			this.userControl214.Size = new global::System.Drawing.Size(114, 50);
			this.userControl214.TabIndex = 21;
			this.userControl214.UseVisualStyleBackColor = true;
			this.userControl214.Click += new global::System.EventHandler(this.userControl214_Click);
			this.userControl213.FlatAppearance.BorderSize = 0;
			this.userControl213.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.userControl213.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.userControl213.Font = new global::System.Drawing.Font("Raleway", 12f, global::System.Drawing.FontStyle.Bold);
			this.userControl213.ForeColor = global::System.Drawing.Color.FromArgb(158, 158, 158);
			this.userControl213.Location = new global::System.Drawing.Point(266, 169);
			this.userControl213.Name = "userControl213";
			this.userControl213.Size = new global::System.Drawing.Size(114, 50);
			this.userControl213.TabIndex = 20;
			this.userControl213.UseVisualStyleBackColor = true;
			this.userControl213.Click += new global::System.EventHandler(this.userControl213_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.tabControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "Form1";
			base.TransparencyKey = global::System.Drawing.Color.FromArgb(23, 10, 0);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040002A7 RID: 679
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002A8 RID: 680
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x040002A9 RID: 681
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040002AA RID: 682
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x040002AB RID: 683
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040002AE RID: 686
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x040002AF RID: 687
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x040002BC RID: 700
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002BD RID: 701
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002BE RID: 702
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x040002BF RID: 703
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x040002C0 RID: 704
		private global::System.Windows.Forms.PictureBox pictureBox5;

		// Token: 0x040002C1 RID: 705
		private global::System.Windows.Forms.PictureBox pictureBox6;

		// Token: 0x040002C2 RID: 706
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040002C3 RID: 707
		private global::AspectLauncheV4.UserControl1 userControl13;

		// Token: 0x040002C4 RID: 708
		private global::AspectLauncheV4.UserControl1 userControl14;

		// Token: 0x040002C5 RID: 709
		private global::AspectLauncheV4.UserControl2 userControl224;

		// Token: 0x040002C6 RID: 710
		private global::AspectLauncheV4.UserControl2 userControl223;

		// Token: 0x040002C7 RID: 711
		private global::AspectLauncheV4.UserControl2 userControl222;

		// Token: 0x040002C8 RID: 712
		private global::AspectLauncheV4.UserControl2 userControl221;

		// Token: 0x040002C9 RID: 713
		private global::AspectLauncheV4.UserControl2 userControl220;

		// Token: 0x040002CA RID: 714
		private global::AspectLauncheV4.UserControl2 userControl219;

		// Token: 0x040002CB RID: 715
		private global::AspectLauncheV4.UserControl2 userControl218;

		// Token: 0x040002CC RID: 716
		private global::AspectLauncheV4.UserControl2 userControl217;

		// Token: 0x040002CD RID: 717
		private global::AspectLauncheV4.UserControl2 userControl216;

		// Token: 0x040002CE RID: 718
		private global::AspectLauncheV4.UserControl2 userControl215;

		// Token: 0x040002CF RID: 719
		private global::AspectLauncheV4.UserControl2 userControl214;

		// Token: 0x040002D0 RID: 720
		private global::AspectLauncheV4.UserControl2 userControl213;
	}
}
