namespace Narthalas
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			toolStripContainer = new ToolStripContainer();
			kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			toolStripStatusLabelInfo = new ToolStripStatusLabel();
			kryptonPanel = new Krypton.Toolkit.KryptonPanel();
			tabControl = new TabControl();
			tabPageSettingsNarthalas = new TabPage();
			kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
			tabPageSettingsTarmenel = new TabPage();
			tabPageSettingsDoriath = new TabPage();
			tabPageSettingsOstiath = new TabPage();
			tabPageSettingsLamath = new TabPage();
			tabPageSettingsEssin = new TabPage();
			groupBoxEssinOutputOptions = new GroupBox();
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSemicolon = new Krypton.Toolkit.KryptonRadioButton();
			kryptonRadioButtonEssinOutputOptionsSeparatorIsPipe = new Krypton.Toolkit.KryptonRadioButton();
			kryptonRadioButtonEssinOutputOptionsSeparatorIsComma = new Krypton.Toolkit.KryptonRadioButton();
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSpace = new Krypton.Toolkit.KryptonRadioButton();
			kryptonCheckBoxEssinOutputOptionsEntriesLineByLine = new Krypton.Toolkit.KryptonCheckBox();
			kryptonCheckBoxEssinOutputOptionsEnclosedWithQuotes = new Krypton.Toolkit.KryptonCheckBox();
			kryptonCheckBoxEssinOutputOptionsClearListWithEveryGeneration = new Krypton.Toolkit.KryptonCheckBox();
			tabPageSettingsBrethin = new TabPage();
			tabPageSettingsLassath = new TabPage();
			tabPageSettingsMirath = new TabPage();
			kryptonToolStrip = new Krypton.Toolkit.KryptonToolStrip();
			toolStripButtonApply = new ToolStripButton();
			toolStripButtonCancel = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButtonSetDefaultSettings = new ToolStripButton();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.TopToolStripPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			kryptonStatusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPanel).BeginInit();
			kryptonPanel.SuspendLayout();
			tabControl.SuspendLayout();
			tabPageSettingsNarthalas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).BeginInit();
			tabPageSettingsEssin.SuspendLayout();
			groupBoxEssinOutputOptions.SuspendLayout();
			kryptonToolStrip.SuspendLayout();
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
			toolStripContainer.ContentPanel.Size = new Size(372, 252);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(372, 299);
			toolStripContainer.TabIndex = 4;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			toolStripContainer.TopToolStripPanel.Controls.Add(kryptonToolStrip);
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
			kryptonStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo });
			kryptonStatusStrip.Location = new Point(0, 0);
			kryptonStatusStrip.Name = "kryptonStatusStrip";
			kryptonStatusStrip.ProgressBars = null;
			kryptonStatusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			kryptonStatusStrip.ShowItemToolTips = true;
			kryptonStatusStrip.Size = new Size(372, 22);
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
			toolStripStatusLabelInfo.Size = new Size(357, 17);
			toolStripStatusLabelInfo.Spring = true;
			toolStripStatusLabelInfo.Text = "info";
			toolStripStatusLabelInfo.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// kryptonPanel
			// 
			kryptonPanel.AccessibleDescription = "Just a Panel";
			kryptonPanel.AccessibleName = "Panel";
			kryptonPanel.AccessibleRole = AccessibleRole.Grouping;
			kryptonPanel.Controls.Add(tabControl);
			kryptonPanel.Dock = DockStyle.Fill;
			kryptonPanel.Location = new Point(0, 0);
			kryptonPanel.Name = "kryptonPanel";
			kryptonPanel.Size = new Size(372, 252);
			kryptonPanel.TabIndex = 2;
			kryptonPanel.TabStop = true;
			// 
			// tabControl
			// 
			tabControl.Controls.Add(tabPageSettingsNarthalas);
			tabControl.Controls.Add(tabPageSettingsTarmenel);
			tabControl.Controls.Add(tabPageSettingsDoriath);
			tabControl.Controls.Add(tabPageSettingsOstiath);
			tabControl.Controls.Add(tabPageSettingsLamath);
			tabControl.Controls.Add(tabPageSettingsEssin);
			tabControl.Controls.Add(tabPageSettingsBrethin);
			tabControl.Controls.Add(tabPageSettingsLassath);
			tabControl.Controls.Add(tabPageSettingsMirath);
			tabControl.Dock = DockStyle.Fill;
			tabControl.HotTrack = true;
			tabControl.Location = new Point(0, 0);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(372, 252);
			tabControl.TabIndex = 0;
			// 
			// tabPageSettingsNarthalas
			// 
			tabPageSettingsNarthalas.AutoScroll = true;
			tabPageSettingsNarthalas.Controls.Add(kryptonThemeComboBox1);
			tabPageSettingsNarthalas.Location = new Point(4, 24);
			tabPageSettingsNarthalas.Name = "tabPageSettingsNarthalas";
			tabPageSettingsNarthalas.Padding = new Padding(3);
			tabPageSettingsNarthalas.Size = new Size(364, 224);
			tabPageSettingsNarthalas.TabIndex = 0;
			tabPageSettingsNarthalas.Text = "Narthalas";
			tabPageSettingsNarthalas.UseVisualStyleBackColor = true;
			// 
			// kryptonThemeComboBox1
			// 
			kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Office2007Blue;
			kryptonThemeComboBox1.DropDownWidth = 139;
			kryptonThemeComboBox1.Location = new Point(8, 6);
			kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
			kryptonThemeComboBox1.Size = new Size(348, 22);
			kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
			kryptonThemeComboBox1.TabIndex = 0;
			// 
			// tabPageSettingsTarmenel
			// 
			tabPageSettingsTarmenel.AutoScroll = true;
			tabPageSettingsTarmenel.Location = new Point(4, 24);
			tabPageSettingsTarmenel.Name = "tabPageSettingsTarmenel";
			tabPageSettingsTarmenel.Padding = new Padding(3);
			tabPageSettingsTarmenel.Size = new Size(364, 224);
			tabPageSettingsTarmenel.TabIndex = 1;
			tabPageSettingsTarmenel.Text = "Tarmenel";
			tabPageSettingsTarmenel.UseVisualStyleBackColor = true;
			// 
			// tabPageSettingsDoriath
			// 
			tabPageSettingsDoriath.AutoScroll = true;
			tabPageSettingsDoriath.Location = new Point(4, 24);
			tabPageSettingsDoriath.Name = "tabPageSettingsDoriath";
			tabPageSettingsDoriath.Size = new Size(364, 224);
			tabPageSettingsDoriath.TabIndex = 2;
			tabPageSettingsDoriath.Text = "Doriath";
			tabPageSettingsDoriath.UseVisualStyleBackColor = true;
			// 
			// tabPageSettingsOstiath
			// 
			tabPageSettingsOstiath.AutoScroll = true;
			tabPageSettingsOstiath.Location = new Point(4, 24);
			tabPageSettingsOstiath.Name = "tabPageSettingsOstiath";
			tabPageSettingsOstiath.Size = new Size(364, 224);
			tabPageSettingsOstiath.TabIndex = 3;
			tabPageSettingsOstiath.Text = "Ostiath";
			tabPageSettingsOstiath.UseVisualStyleBackColor = true;
			// 
			// tabPageSettingsLamath
			// 
			tabPageSettingsLamath.AutoScroll = true;
			tabPageSettingsLamath.Location = new Point(4, 24);
			tabPageSettingsLamath.Name = "tabPageSettingsLamath";
			tabPageSettingsLamath.Size = new Size(364, 224);
			tabPageSettingsLamath.TabIndex = 4;
			tabPageSettingsLamath.Text = "Lamath";
			tabPageSettingsLamath.UseVisualStyleBackColor = true;
			// 
			// tabPageSettingsEssin
			// 
			tabPageSettingsEssin.AutoScroll = true;
			tabPageSettingsEssin.Controls.Add(groupBoxEssinOutputOptions);
			tabPageSettingsEssin.Location = new Point(4, 24);
			tabPageSettingsEssin.Name = "tabPageSettingsEssin";
			tabPageSettingsEssin.Size = new Size(364, 224);
			tabPageSettingsEssin.TabIndex = 5;
			tabPageSettingsEssin.Text = "Essin";
			tabPageSettingsEssin.UseVisualStyleBackColor = true;
			// 
			// groupBoxEssinOutputOptions
			// 
			groupBoxEssinOutputOptions.Controls.Add(kryptonRadioButtonEssinOutputOptionsSeparatorIsSemicolon);
			groupBoxEssinOutputOptions.Controls.Add(kryptonRadioButtonEssinOutputOptionsSeparatorIsPipe);
			groupBoxEssinOutputOptions.Controls.Add(kryptonRadioButtonEssinOutputOptionsSeparatorIsComma);
			groupBoxEssinOutputOptions.Controls.Add(kryptonRadioButtonEssinOutputOptionsSeparatorIsSpace);
			groupBoxEssinOutputOptions.Controls.Add(kryptonCheckBoxEssinOutputOptionsEntriesLineByLine);
			groupBoxEssinOutputOptions.Controls.Add(kryptonCheckBoxEssinOutputOptionsEnclosedWithQuotes);
			groupBoxEssinOutputOptions.Controls.Add(kryptonCheckBoxEssinOutputOptionsClearListWithEveryGeneration);
			groupBoxEssinOutputOptions.Location = new Point(8, 3);
			groupBoxEssinOutputOptions.Name = "groupBoxEssinOutputOptions";
			groupBoxEssinOutputOptions.Size = new Size(281, 208);
			groupBoxEssinOutputOptions.TabIndex = 3;
			groupBoxEssinOutputOptions.TabStop = false;
			groupBoxEssinOutputOptions.Text = "Ausgabeoptionen";
			// 
			// kryptonRadioButtonEssinOutputOptionsSeparatorIsSemicolon
			// 
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSemicolon.Location = new Point(6, 178);
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSemicolon.Name = "kryptonRadioButtonEssinOutputOptionsSeparatorIsSemicolon";
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSemicolon.Size = new Size(214, 20);
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSemicolon.TabIndex = 6;
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSemicolon.Values.Text = "Einträge durch Semikolons trennen";
			// 
			// kryptonRadioButtonEssinOutputOptionsSeparatorIsPipe
			// 
			kryptonRadioButtonEssinOutputOptionsSeparatorIsPipe.Location = new Point(6, 152);
			kryptonRadioButtonEssinOutputOptionsSeparatorIsPipe.Name = "kryptonRadioButtonEssinOutputOptionsSeparatorIsPipe";
			kryptonRadioButtonEssinOutputOptionsSeparatorIsPipe.Size = new Size(227, 20);
			kryptonRadioButtonEssinOutputOptionsSeparatorIsPipe.TabIndex = 5;
			kryptonRadioButtonEssinOutputOptionsSeparatorIsPipe.Values.Text = "Einträge durch Pipe-Symbole trennen";
			// 
			// kryptonRadioButtonEssinOutputOptionsSeparatorIsComma
			// 
			kryptonRadioButtonEssinOutputOptionsSeparatorIsComma.Location = new Point(6, 126);
			kryptonRadioButtonEssinOutputOptionsSeparatorIsComma.Name = "kryptonRadioButtonEssinOutputOptionsSeparatorIsComma";
			kryptonRadioButtonEssinOutputOptionsSeparatorIsComma.Size = new Size(204, 20);
			kryptonRadioButtonEssinOutputOptionsSeparatorIsComma.TabIndex = 4;
			kryptonRadioButtonEssinOutputOptionsSeparatorIsComma.Values.Text = "Einträge durch Kommata trennen";
			// 
			// kryptonRadioButtonEssinOutputOptionsSeparatorIsSpace
			// 
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSpace.Location = new Point(6, 100);
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSpace.Name = "kryptonRadioButtonEssinOutputOptionsSeparatorIsSpace";
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSpace.Size = new Size(215, 20);
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSpace.TabIndex = 3;
			kryptonRadioButtonEssinOutputOptionsSeparatorIsSpace.Values.Text = "Einträge durch Leerzeichen trennen";
			// 
			// kryptonCheckBoxEssinOutputOptionsEntriesLineByLine
			// 
			kryptonCheckBoxEssinOutputOptionsEntriesLineByLine.Location = new Point(6, 22);
			kryptonCheckBoxEssinOutputOptionsEntriesLineByLine.Name = "kryptonCheckBoxEssinOutputOptionsEntriesLineByLine";
			kryptonCheckBoxEssinOutputOptionsEntriesLineByLine.Size = new Size(198, 20);
			kryptonCheckBoxEssinOutputOptionsEntriesLineByLine.TabIndex = 0;
			kryptonCheckBoxEssinOutputOptionsEntriesLineByLine.Values.Text = "Einträge zeilenweise hinzufügen";
			// 
			// kryptonCheckBoxEssinOutputOptionsEnclosedWithQuotes
			// 
			kryptonCheckBoxEssinOutputOptionsEnclosedWithQuotes.Location = new Point(6, 74);
			kryptonCheckBoxEssinOutputOptionsEnclosedWithQuotes.Name = "kryptonCheckBoxEssinOutputOptionsEnclosedWithQuotes";
			kryptonCheckBoxEssinOutputOptionsEnclosedWithQuotes.Size = new Size(269, 20);
			kryptonCheckBoxEssinOutputOptionsEnclosedWithQuotes.TabIndex = 2;
			kryptonCheckBoxEssinOutputOptionsEnclosedWithQuotes.Values.Text = "Einträge mit Anführungszeichen umschließen";
			// 
			// kryptonCheckBoxEssinOutputOptionsClearListWithEveryGeneration
			// 
			kryptonCheckBoxEssinOutputOptionsClearListWithEveryGeneration.Location = new Point(6, 48);
			kryptonCheckBoxEssinOutputOptionsClearListWithEveryGeneration.Name = "kryptonCheckBoxEssinOutputOptionsClearListWithEveryGeneration";
			kryptonCheckBoxEssinOutputOptionsClearListWithEveryGeneration.Size = new Size(237, 20);
			kryptonCheckBoxEssinOutputOptionsClearListWithEveryGeneration.TabIndex = 1;
			kryptonCheckBoxEssinOutputOptionsClearListWithEveryGeneration.Values.Text = "mit jeder Generierung die Liste löschen";
			// 
			// tabPageSettingsBrethin
			// 
			tabPageSettingsBrethin.AutoScroll = true;
			tabPageSettingsBrethin.Location = new Point(4, 24);
			tabPageSettingsBrethin.Name = "tabPageSettingsBrethin";
			tabPageSettingsBrethin.Size = new Size(364, 224);
			tabPageSettingsBrethin.TabIndex = 6;
			tabPageSettingsBrethin.Text = "Brethin";
			tabPageSettingsBrethin.UseVisualStyleBackColor = true;
			// 
			// tabPageSettingsLassath
			// 
			tabPageSettingsLassath.AutoScroll = true;
			tabPageSettingsLassath.Location = new Point(4, 24);
			tabPageSettingsLassath.Name = "tabPageSettingsLassath";
			tabPageSettingsLassath.Size = new Size(364, 224);
			tabPageSettingsLassath.TabIndex = 8;
			tabPageSettingsLassath.Text = "Lassath";
			tabPageSettingsLassath.UseVisualStyleBackColor = true;
			// 
			// tabPageSettingsMirath
			// 
			tabPageSettingsMirath.AutoScroll = true;
			tabPageSettingsMirath.Location = new Point(4, 24);
			tabPageSettingsMirath.Name = "tabPageSettingsMirath";
			tabPageSettingsMirath.Size = new Size(364, 224);
			tabPageSettingsMirath.TabIndex = 7;
			tabPageSettingsMirath.Text = "Mirath";
			tabPageSettingsMirath.UseVisualStyleBackColor = true;
			// 
			// kryptonToolStrip
			// 
			kryptonToolStrip.AllowClickThrough = true;
			kryptonToolStrip.AllowItemReorder = true;
			kryptonToolStrip.Dock = DockStyle.None;
			kryptonToolStrip.Font = new Font("Segoe UI", 9F);
			kryptonToolStrip.Items.AddRange(new ToolStripItem[] { toolStripButtonApply, toolStripButtonCancel, toolStripSeparator1, toolStripButtonSetDefaultSettings });
			kryptonToolStrip.Location = new Point(0, 0);
			kryptonToolStrip.Name = "kryptonToolStrip";
			kryptonToolStrip.Padding = new Padding(0);
			kryptonToolStrip.Size = new Size(372, 25);
			kryptonToolStrip.Stretch = true;
			kryptonToolStrip.TabIndex = 0;
			kryptonToolStrip.TabStop = true;
			kryptonToolStrip.Text = "Toolbar";
			// 
			// toolStripButtonApply
			// 
			toolStripButtonApply.AccessibleDescription = "Speichert die Änderungen und wendet sie an";
			toolStripButtonApply.AccessibleName = "Änderungen anwenden";
			toolStripButtonApply.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonApply.Image = Properties.Resources.o_collection_office_ok_16;
			toolStripButtonApply.ImageTransparentColor = Color.Magenta;
			toolStripButtonApply.Name = "toolStripButtonApply";
			toolStripButtonApply.Size = new Size(84, 22);
			toolStripButtonApply.Text = "Anwenden";
			toolStripButtonApply.MouseEnter += SetStatusBar_Enter;
			toolStripButtonApply.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripButtonCancel
			// 
			toolStripButtonCancel.AccessibleDescription = "Verwirft die Änderungen und schließt das Fenster";
			toolStripButtonCancel.AccessibleName = "Änderungen verwerfen";
			toolStripButtonCancel.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonCancel.Image = Properties.Resources.o_collection_office_close_16;
			toolStripButtonCancel.ImageTransparentColor = Color.Magenta;
			toolStripButtonCancel.Name = "toolStripButtonCancel";
			toolStripButtonCancel.Size = new Size(85, 22);
			toolStripButtonCancel.Text = "Abbrechen";
			toolStripButtonCancel.MouseEnter += SetStatusBar_Enter;
			toolStripButtonCancel.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 25);
			// 
			// toolStripButtonSetDefaultSettings
			// 
			toolStripButtonSetDefaultSettings.AccessibleDescription = "Stellt die Standardeinstellungen wieder her";
			toolStripButtonSetDefaultSettings.AccessibleName = "Standardeinstellungen wiederherstellen";
			toolStripButtonSetDefaultSettings.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonSetDefaultSettings.Image = Properties.Resources.o_collection_office_undo_16;
			toolStripButtonSetDefaultSettings.ImageTransparentColor = Color.Magenta;
			toolStripButtonSetDefaultSettings.Name = "toolStripButtonSetDefaultSettings";
			toolStripButtonSetDefaultSettings.Size = new Size(163, 22);
			toolStripButtonSetDefaultSettings.Text = "Standard wiederherstellen";
			toolStripButtonSetDefaultSettings.MouseEnter += SetStatusBar_Enter;
			toolStripButtonSetDefaultSettings.MouseLeave += ClearStatusBar_Leave;
			// 
			// SettingsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(372, 299);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			MaximizeBox = false;
			Name = "SettingsForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Einstellungen";
			KeyDown += SettingsForm_KeyDown;
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			toolStripContainer.TopToolStripPanel.PerformLayout();
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			kryptonStatusStrip.ResumeLayout(false);
			kryptonStatusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPanel).EndInit();
			kryptonPanel.ResumeLayout(false);
			tabControl.ResumeLayout(false);
			tabPageSettingsNarthalas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).EndInit();
			tabPageSettingsEssin.ResumeLayout(false);
			groupBoxEssinOutputOptions.ResumeLayout(false);
			groupBoxEssinOutputOptions.PerformLayout();
			kryptonToolStrip.ResumeLayout(false);
			kryptonToolStrip.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ToolStripContainer toolStripContainer;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private ToolStripStatusLabel toolStripStatusLabelInfo;
		private Krypton.Toolkit.KryptonPanel kryptonPanel;
		private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip;
		private TabControl tabControl;
		private TabPage tabPageSettingsNarthalas;
		private TabPage tabPageSettingsTarmenel;
		private TabPage tabPageSettingsDoriath;
		private TabPage tabPageSettingsOstiath;
		private TabPage tabPageSettingsLamath;
		private TabPage tabPageSettingsEssin;
		private TabPage tabPageSettingsBrethin;
		private TabPage tabPageSettingsMirath;
		private TabPage tabPageSettingsLassath;
		private ToolStripButton toolStripButtonApply;
		private ToolStripButton toolStripButtonCancel;
		private ToolStripButton toolStripButtonSetDefaultSettings;
		private ToolStripSeparator toolStripSeparator1;
		private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
		private GroupBox groupBoxEssinOutputOptions;
		private Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxEssinOutputOptionsEntriesLineByLine;
		private Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxEssinOutputOptionsEnclosedWithQuotes;
		private Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxEssinOutputOptionsClearListWithEveryGeneration;
		private Krypton.Toolkit.KryptonRadioButton kryptonRadioButtonEssinOutputOptionsSeparatorIsSemicolon;
		private Krypton.Toolkit.KryptonRadioButton kryptonRadioButtonEssinOutputOptionsSeparatorIsPipe;
		private Krypton.Toolkit.KryptonRadioButton kryptonRadioButtonEssinOutputOptionsSeparatorIsComma;
		private Krypton.Toolkit.KryptonRadioButton kryptonRadioButtonEssinOutputOptionsSeparatorIsSpace;
	}
}