using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using FUCK_GAH.Properties;

namespace FUCK_GAH
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
			WebClient webClient = new WebClient();
			bool flag = !webClient.DownloadString("https://pastebin.com/raw/cVcgdw3U").Contains("1.7");
			if (flag)
			{
				bool flag2 = MessageBox.Show("Looks Like Theres A new Update,would you like to download it?", "BL3IC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
				if (flag2)
				{
					Process.Start("http://bl3ic.tk/");
				}
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020C4 File Offset: 0x000002C4
		private void button2_Click(object sender, EventArgs e)
		{
			string text = new WebClient
			{
				Proxy = null
			}.DownloadString("https://pastebin.com/raw/WVYcUZ0Y");
			string text2 = new WebClient
			{
				Proxy = null
			}.DownloadString("https://pastebin.com/raw/1Q2PkQ72");
			bool flag = text.Contains(this.textBox1.Text);
			if (flag)
			{
				MessageBox.Show("Whitelisted!");
				Form2 form = new Form2();
				form.Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("Blacklisted! Closing...");
				Application.Exit();
			}
			bool flag2 = text2.Contains(this.textBox1.Text);
			if (flag2)
			{
				MessageBox.Show("Blacklisted! Closing...");
				Application.Exit();
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002177 File Offset: 0x00000377
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000217A File Offset: 0x0000037A
		private void Form1_Load(object sender, EventArgs e)
		{
		}
	}
}
