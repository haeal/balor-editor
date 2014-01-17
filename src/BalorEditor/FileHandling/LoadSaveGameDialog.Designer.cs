namespace BalorEditor
{
	partial class LoadSaveGameDialog
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
			this.cbGame1 = new System.Windows.Forms.RadioButton();
			this.cbGame4 = new System.Windows.Forms.RadioButton();
			this.cbGame2 = new System.Windows.Forms.RadioButton();
			this.cbGame5 = new System.Windows.Forms.RadioButton();
			this.cbGame3 = new System.Windows.Forms.RadioButton();
			this.cbGame6 = new System.Windows.Forms.RadioButton();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cbGame1
			// 
			this.cbGame1.AutoSize = true;
			this.cbGame1.Location = new System.Drawing.Point(13, 51);
			this.cbGame1.Name = "cbGame1";
			this.cbGame1.Size = new System.Drawing.Size(90, 17);
			this.cbGame1.TabIndex = 0;
			this.cbGame1.Text = "Save Game 1";
			this.cbGame1.UseVisualStyleBackColor = true;
			this.cbGame1.CheckedChanged += new System.EventHandler(this.cbGame1_CheckedChanged);
			// 
			// cbGame4
			// 
			this.cbGame4.AutoSize = true;
			this.cbGame4.Location = new System.Drawing.Point(110, 51);
			this.cbGame4.Name = "cbGame4";
			this.cbGame4.Size = new System.Drawing.Size(90, 17);
			this.cbGame4.TabIndex = 0;
			this.cbGame4.Text = "Save Game 4";
			this.cbGame4.UseVisualStyleBackColor = true;
			this.cbGame4.CheckedChanged += new System.EventHandler(this.cbGame4_CheckedChanged);
			// 
			// cbGame2
			// 
			this.cbGame2.AutoSize = true;
			this.cbGame2.Location = new System.Drawing.Point(13, 74);
			this.cbGame2.Name = "cbGame2";
			this.cbGame2.Size = new System.Drawing.Size(90, 17);
			this.cbGame2.TabIndex = 0;
			this.cbGame2.Text = "Save Game 2";
			this.cbGame2.UseVisualStyleBackColor = true;
			this.cbGame2.CheckedChanged += new System.EventHandler(this.cbGame2_CheckedChanged);
			// 
			// cbGame5
			// 
			this.cbGame5.AutoSize = true;
			this.cbGame5.Location = new System.Drawing.Point(110, 74);
			this.cbGame5.Name = "cbGame5";
			this.cbGame5.Size = new System.Drawing.Size(90, 17);
			this.cbGame5.TabIndex = 0;
			this.cbGame5.Text = "Save Game 5";
			this.cbGame5.UseVisualStyleBackColor = true;
			this.cbGame5.CheckedChanged += new System.EventHandler(this.cbGame5_CheckedChanged);
			// 
			// cbGame3
			// 
			this.cbGame3.AutoSize = true;
			this.cbGame3.Location = new System.Drawing.Point(13, 97);
			this.cbGame3.Name = "cbGame3";
			this.cbGame3.Size = new System.Drawing.Size(90, 17);
			this.cbGame3.TabIndex = 0;
			this.cbGame3.Text = "Save Game 3";
			this.cbGame3.UseVisualStyleBackColor = true;
			this.cbGame3.CheckedChanged += new System.EventHandler(this.cbGame3_CheckedChanged);
			// 
			// cbGame6
			// 
			this.cbGame6.AutoSize = true;
			this.cbGame6.Location = new System.Drawing.Point(110, 97);
			this.cbGame6.Name = "cbGame6";
			this.cbGame6.Size = new System.Drawing.Size(90, 17);
			this.cbGame6.TabIndex = 0;
			this.cbGame6.Text = "Save Game 6";
			this.cbGame6.UseVisualStyleBackColor = true;
			this.cbGame6.CheckedChanged += new System.EventHandler(this.cbGame6_CheckedChanged);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(12, 128);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(126, 128);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Path:";
			// 
			// tbPath
			// 
			this.tbPath.Location = new System.Drawing.Point(13, 25);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(188, 20);
			this.tbPath.TabIndex = 3;
			this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
			// 
			// LoadSaveGameDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(213, 162);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.cbGame6);
			this.Controls.Add(this.cbGame5);
			this.Controls.Add(this.cbGame4);
			this.Controls.Add(this.cbGame3);
			this.Controls.Add(this.cbGame2);
			this.Controls.Add(this.cbGame1);
			this.Name = "LoadSaveGameDialog";
			this.Text = "Load...";
			this.Load += new System.EventHandler(this.LoadSaveGameDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton cbGame1;
		private System.Windows.Forms.RadioButton cbGame4;
		private System.Windows.Forms.RadioButton cbGame2;
		private System.Windows.Forms.RadioButton cbGame5;
		private System.Windows.Forms.RadioButton cbGame3;
		private System.Windows.Forms.RadioButton cbGame6;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPath;
	}
}