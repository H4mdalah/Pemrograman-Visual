/*
 * Created by SharpDevelop.
 * User: rober
 * Date: 01/03/2022
 * Time: 22:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace label
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Label1Click(object sender, EventArgs e)
		{
		}
		void button1Click(object sender, EventArgs e)
		{
			String Nama=textBox1.Text;
			listBox1.Items.Add(Nama);
			
			
		}
	}
}
