namespace Narthalas
{
	partial class EssinForm
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
			kryptonPanel = new Krypton.Toolkit.KryptonPanel();
			tabControlEssinSettings = new TabControl();
			tabPageMethodCV = new TabPage();
			tabPageMethodSyllables = new TabPage();
			kryptonButtonStart = new Krypton.Toolkit.KryptonButton();
			((System.ComponentModel.ISupportInitialize)kryptonPanel).BeginInit();
			kryptonPanel.SuspendLayout();
			tabControlEssinSettings.SuspendLayout();
			SuspendLayout();
			// 
			// kryptonPanel
			// 
			kryptonPanel.AccessibleDescription = "Just a Panel";
			kryptonPanel.AccessibleName = "Panel";
			kryptonPanel.AccessibleRole = AccessibleRole.Grouping;
			kryptonPanel.Controls.Add(tabControlEssinSettings);
			kryptonPanel.Controls.Add(kryptonButtonStart);
			kryptonPanel.Dock = DockStyle.Fill;
			kryptonPanel.Location = new Point(0, 0);
			kryptonPanel.Name = "kryptonPanel";
			kryptonPanel.Size = new Size(443, 240);
			kryptonPanel.TabIndex = 2;
			kryptonPanel.TabStop = true;
			// 
			// tabControlEssinSettings
			// 
			tabControlEssinSettings.Controls.Add(tabPageMethodCV);
			tabControlEssinSettings.Controls.Add(tabPageMethodSyllables);
			tabControlEssinSettings.Location = new Point(3, 3);
			tabControlEssinSettings.Name = "tabControlEssinSettings";
			tabControlEssinSettings.SelectedIndex = 0;
			tabControlEssinSettings.Size = new Size(437, 182);
			tabControlEssinSettings.TabIndex = 1;
			// 
			// tabPageMethodCV
			// 
			tabPageMethodCV.Location = new Point(4, 24);
			tabPageMethodCV.Name = "tabPageMethodCV";
			tabPageMethodCV.Padding = new Padding(3);
			tabPageMethodCV.Size = new Size(429, 154);
			tabPageMethodCV.TabIndex = 0;
			tabPageMethodCV.Text = "CV-basiert";
			tabPageMethodCV.ToolTipText = "CV-basiert";
			tabPageMethodCV.UseVisualStyleBackColor = true;
			// 
			// tabPageMethodSyllables
			// 
			tabPageMethodSyllables.Location = new Point(4, 24);
			tabPageMethodSyllables.Name = "tabPageMethodSyllables";
			tabPageMethodSyllables.Padding = new Padding(3);
			tabPageMethodSyllables.Size = new Size(192, 72);
			tabPageMethodSyllables.TabIndex = 1;
			tabPageMethodSyllables.Text = "Silbenbasiert";
			tabPageMethodSyllables.ToolTipText = "Silbenbasiert";
			tabPageMethodSyllables.UseVisualStyleBackColor = true;
			// 
			// kryptonButtonStart
			// 
			kryptonButtonStart.Location = new Point(135, 200);
			kryptonButtonStart.Name = "kryptonButtonStart";
			kryptonButtonStart.Size = new Size(225, 40);
			kryptonButtonStart.TabIndex = 0;
			kryptonButtonStart.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonStart.Values.Text = "kryptonButton1";
			kryptonButtonStart.Click += KryptonButtonStart_Click;
			// 
			// EssinForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(443, 240);
			Controls.Add(kryptonPanel);
			Name = "EssinForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EssinForm";
			((System.ComponentModel.ISupportInitialize)kryptonPanel).EndInit();
			kryptonPanel.ResumeLayout(false);
			tabControlEssinSettings.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Krypton.Toolkit.KryptonPanel kryptonPanel;
		private Krypton.Toolkit.KryptonButton kryptonButtonStart;
		private TabControl tabControlEssinSettings;
		private TabPage tabPageMethodCV;
		private TabPage tabPageMethodSyllables;
	}
}