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
public partial class Loading : Form
{
	public Loading()
	{
		InitializeComponent();
	}

	private void Loading_Load(object sender, EventArgs e)
	{

			this.timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
	{
			
			if (progressBar1.Value >= progressBar1.Maximum)
			{
				// Stop the timer.
				timer1.Stop();

				// Show the second form.
				DiscordSPammer f2 = new DiscordSPammer();
				f2.Show();
				this.Hide();

			}
			this.progressBar1.Increment(1);
	}

		private void Label_1_Click(object sender, EventArgs e)
		{

		}
	}
}
