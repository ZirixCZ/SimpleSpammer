namespace SimpleSpammer
{
	partial class DiscordSPammer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordSPammer));
			this.start_btn = new System.Windows.Forms.Button();
			this.stop_btn = new System.Windows.Forms.Button();
			this.Label_1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.Speed_menu = new System.Windows.Forms.ToolStripMenuItem();
			this.Simple_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.Simple_100ms = new System.Windows.Forms.ToolStripMenuItem();
			this.Simple_500ms = new System.Windows.Forms.ToolStripMenuItem();
			this.Simple_1s = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_50ms = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_100ms = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_250ms = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_500ms = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_750ms = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_1s = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_5s = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_10s = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_30s = new System.Windows.Forms.ToolStripMenuItem();
			this.Advanced_60s = new System.Windows.Forms.ToolStripMenuItem();
			this.TextBoxes_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.OneTxtB = new System.Windows.Forms.ToolStripMenuItem();
			this.TwoTxtB = new System.Windows.Forms.ToolStripMenuItem();
			this.ThreeTxtB = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// start_btn
			// 
			this.start_btn.BackColor = System.Drawing.Color.White;
			this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.start_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.start_btn.Location = new System.Drawing.Point(49, 150);
			this.start_btn.Name = "start_btn";
			this.start_btn.Size = new System.Drawing.Size(257, 41);
			this.start_btn.TabIndex = 0;
			this.start_btn.Text = "Start";
			this.start_btn.UseVisualStyleBackColor = false;
			this.start_btn.Click += new System.EventHandler(this.Start_btn_Click);
			// 
			// stop_btn
			// 
			this.stop_btn.BackColor = System.Drawing.Color.White;
			this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.stop_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.stop_btn.Location = new System.Drawing.Point(461, 150);
			this.stop_btn.Name = "stop_btn";
			this.stop_btn.Size = new System.Drawing.Size(257, 41);
			this.stop_btn.TabIndex = 1;
			this.stop_btn.Text = "Stop";
			this.stop_btn.UseVisualStyleBackColor = false;
			this.stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
			// 
			// Label_1
			// 
			this.Label_1.AutoSize = true;
			this.Label_1.BackColor = System.Drawing.Color.Transparent;
			this.Label_1.Font = new System.Drawing.Font("outrun future", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_1.ForeColor = System.Drawing.Color.White;
			this.Label_1.Location = new System.Drawing.Point(139, 0);
			this.Label_1.Name = "Label_1";
			this.Label_1.Size = new System.Drawing.Size(477, 67);
			this.Label_1.TabIndex = 2;
			this.Label_1.Text = "DISCORD SPAMMER";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(118, 120);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(531, 20);
			this.textBox1.TabIndex = 3;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(760, 43);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// SettingsMenu
			// 
			this.SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Speed_menu,
            this.TextBoxes_Menu});
			this.SettingsMenu.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SettingsMenu.ForeColor = System.Drawing.Color.White;
			this.SettingsMenu.Name = "SettingsMenu";
			this.SettingsMenu.Size = new System.Drawing.Size(124, 39);
			this.SettingsMenu.Text = "Settings";
			// 
			// Speed_menu
			// 
			this.Speed_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Simple_Menu,
            this.Advanced_Menu});
			this.Speed_menu.Name = "Speed_menu";
			this.Speed_menu.Size = new System.Drawing.Size(222, 40);
			this.Speed_menu.Text = "Speed";
			this.Speed_menu.Click += new System.EventHandler(this.YeToolStripMenuItem_Click);
			// 
			// Simple_Menu
			// 
			this.Simple_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Simple_100ms,
            this.Simple_500ms,
            this.Simple_1s});
			this.Simple_Menu.Name = "Simple_Menu";
			this.Simple_Menu.Size = new System.Drawing.Size(199, 40);
			this.Simple_Menu.Text = "Simple";
			// 
			// Simple_100ms
			// 
			this.Simple_100ms.Name = "Simple_100ms";
			this.Simple_100ms.Size = new System.Drawing.Size(166, 40);
			this.Simple_100ms.Text = "100ms";
			this.Simple_100ms.Click += new System.EventHandler(this.Simple_100ms_Click);
			// 
			// Simple_500ms
			// 
			this.Simple_500ms.Name = "Simple_500ms";
			this.Simple_500ms.Size = new System.Drawing.Size(166, 40);
			this.Simple_500ms.Text = "500ms";
			this.Simple_500ms.Click += new System.EventHandler(this.Simple_500ms_Click);
			// 
			// Simple_1s
			// 
			this.Simple_1s.Name = "Simple_1s";
			this.Simple_1s.Size = new System.Drawing.Size(166, 40);
			this.Simple_1s.Text = "1s";
			this.Simple_1s.Click += new System.EventHandler(this.Simple_1s_Click);
			// 
			// Advanced_Menu
			// 
			this.Advanced_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Advanced_50ms,
            this.Advanced_100ms,
            this.Advanced_250ms,
            this.Advanced_500ms,
            this.Advanced_750ms,
            this.Advanced_1s,
            this.Advanced_5s,
            this.Advanced_10s,
            this.Advanced_30s,
            this.Advanced_60s});
			this.Advanced_Menu.Name = "Advanced_Menu";
			this.Advanced_Menu.Size = new System.Drawing.Size(199, 40);
			this.Advanced_Menu.Text = "Advanced";
			// 
			// Advanced_50ms
			// 
			this.Advanced_50ms.Name = "Advanced_50ms";
			this.Advanced_50ms.Size = new System.Drawing.Size(166, 40);
			this.Advanced_50ms.Text = "50ms";
			this.Advanced_50ms.Click += new System.EventHandler(this.Advanced_50ms_Click);
			// 
			// Advanced_100ms
			// 
			this.Advanced_100ms.Name = "Advanced_100ms";
			this.Advanced_100ms.Size = new System.Drawing.Size(166, 40);
			this.Advanced_100ms.Text = "100ms";
			this.Advanced_100ms.Click += new System.EventHandler(this.Advanced_100ms_Click);
			// 
			// Advanced_250ms
			// 
			this.Advanced_250ms.Name = "Advanced_250ms";
			this.Advanced_250ms.Size = new System.Drawing.Size(166, 40);
			this.Advanced_250ms.Text = "250ms";
			this.Advanced_250ms.Click += new System.EventHandler(this.Advanced_250ms_Click);
			// 
			// Advanced_500ms
			// 
			this.Advanced_500ms.Name = "Advanced_500ms";
			this.Advanced_500ms.Size = new System.Drawing.Size(166, 40);
			this.Advanced_500ms.Text = "500ms";
			this.Advanced_500ms.Click += new System.EventHandler(this.Advanced_500ms_Click);
			// 
			// Advanced_750ms
			// 
			this.Advanced_750ms.Name = "Advanced_750ms";
			this.Advanced_750ms.Size = new System.Drawing.Size(166, 40);
			this.Advanced_750ms.Text = "750ms";
			this.Advanced_750ms.Click += new System.EventHandler(this.Advanced_750ms_Click);
			// 
			// Advanced_1s
			// 
			this.Advanced_1s.Name = "Advanced_1s";
			this.Advanced_1s.Size = new System.Drawing.Size(166, 40);
			this.Advanced_1s.Text = "1s";
			this.Advanced_1s.Click += new System.EventHandler(this.Advanced_1s_Click);
			// 
			// Advanced_5s
			// 
			this.Advanced_5s.Name = "Advanced_5s";
			this.Advanced_5s.Size = new System.Drawing.Size(166, 40);
			this.Advanced_5s.Text = "5s";
			this.Advanced_5s.Click += new System.EventHandler(this.Advanced_5s_Click);
			// 
			// Advanced_10s
			// 
			this.Advanced_10s.Name = "Advanced_10s";
			this.Advanced_10s.Size = new System.Drawing.Size(166, 40);
			this.Advanced_10s.Text = "10s";
			this.Advanced_10s.Click += new System.EventHandler(this.Advanced_10s_Click);
			// 
			// Advanced_30s
			// 
			this.Advanced_30s.Name = "Advanced_30s";
			this.Advanced_30s.Size = new System.Drawing.Size(166, 40);
			this.Advanced_30s.Text = "30s";
			this.Advanced_30s.Click += new System.EventHandler(this.Advanced_30s_Click);
			// 
			// Advanced_60s
			// 
			this.Advanced_60s.Name = "Advanced_60s";
			this.Advanced_60s.Size = new System.Drawing.Size(166, 40);
			this.Advanced_60s.Text = "60s";
			this.Advanced_60s.Click += new System.EventHandler(this.Advanced_60s_Click);
			// 
			// TextBoxes_Menu
			// 
			this.TextBoxes_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OneTxtB,
            this.TwoTxtB,
            this.ThreeTxtB});
			this.TextBoxes_Menu.Name = "TextBoxes_Menu";
			this.TextBoxes_Menu.Size = new System.Drawing.Size(222, 40);
			this.TextBoxes_Menu.Text = "Text Boxes";
			// 
			// OneTxtB
			// 
			this.OneTxtB.Name = "OneTxtB";
			this.OneTxtB.Size = new System.Drawing.Size(218, 40);
			this.OneTxtB.Text = "1 (Default)";
			this.OneTxtB.Click += new System.EventHandler(this.OneTxtB_Click);
			// 
			// TwoTxtB
			// 
			this.TwoTxtB.Name = "TwoTxtB";
			this.TwoTxtB.Size = new System.Drawing.Size(218, 40);
			this.TwoTxtB.Text = "2";
			this.TwoTxtB.Click += new System.EventHandler(this.TwoTxtB_Click);
			// 
			// ThreeTxtB
			// 
			this.ThreeTxtB.Name = "ThreeTxtB";
			this.ThreeTxtB.Size = new System.Drawing.Size(218, 40);
			this.ThreeTxtB.Text = "3";
			this.ThreeTxtB.Click += new System.EventHandler(this.ThreeTxtB_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(118, 68);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(531, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(118, 94);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(531, 20);
			this.textBox2.TabIndex = 6;
			this.textBox2.Visible = false;
			// 
			// DiscordSPammer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SimpleSpammer.Properties.Resources.eS4IxK3;
			this.ClientSize = new System.Drawing.Size(760, 202);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Label_1);
			this.Controls.Add(this.stop_btn);
			this.Controls.Add(this.start_btn);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(776, 241);
			this.MinimumSize = new System.Drawing.Size(751, 241);
			this.Name = "DiscordSPammer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Discord Spammer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button start_btn;
		private System.Windows.Forms.Button stop_btn;
		private System.Windows.Forms.Label Label_1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem SettingsMenu;
		private System.Windows.Forms.ToolStripMenuItem Speed_menu;
		private System.Windows.Forms.ToolStripMenuItem Simple_Menu;
		private System.Windows.Forms.ToolStripMenuItem Simple_100ms;
		private System.Windows.Forms.ToolStripMenuItem Simple_500ms;
		private System.Windows.Forms.ToolStripMenuItem Simple_1s;
		private System.Windows.Forms.ToolStripMenuItem Advanced_Menu;
		private System.Windows.Forms.ToolStripMenuItem Advanced_50ms;
		private System.Windows.Forms.ToolStripMenuItem Advanced_100ms;
		private System.Windows.Forms.ToolStripMenuItem Advanced_250ms;
		private System.Windows.Forms.ToolStripMenuItem Advanced_500ms;
		private System.Windows.Forms.ToolStripMenuItem Advanced_750ms;
		private System.Windows.Forms.ToolStripMenuItem Advanced_1s;
		private System.Windows.Forms.ToolStripMenuItem Advanced_5s;
		private System.Windows.Forms.ToolStripMenuItem Advanced_10s;
		private System.Windows.Forms.ToolStripMenuItem Advanced_30s;
		private System.Windows.Forms.ToolStripMenuItem Advanced_60s;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem TextBoxes_Menu;
		private System.Windows.Forms.ToolStripMenuItem OneTxtB;
		private System.Windows.Forms.ToolStripMenuItem TwoTxtB;
		private System.Windows.Forms.ToolStripMenuItem ThreeTxtB;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
	}
}

