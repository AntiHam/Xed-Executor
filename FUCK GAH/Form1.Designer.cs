namespace FUCK_GAH
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002180 File Offset: 0x00000380
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021B8 File Offset: 0x000003B8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FUCK_GAH.Form1));
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.textBox1.BackColor = global::System.Drawing.Color.Silver;
			this.textBox1.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.textBox1.Location = new global::System.Drawing.Point(46, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(248, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Put Auth Key In Here";
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(129, 107);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(78, 28);
			this.button2.TabIndex = 2;
			this.button2.Text = "Login";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("MV Boli", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(125, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(80, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "BL3IC ";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("MV Boli", 9f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(12, 170);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(131, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Most Stable Cheat";
			this.pictureBox1.Image = global::FUCK_GAH.Properties.Resources._9868e56a_4c76_44f5_a6d6_3f54f9cab8b2;
			this.pictureBox1.Location = new global::System.Drawing.Point(2, -2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(46, 36);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(339, 196);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.textBox1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "BL3IC";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
