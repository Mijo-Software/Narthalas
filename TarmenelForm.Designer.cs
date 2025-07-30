namespace Narthalas
{
	partial class TarmenelForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarmenelForm));
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
			resources.ApplyResources(toolStripContainer, "toolStripContainer");
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			resources.ApplyResources(toolStripContainer.BottomToolStripPanel, "toolStripContainer.BottomToolStripPanel");
			toolStripContainer.BottomToolStripPanel.Controls.Add(kryptonStatusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			resources.ApplyResources(toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel");
			toolStripContainer.ContentPanel.Controls.Add(kryptonPanel);
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			resources.ApplyResources(toolStripContainer.LeftToolStripPanel, "toolStripContainer.LeftToolStripPanel");
			toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			resources.ApplyResources(toolStripContainer.RightToolStripPanel, "toolStripContainer.RightToolStripPanel");
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			resources.ApplyResources(toolStripContainer.TopToolStripPanel, "toolStripContainer.TopToolStripPanel");
			toolStripContainer.TopToolStripPanelVisible = false;
			// 
			// kryptonStatusStrip
			// 
			resources.ApplyResources(kryptonStatusStrip, "kryptonStatusStrip");
			kryptonStatusStrip.AccessibleRole = AccessibleRole.StatusBar;
			kryptonStatusStrip.AllowClickThrough = true;
			kryptonStatusStrip.AllowItemReorder = true;
			kryptonStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo, toolStripProgressBar });
			kryptonStatusStrip.Name = "kryptonStatusStrip";
			kryptonStatusStrip.ProgressBars = null;
			kryptonStatusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			kryptonStatusStrip.ShowItemToolTips = true;
			kryptonStatusStrip.SizingGrip = false;
			kryptonStatusStrip.TabStop = true;
			// 
			// toolStripStatusLabelInfo
			// 
			resources.ApplyResources(toolStripStatusLabelInfo, "toolStripStatusLabelInfo");
			toolStripStatusLabelInfo.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelInfo.AutoToolTip = true;
			toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
			toolStripStatusLabelInfo.Spring = true;
			// 
			// toolStripProgressBar
			// 
			resources.ApplyResources(toolStripProgressBar, "toolStripProgressBar");
			toolStripProgressBar.Name = "toolStripProgressBar";
			toolStripProgressBar.Step = 1;
			toolStripProgressBar.Style = ProgressBarStyle.Continuous;
			// 
			// kryptonPanel
			// 
			resources.ApplyResources(kryptonPanel, "kryptonPanel");
			kryptonPanel.AccessibleRole = AccessibleRole.Grouping;
			kryptonPanel.Name = "kryptonPanel";
			kryptonPanel.TabStop = true;
			// 
			// TarmenelForm
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			KeyPreview = true;
			MaximizeBox = false;
			Name = "TarmenelForm";
			ShowInTaskbar = false;
			KeyDown += TarmenelForm_KeyDown;
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

		private Krypton.Toolkit.KryptonPanel kryptonPanel;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private ToolStripStatusLabel toolStripStatusLabelInfo;
		private ToolStripProgressBar toolStripProgressBar;
		private ToolStripContainer toolStripContainer;
	}
}