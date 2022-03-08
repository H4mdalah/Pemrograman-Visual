/*
 * Created by SharpDevelop.
 * User: rober
 * Date: 08/03/2022
 * Time: 22:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(280, 275);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(248, 54);
			this.button1.TabIndex = 0;
			this.button1.Text = "INPUT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(638, 281);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(250, 47);
			this.button2.TabIndex = 1;
			this.button2.Text = "HAPUS";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(77, 353);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(903, 264);
			this.listBox1.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 53);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(489, 26);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(113, 107);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(487, 26);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(115, 169);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(485, 26);
			this.textBox3.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 27);
			this.label1.TabIndex = 6;
			this.label1.Text = "NAMA";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(49, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 31);
			this.label2.TabIndex = 7;
			this.label2.Text = "NIM";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(49, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 33);
			this.label3.TabIndex = 8;
			this.label3.Text = "KOM";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1172, 675);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "tugas2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
