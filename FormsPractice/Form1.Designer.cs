namespace FormsPractice
{
	partial class Form1
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
			this.thebutton = new System.Windows.Forms.Button();
			this.Monkebox = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Monkebox)).BeginInit();
			this.SuspendLayout();
			// 
			// thebutton
			// 
			this.thebutton.Location = new System.Drawing.Point(12, 32);
			this.thebutton.Name = "thebutton";
			this.thebutton.Size = new System.Drawing.Size(186, 176);
			this.thebutton.TabIndex = 0;
			this.thebutton.Text = "Reveal the truth";
			this.thebutton.UseVisualStyleBackColor = true;
			this.thebutton.Click += new System.EventHandler(this.button1_Click);
			// 
			// Monkebox
			// 
			this.Monkebox.ImageLocation = "watermonke.png";
			this.Monkebox.Location = new System.Drawing.Point(235, 32);
			this.Monkebox.Name = "Monkebox";
			this.Monkebox.Size = new System.Drawing.Size(553, 391);
			this.Monkebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Monkebox.TabIndex = 0;
			this.Monkebox.TabStop = false;
			this.Monkebox.Visible = false;
			this.Monkebox.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 247);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 176);
			this.button1.TabIndex = 1;
			this.button1.Text = "Next truth";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 16;
			this.timer1.Tick += new System.EventHandler(this.Update);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(113, 247);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 176);
			this.button2.TabIndex = 2;
			this.button2.Text = "Cycle truth";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.oncycle);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Monkebox);
			this.Controls.Add(this.thebutton);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.Monkebox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button thebutton;
		public System.Windows.Forms.PictureBox Monkebox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button2;
	}
}

