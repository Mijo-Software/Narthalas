namespace Narthalas
{
	partial class LamathForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LamathForm));
			toolStripContainer = new ToolStripContainer();
			kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			toolStripStatusLabelInfo = new ToolStripStatusLabel();
			toolStripProgressBar = new ToolStripProgressBar();
			kryptonPanel = new Krypton.Toolkit.KryptonPanel();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			kryptonStatusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPanel).BeginInit();
			SuspendLayout();
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(kryptonStatusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(kryptonPanel);
			toolStripContainer.ContentPanel.Size = new Size(344, 177);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(344, 201);
			toolStripContainer.TabIndex = 4;
			toolStripContainer.Text = "toolStripContainer";
			toolStripContainer.TopToolStripPanelVisible = false;
			// 
			// kryptonStatusStrip
			// 
			kryptonStatusStrip.AccessibleDescription = "Hält wichtige Elemente wie Infotext bereit";
			kryptonStatusStrip.AccessibleName = "Statusleiste";
			kryptonStatusStrip.AccessibleRole = AccessibleRole.StatusBar;
			kryptonStatusStrip.AllowClickThrough = true;
			kryptonStatusStrip.AllowItemReorder = true;
			kryptonStatusStrip.Dock = DockStyle.None;
			kryptonStatusStrip.Font = new Font("Segoe UI", 9F);
			kryptonStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo, toolStripProgressBar });
			kryptonStatusStrip.Location = new Point(0, 0);
			kryptonStatusStrip.Name = "kryptonStatusStrip";
			kryptonStatusStrip.ProgressBars = null;
			kryptonStatusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			kryptonStatusStrip.ShowItemToolTips = true;
			kryptonStatusStrip.Size = new Size(344, 24);
			kryptonStatusStrip.SizingGrip = false;
			kryptonStatusStrip.TabIndex = 3;
			kryptonStatusStrip.TabStop = true;
			kryptonStatusStrip.Text = "kryptonStatusStrip";
			// 
			// toolStripStatusLabelInfo
			// 
			toolStripStatusLabelInfo.AccessibleDescription = "Zeigt erklärende Informationen an";
			toolStripStatusLabelInfo.AccessibleName = "Information";
			toolStripStatusLabelInfo.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelInfo.AutoToolTip = true;
			toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
			toolStripStatusLabelInfo.Size = new Size(227, 19);
			toolStripStatusLabelInfo.Spring = true;
			toolStripStatusLabelInfo.Text = "info";
			toolStripStatusLabelInfo.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// toolStripProgressBar
			// 
			toolStripProgressBar.Name = "toolStripProgressBar";
			toolStripProgressBar.Size = new Size(100, 18);
			toolStripProgressBar.Step = 1;
			toolStripProgressBar.Style = ProgressBarStyle.Continuous;
			// 
			// kryptonPanel
			// 
			kryptonPanel.AccessibleDescription = "Just a Panel";
			kryptonPanel.AccessibleName = "Panel";
			kryptonPanel.AccessibleRole = AccessibleRole.Grouping;
			kryptonPanel.Dock = DockStyle.Fill;
			kryptonPanel.Location = new Point(0, 0);
			kryptonPanel.Name = "kryptonPanel";
			kryptonPanel.Size = new Size(344, 177);
			kryptonPanel.TabIndex = 2;
			kryptonPanel.TabStop = true;
			// 
			// LamathForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(344, 201);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			MaximizeBox = false;
			Name = "LamathForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Lamath - Konstruierung fremder Sprachen";
			KeyDown += LamathForm_KeyDown;
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			kryptonStatusStrip.ResumeLayout(false);
			kryptonStatusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPanel).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private ToolStripContainer toolStripContainer;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private ToolStripStatusLabel toolStripStatusLabelInfo;
		private ToolStripProgressBar toolStripProgressBar;
		private Krypton.Toolkit.KryptonPanel kryptonPanel;
	}
}