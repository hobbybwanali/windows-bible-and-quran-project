/*
 * Created by SharpDevelop. Hobby Mwase
 * User: Hobby Mwase
 * Date: 7/24/2021
 * Time: 2:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UnityScriptures
{
	partial class RandomVerseDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		public System.Windows.Forms.Button copyVerseVerseDialogBtn;
		public System.Windows.Forms.Button addVerseVerseDialogBtn;
		public System.Windows.Forms.Label randVerseLabel;
		private System.Windows.Forms.ToolTip RandomVerseToolTip;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomVerseDialog));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.copyVerseVerseDialogBtn = new System.Windows.Forms.Button();
			this.addVerseVerseDialogBtn = new System.Windows.Forms.Button();
			this.randVerseLabel = new System.Windows.Forms.Label();
			this.RandomVerseToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.copyVerseVerseDialogBtn);
			this.flowLayoutPanel1.Controls.Add(this.addVerseVerseDialogBtn);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 202);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(479, 43);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// copyVerseVerseDialogBtn
			// 
			this.copyVerseVerseDialogBtn.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.copyVerseVerseDialogBtn.ForeColor = System.Drawing.Color.DarkCyan;
			this.copyVerseVerseDialogBtn.Location = new System.Drawing.Point(432, 3);
			this.copyVerseVerseDialogBtn.Name = "copyVerseVerseDialogBtn";
			this.copyVerseVerseDialogBtn.Size = new System.Drawing.Size(44, 31);
			this.copyVerseVerseDialogBtn.TabIndex = 0;
			this.copyVerseVerseDialogBtn.Text = "2";
			this.RandomVerseToolTip.SetToolTip(this.copyVerseVerseDialogBtn, "Copy the verse to clipboard");
			this.copyVerseVerseDialogBtn.UseVisualStyleBackColor = true;
			this.copyVerseVerseDialogBtn.Click += new System.EventHandler(this.CopyVerseVerseDialogBtnClick);
			// 
			// addVerseVerseDialogBtn
			// 
			this.addVerseVerseDialogBtn.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.addVerseVerseDialogBtn.ForeColor = System.Drawing.Color.DarkCyan;
			this.addVerseVerseDialogBtn.Location = new System.Drawing.Point(379, 3);
			this.addVerseVerseDialogBtn.Name = "addVerseVerseDialogBtn";
			this.addVerseVerseDialogBtn.Size = new System.Drawing.Size(47, 31);
			this.addVerseVerseDialogBtn.TabIndex = 1;
			this.addVerseVerseDialogBtn.Text = "P";
			this.RandomVerseToolTip.SetToolTip(this.addVerseVerseDialogBtn, "Add verse to favourites");
			this.addVerseVerseDialogBtn.UseVisualStyleBackColor = true;
			this.addVerseVerseDialogBtn.Click += new System.EventHandler(this.AddVerseVerseDialogBtnClick);
			// 
			// randVerseLabel
			// 
			this.randVerseLabel.AutoEllipsis = true;
			this.randVerseLabel.BackColor = System.Drawing.Color.Transparent;
			this.randVerseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.randVerseLabel.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.randVerseLabel.ForeColor = System.Drawing.Color.White;
			this.randVerseLabel.Location = new System.Drawing.Point(0, 0);
			this.randVerseLabel.Name = "randVerseLabel";
			this.randVerseLabel.Size = new System.Drawing.Size(479, 202);
			this.randVerseLabel.TabIndex = 1;
			this.randVerseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RandomVerseDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(479, 245);
			this.Controls.Add(this.randVerseLabel);
			this.Controls.Add(this.flowLayoutPanel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "RandomVerseDialog";
			this.ShowInTaskbar = false;
			this.Text = "Random Verse";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
