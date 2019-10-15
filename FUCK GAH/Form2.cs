using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using WeAreDevs_API;

namespace FUCK_GAH
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000261A File Offset: 0x0000081A
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002634 File Offset: 0x00000834
		private void button1_Click(object sender, EventArgs e)
		{
			ExploitAPI exploitAPI = new ExploitAPI();
			exploitAPI.SendLimitedLuaScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000265C File Offset: 0x0000085C
		private void button2_Click(object sender, EventArgs e)
		{
			ExploitAPI exploitAPI = new ExploitAPI();
			exploitAPI.LaunchExploit();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002677 File Offset: 0x00000877
		private void button3_Click(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Text = "";
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000268B File Offset: 0x0000088B
		private void button4_Click(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Refresh();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000269C File Offset: 0x0000089C
		private void button5_Click(object sender, EventArgs e)
		{
			this.saveFileDialog1.ShowDialog();
			string fileName = this.saveFileDialog1.FileName;
			File.WriteAllText(fileName, this.fastColoredTextBox1.Text);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000026D4 File Offset: 0x000008D4
		private void button7_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.ShowDialog();
			string fileName = this.openFileDialog1.FileName;
			string text = File.ReadAllText(fileName);
			this.fastColoredTextBox1.Text = text;
		}
	}
}
