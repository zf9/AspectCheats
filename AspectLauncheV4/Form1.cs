using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AspectLauncheV4.Antidebug;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace AspectLauncheV4
{
	// Token: 0x0200000B RID: 11
	public partial class Form1 : Form
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000022DE File Offset: 0x000004DE
		private void tabPage1_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002300 File Offset: 0x00000500
		private void tabPage1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002353 File Offset: 0x00000553
		private void tabPage1_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000235C File Offset: 0x0000055C
		private void tabPage2_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000237C File Offset: 0x0000057C
		private void tabPage2_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023CF File Offset: 0x000005CF
		private void tabPage2_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000023D8 File Offset: 0x000005D8
		public Form1()
		{
			this.Default_Registry_Folder_Creation("Aspect Cheats");
			this.Initial_RegKey_Check();
			this.folderCheck();
			this.InitializeComponent();
			base.ActiveControl = this.textBox1;
			this.tabControl1.SelectedTab = this.tabPage1;
			this.buttonText_Check();
			this.CustomPing2();
			this.User_Credential_Save_Check();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002841 File Offset: 0x00000A41
		private void Form1_Load(object sender, EventArgs e)
		{
			this.timer1.Start();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000284E File Offset: 0x00000A4E
		public void Default_Registry_Folder_Creation(string FolderName)
		{
			Registry.CurrentUser.CreateSubKey(FolderName);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000285C File Offset: 0x00000A5C
		public void Initial_RegKey_Check()
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Aspect Cheats");
			object value = registryKey.GetValue("Username");
			object value2 = registryKey.GetValue("Password");
			bool value3 = registryKey.GetValue("CredentialSave") != null;
			if (value == null)
			{
				this.Login_Registry_Key_Creation("Username", "", "Aspect Cheats");
			}
			if (value2 == null)
			{
				this.Login_Registry_Key_Creation("Password", "", "Aspect Cheats");
			}
			if (!value3)
			{
				this.Login_Registry_Key_Creation("CredentialSave", "nosave", "Aspect Cheats");
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000028E4 File Offset: 0x00000AE4
		public static string GetLocaladd()
		{
			string result = string.Empty;
			using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP))
			{
				socket.Connect("8.8.8.8", 65530);
				result = (socket.LocalEndPoint as IPEndPoint).Address.ToString();
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002944 File Offset: 0x00000B44
		public static string Getad()
		{
			string text = "";
			using (WebResponse response = WebRequest.Create("http://checkip.dyndns.org/").GetResponse())
			{
				using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
				{
					text = streamReader.ReadToEnd();
				}
			}
			int num = text.IndexOf("Address: ") + 9;
			int num2 = text.LastIndexOf("</body>");
			text = text.Substring(num, num2 - num);
			return text;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000029D8 File Offset: 0x00000BD8
		public static string Encrypt(string input, string key)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(input);
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(key);
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			byte[] array = tripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
			tripleDESCryptoServiceProvider.Clear();
			return Convert.ToBase64String(array, 0, array.Length);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002A38 File Offset: 0x00000C38
		public static string Decrypt(string input, string key)
		{
			byte[] array = Convert.FromBase64String(input);
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(key);
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			byte[] bytes = tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
			tripleDESCryptoServiceProvider.Clear();
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002A94 File Offset: 0x00000C94
		public static void Webmessage(string title, string description, string username, string color)
		{
			WebRequest webRequest = WebRequest.Create(Form1.Decrypt(Form1.Encrypt("https://discordapp.com/api/webhooks/868169037102841906/v1sWAr4bJwqKosQoSmlt7OHRCkSwOLvAmEoqktphR9JAi6DTAl7PpWSH6NZnBd6QVZmd", "sblw-3hn8-sqoy19"), "sblw-3hn8-sqoy19"));
			webRequest.ContentType = "application/json";
			webRequest.Method = "POST";
			using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
			{
				string value = JsonConvert.SerializeObject(new
				{
					username = username,
					embeds = new <>f__AnonymousType1<string, string, string>[]
					{
						new
						{
							description,
							title,
							color
						}
					}
				});
				streamWriter.Write(value);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002B30 File Offset: 0x00000D30
		public void User_Credential_Save_Check()
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Aspect Cheats");
			string text = registryKey.GetValue("Username").ToString();
			string text2 = registryKey.GetValue("Password").ToString();
			if (registryKey != null)
			{
				if (registryKey.GetValue("CredentialSave").ToString() == "save")
				{
					this.textBox1.Text = text;
					this.textBox2.Text = text2;
					this.checkBox1.Checked = true;
					return;
				}
			}
			else
			{
				this.textBox1.Text = "";
				this.textBox2.Text = "";
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002BD3 File Offset: 0x00000DD3
		public void Login_Registry_Key_Creation(string KeyName, string PaidOrFree, string FolderName)
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Aspect Cheats");
			registryKey.SetValue(KeyName, PaidOrFree);
			registryKey.Close();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public void Auth()
		{
			string text = this.textBox1.Text;
			string text2 = this.textBox2.Text;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
			{
				"https://aspectcheats.xyz/auth/auth.php?username=",
				text,
				"&password=",
				text2,
				"&hwid=",
				this.hwid,
				"&version=std&releaseversion=2.5"
			}));
			httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				using (Stream responseStream = httpWebResponse.GetResponseStream())
				{
					using (StreamReader streamReader = new StreamReader(responseStream))
					{
						this.html = streamReader.ReadToEnd();
					}
				}
			}
			if (this.html == "true")
			{
				string[] contents = new string[]
				{
					text,
					text2
				};
				File.WriteAllLines(Form1.sPath + "\\AspectCheats\\Login.txt", contents);
				this.Login_Registry_Key_Creation("Username", this.textBox1.Text, "Aspect Cheats");
				this.Login_Registry_Key_Creation("Password", this.textBox2.Text, "Aspect Cheats");
				if (this.checkBox1.Checked)
				{
					this.Login_Registry_Key_Creation("CredentialSave", "save", "Aspect Cheats");
				}
				if (!this.checkBox1.Checked)
				{
					this.Login_Registry_Key_Creation("CredentialSave", "nosave", "Aspect Cheats");
				}
				if (!File.Exists(this.Blacktxt))
				{
					File.Create(Form1.sPath + "\\AspectCheats\\Blacklist.txt");
				}
				this.FileCheck();
				return;
			}
			if (this.html == "bad dll version")
			{
				MessageBox.Show("This version of the launcher is out of date!\n\nPlease download the latest version from our website!", "Outdated Launcher");
				return;
			}
			if (this.html == "frozen")
			{
				MessageBox.Show("Account Frozen", "Login Error");
				return;
			}
			MessageBox.Show("Invalid Login or HWID", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002E10 File Offset: 0x00001010
		public void folderCheck()
		{
			if (!Directory.Exists(Form1.sPath + "\\AspectCheats"))
			{
				Directory.CreateDirectory(Form1.sPath + "\\AspectCheats");
			}
			if (!Directory.Exists(Form1.sPath + "\\AspectCheats\\Injection"))
			{
				Directory.CreateDirectory(Form1.sPath + "\\AspectCheats\\Injection");
			}
			if (!Directory.Exists(Form1.sPath + "\\AspectCheats\\SHV"))
			{
				Directory.CreateDirectory(Form1.sPath + "\\AspectCheats\\SHV");
			}
			if (!Directory.Exists(Form1.sPath + "\\AspectCheats\\Textures"))
			{
				Directory.CreateDirectory(Form1.sPath + "\\AspectCheats\\Textures");
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002ECC File Offset: 0x000010CC
		public void initialCoreFileCheck()
		{
			if (!File.Exists(this.DLL))
			{
				using (WebClient webClient = new WebClient())
				{
					try
					{
						File.Delete(this.menuDLL);
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFileAsync(new Uri("https://aspectcheats.xyz/Files/Inject.exe"), this.DLL);
					}
					catch
					{
						MessageBox.Show("Injector Failed to download.\n\nPlease contact support on the Discord if this issue persists!");
					}
				}
			}
			if (!File.Exists(this.SHV))
			{
				using (WebClient webClient2 = new WebClient())
				{
					try
					{
						webClient2.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient2.DownloadFile(new Uri("https://aspectcheats.xyz/Files/ScriptHookV.dll"), this.SHV);
					}
					catch
					{
						MessageBox.Show("SHV Failed to download.\n\nPlease contact support on the Discord if this issue persists!");
					}
				}
			}
			if (File.Exists(this.SHV))
			{
				using (WebClient webClient3 = new WebClient())
				{
					try
					{
						webClient3.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient3.DownloadFile(new Uri("https://aspectcheats.xyz/Files/ScriptHookV.dll"), this.SHV);
					}
					catch
					{
						MessageBox.Show("SHV Failed to download.\n\nPlease contact support on the Discord if this issue persists!");
					}
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003038 File Offset: 0x00001238
		public void FileCheck()
		{
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			this.tabControl1.SelectedTab = this.tabPage2;
			using (WebClient webClient = new WebClient())
			{
				if (!File.Exists(this.DLL))
				{
					try
					{
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFile(new Uri("https://aspectcheats.xyz/Files/Inject.exe"), this.DLL);
					}
					catch
					{
						MessageBox.Show("Injector Failed to download.\n\nPlease contact support on the Discord if this issue persists!");
					}
				}
				if (!File.Exists(this.SHV))
				{
					try
					{
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFile(new Uri("https://aspectcheats.xyz/Files/ScriptHookV.dll"), this.SHV);
					}
					catch
					{
						MessageBox.Show("SHV Failed to download.\n\nPlease contact support on the Discord if this issue persists!");
					}
				}
				if (!File.Exists(this.Admintxt))
				{
					try
					{
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFile(new Uri("https://aspectcheats.xyz/Files/Admins.txt"), this.Admintxt);
					}
					catch
					{
						MessageBox.Show("Admintxt Failed to download.\n\nPlease contact support on the Discord if this issue persists!");
					}
				}
				if (!File.Exists(this.Configini))
				{
					try
					{
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFile(new Uri("https://aspectcheats.xyz/Files/config.ini"), this.Configini);
					}
					catch
					{
						MessageBox.Show("Configini Failed to download.\n\nPlease contact support on the Discord if this issue persists!");
					}
				}
				if (!File.Exists(this.Hotkeysini))
				{
					try
					{
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFile(new Uri("https://aspectcheats.xyz/Files/Hotkeys.ini"), this.Hotkeysini);
					}
					catch
					{
						MessageBox.Show("Hotkeysini Failed to download.\n\nPlease contact support on the Discord if this issue persists!");
					}
				}
				if (!File.Exists(this.loggertxt))
				{
					try
					{
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFile(new Uri("https://aspectcheats.xyz/Files/Logger.txt"), this.loggertxt);
					}
					catch
					{
						MessageBox.Show("loggertxt Failed to download.\n\nPlease contact support on the Discord if this issue persists!");
					}
				}
			}
			using (WebClient webClient2 = new WebClient())
			{
				if (!File.Exists(this.HEADERR))
				{
					try
					{
						webClient2.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient2.DownloadFile(new Uri("https://aspectcheats.xyz/Files/Textures/Header.png"), this.HEADERR);
					}
					catch
					{
					}
				}
				if (!File.Exists(this.CUSTOMHEADER))
				{
					try
					{
						webClient2.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient2.DownloadFile(new Uri("https://aspectcheats.xyz/Files/Textures/Custom.png"), this.CUSTOMHEADER);
						if (!File.Exists(this.CUSTOMHEADER))
						{
							MessageBox.Show("Custom Header Texture Failed to download.\n\nPlease contact support on the Discord if this issue persists!");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000033C4 File Offset: 0x000015C4
		public void CustomPing2()
		{
			try
			{
				Ping ping = new Ping();
				string s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
				byte[] bytes = Encoding.ASCII.GetBytes(s);
				int timeout = 5000;
				PingOptions options = new PingOptions(64, true);
				if (ping.Send("prod.cloud.rockstargames.com", timeout, bytes, options).Status == IPStatus.Success)
				{
					this.label1.Text = "Online";
					this.label1.ForeColor = Color.LimeGreen;
					this.pictureBox3.Visible = true;
					this.pictureBox5.Visible = false;
				}
				if (ping.Send("prod.cloud.rockstargames.com", timeout, bytes, options).Status != IPStatus.Success)
				{
					this.label1.Text = "Offline";
					this.label1.ForeColor = Color.Red;
					this.pictureBox3.Visible = false;
					this.pictureBox5.Visible = true;
				}
				if (ping.Send("aspectcheats.xyz", timeout, bytes, options).Status == IPStatus.Success)
				{
					this.label2.Text = "Online";
					this.label2.ForeColor = Color.LimeGreen;
					this.pictureBox4.Visible = true;
					this.pictureBox6.Visible = false;
				}
				if (ping.Send("aspectcheats.xyz", timeout, bytes, options).Status != IPStatus.Success)
				{
					this.label2.Text = "Offline";
					this.label2.ForeColor = Color.Red;
					this.pictureBox4.Visible = false;
					this.pictureBox6.Visible = true;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000354C File Offset: 0x0000174C
		public void buttonText_Check()
		{
			if (!File.Exists(this.MenyooASI))
			{
				this.userControl215.Text = "Download";
			}
			if (File.Exists(this.MenyooASI))
			{
				this.userControl215.Text = "Delete";
			}
			if (!File.Exists(this.SimpleASI))
			{
				this.userControl214.Text = "Download";
			}
			if (File.Exists(this.SimpleASI))
			{
				this.userControl214.Text = "Delete";
			}
			if (!File.Exists(this.nblASI))
			{
				this.userControl213.Text = "Download";
			}
			if (File.Exists(this.nblASI))
			{
				this.userControl213.Text = "Delete";
			}
			if (!File.Exists(this.openInteriorsASI))
			{
				this.userControl216.Text = "Download";
			}
			if (File.Exists(this.openInteriorsASI))
			{
				this.userControl216.Text = "Delete";
			}
			if (!File.Exists(this.BodyguardsASI))
			{
				this.userControl217.Text = "Download";
			}
			if (File.Exists(this.BodyguardsASI))
			{
				this.userControl217.Text = "Delete";
			}
			if (!File.Exists(this.NativeTrainerASI))
			{
				this.userControl218.Text = "Download";
			}
			if (File.Exists(this.NativeTrainerASI))
			{
				this.userControl218.Text = "Delete";
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000036B8 File Offset: 0x000018B8
		public void resetFile()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AspectCheats";
			if (Directory.Exists(path))
			{
				Directory.Delete(path, true);
				this.folderCheck();
				this.FileCheck();
				File.Create(Form1.sPath + "\\AspectCheats\\Blacklist.txt");
				return;
			}
			this.FileCheck();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000370E File Offset: 0x0000190E
		private void userControl13_Click(object sender, EventArgs e)
		{
			this.Auth();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003716 File Offset: 0x00001916
		private void userControl14_Click(object sender, EventArgs e)
		{
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003722 File Offset: 0x00001922
		private void userControl224_Click(object sender, EventArgs e)
		{
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003730 File Offset: 0x00001930
		private void userControl215_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			if (!File.Exists(this.MenyooASI))
			{
				try
				{
					webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
					webClient.DownloadFileAsync(new Uri(this.MenyooASI_URL), this.MenyooASI);
					MessageBox.Show(this.M + "installed!");
					this.buttonText_Check();
					return;
				}
				catch
				{
					return;
				}
			}
			if (File.Exists(this.MenyooASI))
			{
				File.Delete(this.MenyooASI);
				MessageBox.Show(this.M + " uninstalled!");
				this.buttonText_Check();
				return;
			}
			MessageBox.Show(this.M + " is already installed.");
			this.buttonText_Check();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003800 File Offset: 0x00001A00
		private void userControl214_Click(object sender, EventArgs e)
		{
			if (!File.Exists(this.SimpleASI))
			{
				using (WebClient webClient = new WebClient())
				{
					try
					{
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFileAsync(new Uri(this.SimpleASI_URL), this.SimpleASI);
					}
					catch
					{
					}
				}
				using (WebClient webClient2 = new WebClient())
				{
					try
					{
						webClient2.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient2.DownloadFileAsync(new Uri(this.SimpleINI_URL), this.SimpleINI);
						this.buttonText_Check();
					}
					catch
					{
					}
					MessageBox.Show(this.ST + " installed.");
					return;
				}
			}
			if (File.Exists(this.SimpleASI))
			{
				File.Delete(this.SimpleASI);
				File.Delete(this.SimpleINI);
				MessageBox.Show(this.ST + " uninstalled!");
				this.buttonText_Check();
				return;
			}
			MessageBox.Show(this.ST + " is already installed.");
			this.buttonText_Check();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003950 File Offset: 0x00001B50
		private void userControl213_Click(object sender, EventArgs e)
		{
			if (!File.Exists(this.nblASI))
			{
				using (WebClient webClient = new WebClient())
				{
					try
					{
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFileAsync(new Uri(this.nblASI_URL), this.nblASI);
					}
					catch
					{
					}
				}
				using (WebClient webClient2 = new WebClient())
				{
					try
					{
						webClient2.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient2.DownloadFileAsync(new Uri(this.nblINI_URL), this.nblINI);
						this.buttonText_Check();
					}
					catch
					{
					}
					MessageBox.Show(this.NBL + " installed.");
					return;
				}
			}
			if (File.Exists(this.nblASI))
			{
				File.Delete(this.nblASI);
				File.Delete(this.nblINI);
				MessageBox.Show(this.NBL + " uninstalled!");
				this.buttonText_Check();
				return;
			}
			MessageBox.Show(this.NBL + " is already installed.");
			this.buttonText_Check();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003AA0 File Offset: 0x00001CA0
		private void userControl216_Click(object sender, EventArgs e)
		{
			if (!File.Exists(this.openInteriorsASI))
			{
				using (WebClient webClient = new WebClient())
				{
					try
					{
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFileAsync(new Uri(this.openInteriorsASI_URL), this.openInteriorsASI);
					}
					catch
					{
					}
				}
				using (WebClient webClient2 = new WebClient())
				{
					try
					{
						webClient2.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient2.DownloadFileAsync(new Uri(this.openInteriorsINI_URL), this.openInteriorsINI);
						this.buttonText_Check();
					}
					catch
					{
					}
					MessageBox.Show(this.OI + " installed.");
					return;
				}
			}
			if (File.Exists(this.BodyguardsASI))
			{
				File.Delete(this.openInteriorsASI);
				File.Delete(this.openInteriorsINI);
				MessageBox.Show(this.OI + " uninstalled!");
				this.buttonText_Check();
				return;
			}
			MessageBox.Show(this.OI + " is already installed.");
			this.buttonText_Check();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003BF0 File Offset: 0x00001DF0
		private void userControl217_Click(object sender, EventArgs e)
		{
			GC.Collect();
			if (!File.Exists(this.BodyguardsASI))
			{
				using (WebClient webClient = new WebClient())
				{
					try
					{
						webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient.DownloadFileAsync(new Uri(this.BodyguardsASI_URL), this.BodyguardsASI);
					}
					catch
					{
					}
				}
				using (WebClient webClient2 = new WebClient())
				{
					try
					{
						webClient2.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
						webClient2.DownloadFileAsync(new Uri(this.BodyguardsINI_URL), this.BodyguardsINI);
						this.buttonText_Check();
					}
					catch
					{
					}
					MessageBox.Show(this.B + " installed.");
					return;
				}
			}
			if (File.Exists(this.BodyguardsASI))
			{
				File.Delete(this.BodyguardsASI);
				File.Delete(this.BodyguardsINI);
				MessageBox.Show(this.B + " uninstalled!");
				this.buttonText_Check();
				return;
			}
			MessageBox.Show(this.B + " is already installed.");
			this.buttonText_Check();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003D44 File Offset: 0x00001F44
		private void userControl218_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			if (!File.Exists(this.NativeTrainerASI))
			{
				try
				{
					webClient.Headers.Add("user-agent", "AspectCheatsNotBot1.00.00 Flightlong");
					webClient.DownloadFileAsync(new Uri(this.NativeTrainerASI_URL), this.NativeTrainerASI);
					MessageBox.Show(this.NT + " installed.");
					this.buttonText_Check();
					return;
				}
				catch
				{
					return;
				}
			}
			if (File.Exists(this.NativeTrainerASI))
			{
				File.Delete(this.NativeTrainerASI);
				MessageBox.Show(this.NT + " uninstalled!");
				this.buttonText_Check();
				return;
			}
			MessageBox.Show(this.NT + " is already installed.");
			this.buttonText_Check();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003E14 File Offset: 0x00002014
		private void userControl221_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("You will be logged out, are you sure?", "Reset Files", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.resetFile();
				this.buttonText_Check();
				this.tabControl1.SelectedTab = this.tabPage1;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003E4A File Offset: 0x0000204A
		private void userControl223_Click(object sender, EventArgs e)
		{
			Process.Start(this.site);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003E58 File Offset: 0x00002058
		private void userControl222_Click(object sender, EventArgs e)
		{
			Process.Start(this.discord);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003E66 File Offset: 0x00002066
		private void userControl220_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.gta5-mods.com/scripts/tags/asi");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003E74 File Offset: 0x00002074
		private void userControl219_Click(object sender, EventArgs e)
		{
			try
			{
				this.initialCoreFileCheck();
				Process.Start(this.menuDLL);
				Thread.Sleep(500);
				if (File.Exists(this.DLL))
				{
					try
					{
						File.Delete(this.menuDLL);
					}
					catch
					{
						this.taco = true;
					}
					if (this.taco)
					{
						Thread.Sleep(1100);
						try
						{
							File.Delete(this.menuDLL);
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003F10 File Offset: 0x00002110
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.userControl13_Click(sender, e);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003F24 File Offset: 0x00002124
		private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.userControl13_Click(sender, e);
			}
		}

		// Token: 0x06000036 RID: 54
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		// Token: 0x06000037 RID: 55
		[DllImport("kernel32.dll")]
		private static extern IntPtr LoadLibraryA(string lpLibFileName);

		// Token: 0x06000038 RID: 56
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x06000039 RID: 57
		[DllImport("kernel32.dll")]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, int dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, int dwCreationFlags, int lpThreadId);

		// Token: 0x0600003A RID: 58
		[DllImport("kernel32.dll")]
		private static extern int WaitForSingleObject(IntPtr hProcess, int dwMilliseconds);

		// Token: 0x0600003B RID: 59
		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);

		// Token: 0x0600003C RID: 60
		[DllImport("kernel32.dll")]
		private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int dwFreeType);

		// Token: 0x0600003D RID: 61
		[DllImport("kernel32.dll")]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int nSize, int lpNumberOfBytesWritten);

		// Token: 0x0600003E RID: 62 RVA: 0x00003F38 File Offset: 0x00002138
		private bool InjectDll(string processname, string dllpath)
		{
			try
			{
				if (Process.GetProcessesByName(processname).Length == 0)
				{
					return false;
				}
				IntPtr hProcess = Form1.OpenProcess(56, false, Process.GetProcessesByName(processname)[0].Id);
				IntPtr intPtr = Form1.VirtualAllocEx(hProcess, 0, dllpath.Length + 1, 4096, 4);
				Form1.WriteProcessMemory(hProcess, intPtr, Marshal.StringToHGlobalAnsi(dllpath), dllpath.Length + 1, 0);
				Form1.WaitForSingleObject(Form1.CreateRemoteThread(hProcess, IntPtr.Zero, 0, Form1.GetProcAddress(Form1.LoadLibraryA("kernel32.dll"), "LoadLibraryA"), intPtr, 0, 0), -1);
				Form1.VirtualFreeEx(hProcess, intPtr, 0, 32768);
				return true;
			}
			catch (Exception)
			{
			}
			return false;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003FE8 File Offset: 0x000021E8
		public void InjectDLL(string PathToDLL)
		{
			this.InjectDll("GTA5", PathToDLL);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003FF7 File Offset: 0x000021F7
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			if (this.firstload)
			{
				debugprotect3.HideOSThreads();
				this.firstload = false;
			}
			Scanner.ScanAndKill();
			if (debugprotect1.PerformChecks() == 1)
			{
				Environment.FailFast("");
			}
		}

		// Token: 0x04000267 RID: 615
		private static string sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x04000268 RID: 616
		private string gtaexe = "GTA5";

		// Token: 0x04000269 RID: 617
		private string hwid = Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", null).ToString();

		// Token: 0x0400026A RID: 618
		private string html = string.Empty;

		// Token: 0x0400026B RID: 619
		private bool firstload = true;

		// Token: 0x0400026C RID: 620
		private string menuDLL = Form1.sPath + "\\AspectCheats\\Injection\\Inject.exe";

		// Token: 0x0400026D RID: 621
		private string MenyooASI = Form1.sPath + "\\AspectCheats\\SHV\\Menyoo.asi";

		// Token: 0x0400026E RID: 622
		private string SimpleASI = Form1.sPath + "\\AspectCheats\\SHV\\TrainerV.asi";

		// Token: 0x0400026F RID: 623
		private string SimpleINI = Form1.sPath + "\\AspectCheats\\SHV\\trainerv.ini";

		// Token: 0x04000270 RID: 624
		private string nblASI = Form1.sPath + "\\AspectCheats\\SHV\\NoBoundaryLimits.asi";

		// Token: 0x04000271 RID: 625
		private string nblINI = Form1.sPath + "\\AspectCheats\\SHV\\NoBoundaryLimits.ini";

		// Token: 0x04000272 RID: 626
		private string openInteriorsASI = Form1.sPath + "\\AspectCheats\\SHV\\OpenInteriors.asi";

		// Token: 0x04000273 RID: 627
		private string openInteriorsINI = Form1.sPath + "\\AspectCheats\\SHV\\OpenInteriors.ini";

		// Token: 0x04000274 RID: 628
		private string BodyguardsASI = Form1.sPath + "\\AspectCheats\\SHV\\Bodyguards.asi";

		// Token: 0x04000275 RID: 629
		private string BodyguardsINI = Form1.sPath + "\\AspectCheats\\SHV\\Bodyguards.ini";

		// Token: 0x04000276 RID: 630
		private string NativeTrainerASI = Form1.sPath + "\\AspectCheats\\SHV\\NativeTrainer.asi";

		// Token: 0x04000277 RID: 631
		private string DLL = Form1.sPath + "\\AspectCheats\\Injection\\Inject.exe";

		// Token: 0x04000278 RID: 632
		private string Injector = Form1.sPath + "\\AspectCheats\\Injection\\Injector.exe";

		// Token: 0x04000279 RID: 633
		private string SHV = Form1.sPath + "\\AspectCheats\\SHV\\ScriptHookV.dll";

		// Token: 0x0400027A RID: 634
		private string Admintxt = Form1.sPath + "\\AspectCheats\\Admins.txt";

		// Token: 0x0400027B RID: 635
		private string Blacktxt = Form1.sPath + "\\AspectCheats\\Blacklist.txt";

		// Token: 0x0400027C RID: 636
		private string Configini = Form1.sPath + "\\AspectCheats\\Config.ini";

		// Token: 0x0400027D RID: 637
		private string Hotkeysini = Form1.sPath + "\\AspectCheats\\Hotkeys.ini";

		// Token: 0x0400027E RID: 638
		private string loggertxt = Form1.sPath + "\\AspectCheats\\Logger.txt";

		// Token: 0x0400027F RID: 639
		private string ASIT = Form1.sPath + "\\AspectCheats\\Textures\\ASI.png";

		// Token: 0x04000280 RID: 640
		private string BDYT = Form1.sPath + "\\AspectCheats\\Textures\\Bodyguards.png";

		// Token: 0x04000281 RID: 641
		private string CART = Form1.sPath + "\\AspectCheats\\Textures\\Car.png";

		// Token: 0x04000282 RID: 642
		private string EXITT = Form1.sPath + "\\AspectCheats\\Textures\\Exit.png";

		// Token: 0x04000283 RID: 643
		private string HOMET = Form1.sPath + "\\AspectCheats\\Textures\\Home.png";

		// Token: 0x04000284 RID: 644
		private string MISCT = Form1.sPath + "\\AspectCheats\\Textures\\Misc.png";

		// Token: 0x04000285 RID: 645
		private string PLAYERT = Form1.sPath + "\\AspectCheats\\Textures\\Player.png";

		// Token: 0x04000286 RID: 646
		private string PLAYERST = Form1.sPath + "\\AspectCheats\\Textures\\Players.png";

		// Token: 0x04000287 RID: 647
		private string PROTEXT = Form1.sPath + "\\AspectCheats\\Textures\\Protections.png";

		// Token: 0x04000288 RID: 648
		private string RECT = Form1.sPath + "\\AspectCheats\\Textures\\Recovery.png";

		// Token: 0x04000289 RID: 649
		private string SETT = Form1.sPath + "\\AspectCheats\\Textures\\Settings.png";

		// Token: 0x0400028A RID: 650
		private string SPAWNT = Form1.sPath + "\\AspectCheats\\Textures\\Spawner.png";

		// Token: 0x0400028B RID: 651
		private string TELET = Form1.sPath + "\\AspectCheats\\Textures\\Teleport.png";

		// Token: 0x0400028C RID: 652
		private string WEPT = Form1.sPath + "\\AspectCheats\\Textures\\Weapons.png";

		// Token: 0x0400028D RID: 653
		private string WRLDT = Form1.sPath + "\\AspectCheats\\Textures\\World.png";

		// Token: 0x0400028E RID: 654
		private string HEADERR = Form1.sPath + "\\AspectCheats\\Textures\\Header.png";

		// Token: 0x0400028F RID: 655
		private string CUSTOMHEADER = Form1.sPath + "\\AspectCheats\\Textures\\Custom.png";

		// Token: 0x04000290 RID: 656
		private string M = "Menyoo";

		// Token: 0x04000291 RID: 657
		private string ST = "Simple Trainer";

		// Token: 0x04000292 RID: 658
		private string NBL = "No Boundry Limits";

		// Token: 0x04000293 RID: 659
		private string OI = "Open Interiors";

		// Token: 0x04000294 RID: 660
		private string B = "Bodyguards";

		// Token: 0x04000295 RID: 661
		private string NT = "Native Trainer";

		// Token: 0x04000296 RID: 662
		private string MenyooASI_URL = "https://aspectcheats.xyz/Files/ASI/Menyoo.asi";

		// Token: 0x04000297 RID: 663
		private string SimpleASI_URL = "https://aspectcheats.xyz/Files/ASI/TrainerV.asi";

		// Token: 0x04000298 RID: 664
		private string SimpleINI_URL = "https://aspectcheats.xyz/Files/ASI/TrainerV.ini";

		// Token: 0x04000299 RID: 665
		private string nblASI_URL = "https://aspectcheats.xyz/Files/ASI/NoBoundaryLimits.asi";

		// Token: 0x0400029A RID: 666
		private string nblINI_URL = "https://aspectcheats.xyz/Files/ASI/NoBoundaryLimits.ini";

		// Token: 0x0400029B RID: 667
		private string openInteriorsASI_URL = "https://aspectcheats.xyz/Files/ASI/OpenInteriors.asi";

		// Token: 0x0400029C RID: 668
		private string openInteriorsINI_URL = "https://aspectcheats.xyz/Files/ASI/OpenInteriors.ini";

		// Token: 0x0400029D RID: 669
		private string BodyguardsASI_URL = "https://aspectcheats.xyz/Files/ASI/BodyguardMenu.asi";

		// Token: 0x0400029E RID: 670
		private string BodyguardsINI_URL = "https://aspectcheats.xyz/Files/ASI/BodyguardMenu.ini";

		// Token: 0x0400029F RID: 671
		private string NativeTrainerASI_URL = "https://aspectcheats.xyz/Files/ASI/NativeTrainer.asi";

		// Token: 0x040002A0 RID: 672
		private string site = "https://aspectcheats.xyz/";

		// Token: 0x040002A1 RID: 673
		private string discord = "https://discord.gg/cJfQS4vRek";

		// Token: 0x040002A2 RID: 674
		private bool taco;

		// Token: 0x040002A3 RID: 675
		private bool _dragging;

		// Token: 0x040002A4 RID: 676
		private Point _offset;

		// Token: 0x040002A5 RID: 677
		private Point _start_point = new Point(0, 0);

		// Token: 0x040002A6 RID: 678
		private string GTA5 = "GTA5.exe";

		// Token: 0x040002AC RID: 684
		private UserControl1 userControl11;

		// Token: 0x040002AD RID: 685
		private UserControl1 userControl12;

		// Token: 0x040002B0 RID: 688
		private UserControl2 userControl21;

		// Token: 0x040002B1 RID: 689
		private UserControl2 userControl26;

		// Token: 0x040002B2 RID: 690
		private UserControl2 userControl25;

		// Token: 0x040002B3 RID: 691
		private UserControl2 userControl24;

		// Token: 0x040002B4 RID: 692
		private UserControl2 userControl23;

		// Token: 0x040002B5 RID: 693
		private UserControl2 userControl22;

		// Token: 0x040002B6 RID: 694
		private UserControl2 userControl27;

		// Token: 0x040002B7 RID: 695
		private UserControl2 userControl211;

		// Token: 0x040002B8 RID: 696
		private UserControl2 userControl210;

		// Token: 0x040002B9 RID: 697
		private UserControl2 userControl29;

		// Token: 0x040002BA RID: 698
		private UserControl2 userControl28;

		// Token: 0x040002BB RID: 699
		private UserControl2 userControl212;

		// Token: 0x02000016 RID: 22
		[Flags]
		private enum PROCESS_ACCESS_FLAGS
		{
			// Token: 0x040002E1 RID: 737
			PROCESS_VM_READ = 16,
			// Token: 0x040002E2 RID: 738
			PROCESS_VM_WRITE = 32,
			// Token: 0x040002E3 RID: 739
			PROCESS_VM_OPERATION = 8
		}

		// Token: 0x02000017 RID: 23
		[Flags]
		private enum MEMORY_ACCESS_FLAGS
		{
			// Token: 0x040002E5 RID: 741
			MEM_COMMIT = 4096,
			// Token: 0x040002E6 RID: 742
			MEM_RELEASE = 32768
		}

		// Token: 0x02000018 RID: 24
		[Flags]
		private enum PAGE_ACCESS_FLAGS
		{
			// Token: 0x040002E8 RID: 744
			PAGE_READWRITE = 4
		}
	}
}
