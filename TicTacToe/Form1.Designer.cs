namespace TicTacToe
{
	partial class formTicTacToe
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pb1 = new PictureBox();
			pb2 = new PictureBox();
			pb3 = new PictureBox();
			pb4 = new PictureBox();
			pb5 = new PictureBox();
			pb6 = new PictureBox();
			pb7 = new PictureBox();
			pb8 = new PictureBox();
			pb9 = new PictureBox();
			lblHeading = new Label();
			((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pb4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pb5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pb6).BeginInit();
			((System.ComponentModel.ISupportInitialize)pb7).BeginInit();
			((System.ComponentModel.ISupportInitialize)pb8).BeginInit();
			((System.ComponentModel.ISupportInitialize)pb9).BeginInit();
			SuspendLayout();
			// 
			// pb1
			// 
			pb1.BorderStyle = BorderStyle.FixedSingle;
			pb1.Location = new Point(171, 89);
			pb1.Name = "pb1";
			pb1.Size = new Size(80, 80);
			pb1.TabIndex = 0;
			pb1.TabStop = false;
			pb1.Click += UpdateBox;
			// 
			// pb2
			// 
			pb2.BorderStyle = BorderStyle.FixedSingle;
			pb2.Location = new Point(248, 89);
			pb2.Name = "pb2";
			pb2.Size = new Size(80, 80);
			pb2.TabIndex = 1;
			pb2.TabStop = false;
			pb2.Click += UpdateBox;
			// 
			// pb3
			// 
			pb3.BorderStyle = BorderStyle.FixedSingle;
			pb3.Location = new Point(325, 89);
			pb3.Name = "pb3";
			pb3.Size = new Size(80, 80);
			pb3.TabIndex = 2;
			pb3.TabStop = false;
			pb3.Click += UpdateBox;
			// 
			// pb4
			// 
			pb4.BorderStyle = BorderStyle.FixedSingle;
			pb4.Location = new Point(171, 168);
			pb4.Name = "pb4";
			pb4.Size = new Size(80, 80);
			pb4.TabIndex = 3;
			pb4.TabStop = false;
			pb4.Click += UpdateBox;
			// 
			// pb5
			// 
			pb5.BorderStyle = BorderStyle.FixedSingle;
			pb5.Location = new Point(248, 168);
			pb5.Name = "pb5";
			pb5.Size = new Size(80, 80);
			pb5.TabIndex = 4;
			pb5.TabStop = false;
			pb5.Click += UpdateBox;
			// 
			// pb6
			// 
			pb6.BackgroundImageLayout = ImageLayout.Center;
			pb6.BorderStyle = BorderStyle.FixedSingle;
			pb6.Location = new Point(325, 168);
			pb6.Name = "pb6";
			pb6.Size = new Size(80, 80);
			pb6.TabIndex = 5;
			pb6.TabStop = false;
			pb6.Click += UpdateBox;
			// 
			// pb7
			// 
			pb7.BorderStyle = BorderStyle.FixedSingle;
			pb7.Location = new Point(171, 245);
			pb7.Name = "pb7";
			pb7.Size = new Size(80, 80);
			pb7.TabIndex = 6;
			pb7.TabStop = false;
			pb7.Click += UpdateBox;
			// 
			// pb8
			// 
			pb8.BorderStyle = BorderStyle.FixedSingle;
			pb8.Location = new Point(248, 245);
			pb8.Name = "pb8";
			pb8.Size = new Size(80, 80);
			pb8.TabIndex = 7;
			pb8.TabStop = false;
			pb8.Click += UpdateBox;
			// 
			// pb9
			// 
			pb9.BorderStyle = BorderStyle.FixedSingle;
			pb9.Location = new Point(325, 245);
			pb9.Name = "pb9";
			pb9.Size = new Size(80, 80);
			pb9.TabIndex = 8;
			pb9.TabStop = false;
			pb9.Click += UpdateBox;
			// 
			// lblHeading
			// 
			lblHeading.AutoSize = true;
			lblHeading.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			lblHeading.ForeColor = Color.White;
			lblHeading.Location = new Point(209, 34);
			lblHeading.Name = "lblHeading";
			lblHeading.Size = new Size(145, 29);
			lblHeading.TabIndex = 9;
			lblHeading.Text = "Tic Tac Toe";
			// 
			// formTicTacToe
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(586, 377);
			Controls.Add(lblHeading);
			Controls.Add(pb9);
			Controls.Add(pb8);
			Controls.Add(pb7);
			Controls.Add(pb6);
			Controls.Add(pb5);
			Controls.Add(pb4);
			Controls.Add(pb3);
			Controls.Add(pb2);
			Controls.Add(pb1);
			Name = "formTicTacToe";
			Text = "Tic Tac Toe";
			((System.ComponentModel.ISupportInitialize)pb1).EndInit();
			((System.ComponentModel.ISupportInitialize)pb2).EndInit();
			((System.ComponentModel.ISupportInitialize)pb3).EndInit();
			((System.ComponentModel.ISupportInitialize)pb4).EndInit();
			((System.ComponentModel.ISupportInitialize)pb5).EndInit();
			((System.ComponentModel.ISupportInitialize)pb6).EndInit();
			((System.ComponentModel.ISupportInitialize)pb7).EndInit();
			((System.ComponentModel.ISupportInitialize)pb8).EndInit();
			((System.ComponentModel.ISupportInitialize)pb9).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pb1;
		private PictureBox pb2;
		private PictureBox pb3;
		private PictureBox pb4;
		private PictureBox pb5;
		private PictureBox pb6;
		private PictureBox pb7;
		private PictureBox pb8;
		private PictureBox pb9;
		private Label lblHeading;
	}
}