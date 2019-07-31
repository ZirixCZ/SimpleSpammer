namespace SimpleSpammer
{
	partial class Loading
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.Label_1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.BackColor = System.Drawing.Color.White;
			this.progressBar1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.progressBar1.Location = new System.Drawing.Point(77, 103);
			this.progressBar1.MarqueeAnimationSpeed = 50;
			this.progressBar1.Maximum = 15;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(681, 28);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 20;
			this.progressBar1.Value = 1;
			this.progressBar1.Click += new System.EventHandler(this.timer1_Tick);
			// 
			// Label_1
			// 
			this.Label_1.AutoSize = true;
			this.Label_1.BackColor = System.Drawing.Color.Transparent;
			this.Label_1.Font = new System.Drawing.Font("outrun future", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_1.ForeColor = System.Drawing.Color.White;
			this.Label_1.Location = new System.Drawing.Point(175, 0);
			this.Label_1.Name = "Label_1";
			this.Label_1.Size = new System.Drawing.Size(477, 67);
			this.Label_1.TabIndex = 3;
			this.Label_1.Text = "DISCORD SPAMMER";
			this.Label_1.Click += new System.EventHandler(this.Label_1_Click);
			// 
			// Loading
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SimpleSpammer.Properties.Resources.eS4IxK3;
			this.ClientSize = new System.Drawing.Size(830, 143);
			this.Controls.Add(this.Label_1);
			this.Controls.Add(this.progressBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Loading";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loading";
			this.Load += new System.EventHandler(this.Loading_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label Label_1;
	}
}