namespace BalorEditor
{
	partial class ItemSelector
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnStart = new System.Windows.Forms.Button();
			this.btnPrev = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.lbCurrentItem = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(3, 3);
			this.btnStart.MaximumSize = new System.Drawing.Size(30, 23);
			this.btnStart.MinimumSize = new System.Drawing.Size(30, 23);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(30, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "<<";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnPrev
			// 
			this.btnPrev.Location = new System.Drawing.Point(39, 3);
			this.btnPrev.MaximumSize = new System.Drawing.Size(30, 23);
			this.btnPrev.MinimumSize = new System.Drawing.Size(30, 23);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(30, 23);
			this.btnPrev.TabIndex = 1;
			this.btnPrev.Text = "<";
			this.btnPrev.UseVisualStyleBackColor = true;
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Location = new System.Drawing.Point(151, 3);
			this.btnNext.MaximumSize = new System.Drawing.Size(30, 23);
			this.btnNext.MinimumSize = new System.Drawing.Size(30, 23);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(30, 23);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = ">";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnLast
			// 
			this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLast.Location = new System.Drawing.Point(187, 3);
			this.btnLast.MaximumSize = new System.Drawing.Size(30, 23);
			this.btnLast.MinimumSize = new System.Drawing.Size(30, 23);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(30, 23);
			this.btnLast.TabIndex = 3;
			this.btnLast.Text = ">>";
			this.btnLast.UseVisualStyleBackColor = true;
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// lbCurrentItem
			// 
			this.lbCurrentItem.AutoSize = true;
			this.lbCurrentItem.Location = new System.Drawing.Point(75, 8);
			this.lbCurrentItem.Name = "lbCurrentItem";
			this.lbCurrentItem.Size = new System.Drawing.Size(0, 13);
			this.lbCurrentItem.TabIndex = 4;
			// 
			// ItemSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbCurrentItem);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrev);
			this.Controls.Add(this.btnStart);
			this.Name = "ItemSelector";
			this.Size = new System.Drawing.Size(220, 30);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnPrev;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Label lbCurrentItem;
	}
}
