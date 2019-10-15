namespace FUCK_GAH
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002710 File Offset: 0x00000910
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002748 File Offset: 0x00000948
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FUCK_GAH.Form2));
			this.fastColoredTextBox1 = new global::FastColoredTextBoxNS.FastColoredTextBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.saveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.button7 = new global::System.Windows.Forms.Button();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).BeginInit();
			base.SuspendLayout();
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.fastColoredTextBox1.AutoScrollMinSize = new global::System.Drawing.Size(131, 14);
			this.fastColoredTextBox1.BackBrush = null;
			this.fastColoredTextBox1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.fastColoredTextBox1.CaretColor = global::System.Drawing.Color.Cyan;
			this.fastColoredTextBox1.CharHeight = 14;
			this.fastColoredTextBox1.CharWidth = 8;
			this.fastColoredTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.fastColoredTextBox1.DisabledColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.fastColoredTextBox1.Font = new global::System.Drawing.Font("Courier New", 9.75f);
			this.fastColoredTextBox1.ForeColor = global::System.Drawing.Color.Cyan;
			this.fastColoredTextBox1.IndentBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.Location = new global::System.Drawing.Point(1, 56);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.Paddings = new global::System.Windows.Forms.Padding(0);
			this.fastColoredTextBox1.SelectionColor = global::System.Drawing.Color.FromArgb(60, 0, 0, 255);
			this.fastColoredTextBox1.ServiceColors = (global::FastColoredTextBoxNS.ServiceColors)componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors");
			this.fastColoredTextBox1.ServiceLinesColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.fastColoredTextBox1.Size = new global::System.Drawing.Size(518, 280);
			this.fastColoredTextBox1.TabIndex = 0;
			this.fastColoredTextBox1.Text = "BL3I EXECUTOR";
			this.fastColoredTextBox1.TextAreaBorderColor = global::System.Drawing.Color.Cyan;
			this.fastColoredTextBox1.Zoom = 100;
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.richTextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.richTextBox1.Location = new global::System.Drawing.Point(525, 56);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(140, 280);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "YoYo\nMost Legit Sellers\nMade By Bitizy//itirican\nhttp://bl3ic.tk";
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(1, 342);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(123, 35);
			this.button1.TabIndex = 2;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(157, 342);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(123, 35);
			this.button2.TabIndex = 3;
			this.button2.Text = "Inject";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(525, 342);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(66, 35);
			this.button3.TabIndex = 4;
			this.button3.Text = "Clear";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = global::System.Drawing.Color.White;
			this.button4.Location = new global::System.Drawing.Point(597, 342);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(66, 35);
			this.button4.TabIndex = 5;
			this.button4.Text = "Refresh";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = global::System.Drawing.Color.White;
			this.button5.Location = new global::System.Drawing.Point(417, 342);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(68, 35);
			this.button5.TabIndex = 6;
			this.button5.Text = "Save";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button7.ForeColor = global::System.Drawing.Color.White;
			this.button7.Location = new global::System.Drawing.Point(331, 342);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(68, 35);
			this.button7.TabIndex = 8;
			this.button7.Text = "Open";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.openFileDialog1.FileName = "openFileDialog1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(677, 404);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.fastColoredTextBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form2";
			this.Text = "BL3IC EXECUTOR";
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000007 RID: 7
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000008 RID: 8
		private global::FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}
