namespace WinFormsApp
{
	partial class Form1
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
			label1 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(72, 114);
			label1.Name = "label1";
			label1.Size = new Size(125, 32);
			label1.TabIndex = 0;
			label1.Text = "Ange Text:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(72, 168);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(647, 39);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(258, 289);
			button1.Name = "button1";
			button1.Size = new Size(248, 72);
			button1.TabIndex = 2;
			button1.Text = "Lägg Till";
			button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Button button1;
	}
}