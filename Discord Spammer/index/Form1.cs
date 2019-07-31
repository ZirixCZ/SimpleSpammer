using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSpammer
{
	public partial class DiscordSPammer : Form
	{
		public DiscordSPammer()
		{
			InitializeComponent();
		}

		private void YeToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void Timer1_Tick(object sender, EventArgs e)
		{

			if(textBox2.Visible == false && textBox3.Visible == false)
			{
				SendKeys.Send(textBox1.Text);
				SendKeys.Send("{ENTER}");
			}

			if (textBox2.Visible == true && textBox3.Visible == false)
			{
				SendKeys.Send(textBox2.Text);
				SendKeys.Send("{ENTER}");
				SendKeys.Send(textBox1.Text);
				SendKeys.Send("{ENTER}");
			}

			if (textBox2.Visible == true && textBox3.Visible == true)
			{
				SendKeys.Send(textBox3.Text);
				SendKeys.Send("{ENTER}");
				SendKeys.Send(textBox2.Text);
				SendKeys.Send("{ENTER}");
				SendKeys.Send(textBox1.Text);
				SendKeys.Send("{ENTER}");
			}
		}

		private void Start_btn_Click(object sender, EventArgs e)
		{
			timer1.Start();


		}

		private void Stop_btn_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}

		private void Simple_100ms_Click(object sender, EventArgs e)
		{
			timer1.Interval = 100;
		}

		private void Simple_500ms_Click(object sender, EventArgs e)
		{
			timer1.Interval = 500;
		}

		private void Simple_1s_Click(object sender, EventArgs e)
		{
			timer1.Interval = 1000;
		}

		private void Advanced_50ms_Click(object sender, EventArgs e)
		{
			timer1.Interval = 50;
		}

		private void Advanced_100ms_Click(object sender, EventArgs e)
		{
			timer1.Interval = 100;
		}

		private void Advanced_250ms_Click(object sender, EventArgs e)
		{
			timer1.Interval = 250;
		}

		private void Advanced_500ms_Click(object sender, EventArgs e)
		{
			timer1.Interval = 500;
		}

		private void Advanced_750ms_Click(object sender, EventArgs e)
		{
			timer1.Interval = 750;
		}

		private void Advanced_1s_Click(object sender, EventArgs e)
		{
			timer1.Interval = 1000;
		}

		private void Advanced_5s_Click(object sender, EventArgs e)
		{
			timer1.Interval = 5000;
		}

		private void Advanced_10s_Click(object sender, EventArgs e)
		{
			timer1.Interval = 10000;
		}

		private void Advanced_30s_Click(object sender, EventArgs e)
		{
			timer1.Interval = 30000;
		}

		private void Advanced_60s_Click(object sender, EventArgs e)
		{
			timer1.Interval = 60000;
		}

		private void OneTxtB_Click(object sender, EventArgs e)
		{
			textBox1.Visible = true;
			textBox2.Visible = false;
			textBox3.Visible = false;
		}

		private void TwoTxtB_Click(object sender, EventArgs e)
		{
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = false;
		}

		private void ThreeTxtB_Click(object sender, EventArgs e)
		{
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;
		}
	}
}
