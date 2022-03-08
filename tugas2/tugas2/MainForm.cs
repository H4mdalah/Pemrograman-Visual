/*
 * Created by SharpDevelop.
 * User: rober
 * Date: 08/03/2022
 * Time: 22:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			listBox1.Items.Add(textBox1.Text);
			listBox1.Items.Add(textBox2.Text);
			listBox1.Items.Add(textBox3.Text);

			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		
		}
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
	}
}
