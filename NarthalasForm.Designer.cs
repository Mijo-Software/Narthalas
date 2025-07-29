namespace Narthalas
{
    partial class NarthalasForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NarthalasForm));
			kryptonManager = new Krypton.Toolkit.KryptonManager(components);
			kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			toolStripStatusLabelInfo = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			kryptonPanelMain = new Krypton.Toolkit.KryptonPanel();
			kryptonButtonHelp = new Krypton.Toolkit.KryptonButton();
			kryptonButtonLanguage = new Krypton.Toolkit.KryptonButton();
			kryptonButtonSettings = new Krypton.Toolkit.KryptonButton();
			kryptonButtonInfo = new Krypton.Toolkit.KryptonButton();
			kryptonButtonDoriath = new Krypton.Toolkit.KryptonButton();
			kryptonButtonGilathar = new Krypton.Toolkit.KryptonButton();
			kryptonButtonOstiath = new Krypton.Toolkit.KryptonButton();
			kryptonButtonTarmenel = new Krypton.Toolkit.KryptonButton();
			kryptonButtonEssin = new Krypton.Toolkit.KryptonButton();
			kryptonButtonLassath = new Krypton.Toolkit.KryptonButton();
			kryptonButtonBrethin = new Krypton.Toolkit.KryptonButton();
			kryptonButtonMirath = new Krypton.Toolkit.KryptonButton();
			kryptonButtonLamath = new Krypton.Toolkit.KryptonButton();
			kryptonStatusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPanelMain).BeginInit();
			kryptonPanelMain.SuspendLayout();
			SuspendLayout();
			// 
			// kryptonManager
			// 
			kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
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
			kryptonStatusStrip.Size = new Size(669, 22);
			kryptonStatusStrip.SizingGrip = false;
			kryptonStatusStrip.TabIndex = 0;
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
			toolStripStatusLabelInfo.Size = new Size(28, 17);
			toolStripStatusLabelInfo.Text = "info";
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Container für das Hauptprogramm";
			toolStripContainer.AccessibleName = "Container";
			toolStripContainer.AccessibleRole = AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.AccessibleDescription = "Unterer Panel des Containers";
			toolStripContainer.BottomToolStripPanel.AccessibleName = "Unterer Panel des Containers";
			toolStripContainer.BottomToolStripPanel.AccessibleRole = AccessibleRole.Grouping;
			toolStripContainer.BottomToolStripPanel.Controls.Add(kryptonStatusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(kryptonPanelMain);
			toolStripContainer.ContentPanel.Size = new Size(669, 405);
			toolStripContainer.Dock = DockStyle.Fill;
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			toolStripContainer.LeftToolStripPanel.AccessibleDescription = "Linker Panel des Containers";
			toolStripContainer.LeftToolStripPanel.AccessibleName = "Linker Panel des Containers";
			toolStripContainer.LeftToolStripPanel.AccessibleRole = AccessibleRole.Grouping;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			toolStripContainer.RightToolStripPanel.AccessibleDescription = "Rechter Panel des Containers";
			toolStripContainer.RightToolStripPanel.AccessibleName = "Rechter Panel des Containers";
			toolStripContainer.RightToolStripPanel.AccessibleRole = AccessibleRole.Grouping;
			toolStripContainer.Size = new Size(669, 427);
			toolStripContainer.TabIndex = 0;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			toolStripContainer.TopToolStripPanel.AccessibleDescription = "Oberer Panel des Containers";
			toolStripContainer.TopToolStripPanel.AccessibleName = "Oberer Panel des Containers";
			toolStripContainer.TopToolStripPanel.AccessibleRole = AccessibleRole.Grouping;
			toolStripContainer.TopToolStripPanelVisible = false;
			toolStripContainer.Enter += SetStatusBar_Enter;
			toolStripContainer.Leave += ClearStatusBar_Leave;
			toolStripContainer.MouseEnter += SetStatusBar_Enter;
			toolStripContainer.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonPanelMain
			// 
			kryptonPanelMain.AccessibleDescription = "Panel des Hauptprogramm, das ein Logo des Programmes zeigt";
			kryptonPanelMain.AccessibleName = "Panel des Hauptprogramm";
			kryptonPanelMain.AccessibleRole = AccessibleRole.Pane;
			kryptonPanelMain.Controls.Add(kryptonButtonHelp);
			kryptonPanelMain.Controls.Add(kryptonButtonLanguage);
			kryptonPanelMain.Controls.Add(kryptonButtonSettings);
			kryptonPanelMain.Controls.Add(kryptonButtonInfo);
			kryptonPanelMain.Controls.Add(kryptonButtonDoriath);
			kryptonPanelMain.Controls.Add(kryptonButtonGilathar);
			kryptonPanelMain.Controls.Add(kryptonButtonOstiath);
			kryptonPanelMain.Controls.Add(kryptonButtonTarmenel);
			kryptonPanelMain.Controls.Add(kryptonButtonEssin);
			kryptonPanelMain.Controls.Add(kryptonButtonLassath);
			kryptonPanelMain.Controls.Add(kryptonButtonBrethin);
			kryptonPanelMain.Controls.Add(kryptonButtonMirath);
			kryptonPanelMain.Controls.Add(kryptonButtonLamath);
			kryptonPanelMain.Dock = DockStyle.Fill;
			kryptonPanelMain.Location = new Point(0, 0);
			kryptonPanelMain.Name = "kryptonPanelMain";
			kryptonPanelMain.Size = new Size(669, 405);
			kryptonPanelMain.StateCommon.Image = Properties.Resources.nathalas_256;
			kryptonPanelMain.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
			kryptonPanelMain.TabIndex = 0;
			kryptonPanelMain.TabStop = true;
			// 
			// kryptonButtonHelp
			// 
			kryptonButtonHelp.AccessibleDescription = "Ruft die Hilfe auf";
			kryptonButtonHelp.AccessibleName = "Hilfe";
			kryptonButtonHelp.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			kryptonButtonHelp.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
			kryptonButtonHelp.Location = new Point(643, 0);
			kryptonButtonHelp.Name = "kryptonButtonHelp";
			kryptonButtonHelp.Size = new Size(26, 25);
			kryptonButtonHelp.TabIndex = 10;
			kryptonButtonHelp.TabStop = false;
			kryptonButtonHelp.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonHelp.Values.Image = Properties.Resources.o_collection_office_question_16;
			kryptonButtonHelp.Values.Text = "";
			kryptonButtonHelp.Click += KryptonButtonHelp_Click;
			kryptonButtonHelp.Enter += SetStatusBar_Enter;
			kryptonButtonHelp.Leave += ClearStatusBar_Leave;
			kryptonButtonHelp.MouseEnter += SetStatusBar_Enter;
			kryptonButtonHelp.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonLanguage
			// 
			kryptonButtonLanguage.AccessibleDescription = "Ändert die Sprache des Programms";
			kryptonButtonLanguage.AccessibleName = "Sprache";
			kryptonButtonLanguage.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonLanguage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			kryptonButtonLanguage.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
			kryptonButtonLanguage.Location = new Point(0, 380);
			kryptonButtonLanguage.Name = "kryptonButtonLanguage";
			kryptonButtonLanguage.Size = new Size(26, 25);
			kryptonButtonLanguage.TabIndex = 12;
			kryptonButtonLanguage.TabStop = false;
			kryptonButtonLanguage.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonLanguage.Values.Image = Properties.Resources.o_collection_office_messages_16;
			kryptonButtonLanguage.Values.Text = "";
			kryptonButtonLanguage.Click += KryptonButtonLanguage_Click;
			kryptonButtonLanguage.Enter += SetStatusBar_Enter;
			kryptonButtonLanguage.Leave += ClearStatusBar_Leave;
			kryptonButtonLanguage.MouseEnter += SetStatusBar_Enter;
			kryptonButtonLanguage.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonSettings
			// 
			kryptonButtonSettings.AccessibleDescription = "Öffnet die Einstellungen des Programms";
			kryptonButtonSettings.AccessibleName = "Einstellungen";
			kryptonButtonSettings.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			kryptonButtonSettings.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
			kryptonButtonSettings.Location = new Point(643, 380);
			kryptonButtonSettings.Name = "kryptonButtonSettings";
			kryptonButtonSettings.Size = new Size(26, 25);
			kryptonButtonSettings.TabIndex = 11;
			kryptonButtonSettings.TabStop = false;
			kryptonButtonSettings.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonSettings.Values.Image = Properties.Resources.o_collection_office_wrench_16;
			kryptonButtonSettings.Values.Text = "";
			kryptonButtonSettings.Click += KryptonButtonSettings_Click;
			kryptonButtonSettings.Enter += SetStatusBar_Enter;
			kryptonButtonSettings.Leave += ClearStatusBar_Leave;
			kryptonButtonSettings.MouseEnter += SetStatusBar_Enter;
			kryptonButtonSettings.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonInfo
			// 
			kryptonButtonInfo.AccessibleDescription = "Gibt Informationen zum Programm aus";
			kryptonButtonInfo.AccessibleName = "Info";
			kryptonButtonInfo.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonInfo.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
			kryptonButtonInfo.Location = new Point(0, 0);
			kryptonButtonInfo.Name = "kryptonButtonInfo";
			kryptonButtonInfo.Size = new Size(26, 25);
			kryptonButtonInfo.TabIndex = 9;
			kryptonButtonInfo.TabStop = false;
			kryptonButtonInfo.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonInfo.Values.Image = Properties.Resources.o_collection_office_information_16;
			kryptonButtonInfo.Values.Text = "";
			kryptonButtonInfo.Click += KryptonButtonInfo_Click;
			kryptonButtonInfo.Enter += SetStatusBar_Enter;
			kryptonButtonInfo.Leave += ClearStatusBar_Leave;
			kryptonButtonInfo.MouseEnter += SetStatusBar_Enter;
			kryptonButtonInfo.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonDoriath
			// 
			kryptonButtonDoriath.AccessibleDescription = "Öffnet das Modul \"Doriath\" zur Generierung weiter Terrains";
			kryptonButtonDoriath.AccessibleName = "Doriath";
			kryptonButtonDoriath.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonDoriath.Enabled = false;
			kryptonButtonDoriath.Location = new Point(22, 174);
			kryptonButtonDoriath.Name = "kryptonButtonDoriath";
			kryptonButtonDoriath.Size = new Size(175, 45);
			kryptonButtonDoriath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonDoriath.TabIndex = 2;
			kryptonButtonDoriath.ToolTipValues.Description = "generiert weite Terrains";
			kryptonButtonDoriath.ToolTipValues.EnableToolTips = true;
			kryptonButtonDoriath.ToolTipValues.Heading = "Doriath";
			kryptonButtonDoriath.ToolTipValues.Image = Properties.Resources.o_collection_office_environment_16;
			kryptonButtonDoriath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonDoriath.Values.ExtraText = "Terrains";
			kryptonButtonDoriath.Values.Text = "Doriath";
			kryptonButtonDoriath.Click += KryptonButtonDoriath_Click;
			kryptonButtonDoriath.Enter += SetStatusBar_Enter;
			kryptonButtonDoriath.Leave += ClearStatusBar_Leave;
			kryptonButtonDoriath.MouseEnter += SetStatusBar_Enter;
			kryptonButtonDoriath.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonGilathar
			// 
			kryptonButtonGilathar.AccessibleDescription = "Öffnet das Modul \"Gîlathar\" zur Erschaffung kompletter Galaxien";
			kryptonButtonGilathar.AccessibleName = "Gîlathar";
			kryptonButtonGilathar.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonGilathar.Enabled = false;
			kryptonButtonGilathar.Location = new Point(246, 21);
			kryptonButtonGilathar.Name = "kryptonButtonGilathar";
			kryptonButtonGilathar.Size = new Size(175, 45);
			kryptonButtonGilathar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonGilathar.TabIndex = 0;
			kryptonButtonGilathar.ToolTipValues.Description = "erschafft komplette Galaxien";
			kryptonButtonGilathar.ToolTipValues.EnableToolTips = true;
			kryptonButtonGilathar.ToolTipValues.Heading = "Gîlathar";
			kryptonButtonGilathar.ToolTipValues.Image = Properties.Resources.o_collection_office_star_16;
			kryptonButtonGilathar.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonGilathar.Values.ExtraText = "Galaxien";
			kryptonButtonGilathar.Values.Text = "Gîlathar";
			kryptonButtonGilathar.Click += KryptonButtonGilathar_Click;
			kryptonButtonGilathar.Enter += SetStatusBar_Enter;
			kryptonButtonGilathar.Leave += ClearStatusBar_Leave;
			kryptonButtonGilathar.MouseEnter += SetStatusBar_Enter;
			kryptonButtonGilathar.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonOstiath
			// 
			kryptonButtonOstiath.AccessibleDescription = "Öffnet das Modul \"Ostiath\" zur Modellierung von Städten und Dörfer";
			kryptonButtonOstiath.AccessibleName = "Ostiath";
			kryptonButtonOstiath.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonOstiath.Enabled = false;
			kryptonButtonOstiath.Location = new Point(22, 257);
			kryptonButtonOstiath.Name = "kryptonButtonOstiath";
			kryptonButtonOstiath.Size = new Size(175, 45);
			kryptonButtonOstiath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonOstiath.TabIndex = 3;
			kryptonButtonOstiath.ToolTipValues.Description = "modelliert Städte und Dörfer";
			kryptonButtonOstiath.ToolTipValues.EnableToolTips = true;
			kryptonButtonOstiath.ToolTipValues.Heading = "Ostiath";
			kryptonButtonOstiath.ToolTipValues.Image = Properties.Resources.o_collection_office_houses_16;
			kryptonButtonOstiath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonOstiath.Values.ExtraText = "Städte/Dörfer";
			kryptonButtonOstiath.Values.Text = "Ostiath";
			kryptonButtonOstiath.Click += KryptonButtonOstiath_Click;
			kryptonButtonOstiath.Enter += SetStatusBar_Enter;
			kryptonButtonOstiath.Leave += ClearStatusBar_Leave;
			kryptonButtonOstiath.MouseEnter += SetStatusBar_Enter;
			kryptonButtonOstiath.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonTarmenel
			// 
			kryptonButtonTarmenel.AccessibleDescription = "Öffnet das Modul \"Tarmenel\" zur Erstellung neuer Planetensysteme";
			kryptonButtonTarmenel.AccessibleName = "Tarmenel";
			kryptonButtonTarmenel.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonTarmenel.Enabled = false;
			kryptonButtonTarmenel.Location = new Point(22, 90);
			kryptonButtonTarmenel.Name = "kryptonButtonTarmenel";
			kryptonButtonTarmenel.Size = new Size(175, 45);
			kryptonButtonTarmenel.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonTarmenel.TabIndex = 1;
			kryptonButtonTarmenel.ToolTipValues.Description = "erstellt neue Planetensysteme";
			kryptonButtonTarmenel.ToolTipValues.EnableToolTips = true;
			kryptonButtonTarmenel.ToolTipValues.Heading = "Tarmenel";
			kryptonButtonTarmenel.ToolTipValues.Image = Properties.Resources.o_collection_office_planet_16;
			kryptonButtonTarmenel.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonTarmenel.Values.ExtraText = "Planetensysteme";
			kryptonButtonTarmenel.Values.Text = "Tarmenel";
			kryptonButtonTarmenel.Click += KryptonButtonTarmenel_Click;
			kryptonButtonTarmenel.Enter += SetStatusBar_Enter;
			kryptonButtonTarmenel.Leave += ClearStatusBar_Leave;
			kryptonButtonTarmenel.MouseEnter += SetStatusBar_Enter;
			kryptonButtonTarmenel.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonEssin
			// 
			kryptonButtonEssin.AccessibleDescription = "Öffnet das Modul \"Essin\" zur Kreierung neuer Namen";
			kryptonButtonEssin.AccessibleName = "Essin";
			kryptonButtonEssin.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonEssin.Location = new Point(372, 346);
			kryptonButtonEssin.Name = "kryptonButtonEssin";
			kryptonButtonEssin.Size = new Size(175, 45);
			kryptonButtonEssin.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonEssin.TabIndex = 5;
			kryptonButtonEssin.ToolTipValues.Description = "kreiert neue Namen";
			kryptonButtonEssin.ToolTipValues.EnableToolTips = true;
			kryptonButtonEssin.ToolTipValues.Heading = "Essin";
			kryptonButtonEssin.ToolTipValues.Image = Properties.Resources.o_collection_office_speech_balloon_16;
			kryptonButtonEssin.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonEssin.Values.ExtraText = "Namen";
			kryptonButtonEssin.Values.Text = "Essin";
			kryptonButtonEssin.Click += KryptonButtonEssin_Click;
			kryptonButtonEssin.Enter += SetStatusBar_Enter;
			kryptonButtonEssin.Leave += ClearStatusBar_Leave;
			kryptonButtonEssin.MouseEnter += SetStatusBar_Enter;
			kryptonButtonEssin.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonLassath
			// 
			kryptonButtonLassath.AccessibleDescription = "Öffnet das Modul \"Lassath\" zur Erfindung exotischer Wälder und Pflanzen";
			kryptonButtonLassath.AccessibleName = "Lassath";
			kryptonButtonLassath.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonLassath.Enabled = false;
			kryptonButtonLassath.Location = new Point(469, 174);
			kryptonButtonLassath.Name = "kryptonButtonLassath";
			kryptonButtonLassath.Size = new Size(175, 45);
			kryptonButtonLassath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonLassath.TabIndex = 7;
			kryptonButtonLassath.ToolTipValues.Description = "erfindet exotische Wälder und Pflanzen";
			kryptonButtonLassath.ToolTipValues.EnableToolTips = true;
			kryptonButtonLassath.ToolTipValues.Heading = "Lassath";
			kryptonButtonLassath.ToolTipValues.Image = Properties.Resources.o_collection_office_tree_16;
			kryptonButtonLassath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonLassath.Values.ExtraText = "Wälder/Pflanzen";
			kryptonButtonLassath.Values.Text = "Lassath";
			kryptonButtonLassath.Click += KryptonButtonLassath_Click;
			kryptonButtonLassath.Enter += SetStatusBar_Enter;
			kryptonButtonLassath.Leave += ClearStatusBar_Leave;
			kryptonButtonLassath.MouseEnter += SetStatusBar_Enter;
			kryptonButtonLassath.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonBrethin
			// 
			kryptonButtonBrethin.AccessibleDescription = "Öffnet das Modul \"Brethin\" zur Entwicklung fremder Lebensformen";
			kryptonButtonBrethin.AccessibleName = "Brethin";
			kryptonButtonBrethin.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonBrethin.Enabled = false;
			kryptonButtonBrethin.Location = new Point(469, 257);
			kryptonButtonBrethin.Name = "kryptonButtonBrethin";
			kryptonButtonBrethin.Size = new Size(175, 45);
			kryptonButtonBrethin.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonBrethin.TabIndex = 6;
			kryptonButtonBrethin.ToolTipValues.Description = "entwickelt unbekannte Lebensformen";
			kryptonButtonBrethin.ToolTipValues.EnableToolTips = true;
			kryptonButtonBrethin.ToolTipValues.Heading = "Brethin";
			kryptonButtonBrethin.ToolTipValues.Image = Properties.Resources.o_collection_office_spider_16;
			kryptonButtonBrethin.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonBrethin.Values.ExtraText = "Lebensformen";
			kryptonButtonBrethin.Values.Text = "Brethin";
			kryptonButtonBrethin.Click += KryptonButtonBrethin_Click;
			kryptonButtonBrethin.Enter += SetStatusBar_Enter;
			kryptonButtonBrethin.Leave += ClearStatusBar_Leave;
			kryptonButtonBrethin.MouseEnter += SetStatusBar_Enter;
			kryptonButtonBrethin.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonMirath
			// 
			kryptonButtonMirath.AccessibleDescription = "Öffnet das Modul \"Mîrath\" zur Simulation von Mikroorganismen";
			kryptonButtonMirath.AccessibleName = "Mîrath";
			kryptonButtonMirath.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonMirath.Enabled = false;
			kryptonButtonMirath.Location = new Point(469, 90);
			kryptonButtonMirath.Name = "kryptonButtonMirath";
			kryptonButtonMirath.Size = new Size(175, 45);
			kryptonButtonMirath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonMirath.TabIndex = 8;
			kryptonButtonMirath.ToolTipValues.Description = "simuliert Mikroorganismen";
			kryptonButtonMirath.ToolTipValues.EnableToolTips = true;
			kryptonButtonMirath.ToolTipValues.Heading = "Mîrath";
			kryptonButtonMirath.ToolTipValues.Image = Properties.Resources.o_collection_office_bacteria_16;
			kryptonButtonMirath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonMirath.Values.ExtraText = "Mikroorganismen";
			kryptonButtonMirath.Values.Text = "Mîrath";
			kryptonButtonMirath.Click += KryptonButtonMirath_Click;
			kryptonButtonMirath.Enter += SetStatusBar_Enter;
			kryptonButtonMirath.Leave += ClearStatusBar_Leave;
			kryptonButtonMirath.MouseEnter += SetStatusBar_Enter;
			kryptonButtonMirath.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonLamath
			// 
			kryptonButtonLamath.AccessibleDescription = "Öffnet das Modul \"Lamath\" zur Konstruierung fremder Sprachen";
			kryptonButtonLamath.AccessibleName = "Lamath";
			kryptonButtonLamath.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonLamath.Enabled = false;
			kryptonButtonLamath.Location = new Point(113, 346);
			kryptonButtonLamath.Name = "kryptonButtonLamath";
			kryptonButtonLamath.Size = new Size(175, 45);
			kryptonButtonLamath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonLamath.TabIndex = 4;
			kryptonButtonLamath.ToolTipValues.Description = "konstruiert fremde Sprachen";
			kryptonButtonLamath.ToolTipValues.EnableToolTips = true;
			kryptonButtonLamath.ToolTipValues.Heading = "Lamath";
			kryptonButtonLamath.ToolTipValues.Image = Properties.Resources.o_collection_office_messages_16;
			kryptonButtonLamath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonLamath.Values.ExtraText = "Sprachen";
			kryptonButtonLamath.Values.Text = "Lamath";
			kryptonButtonLamath.Click += KryptonButtonLamath_Click;
			kryptonButtonLamath.Enter += SetStatusBar_Enter;
			kryptonButtonLamath.Leave += ClearStatusBar_Leave;
			kryptonButtonLamath.MouseEnter += SetStatusBar_Enter;
			kryptonButtonLamath.MouseLeave += ClearStatusBar_Leave;
			// 
			// NarthalasForm
			// 
			AccessibleDescription = "Hauptprogramm";
			AccessibleName = "Narthalas";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(669, 427);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			MaximizeBox = false;
			Name = "NarthalasForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Narthalas";
			KeyDown += NarthalasForm_KeyDown;
			kryptonStatusStrip.ResumeLayout(false);
			kryptonStatusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPanelMain).EndInit();
			kryptonPanelMain.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Krypton.Toolkit.KryptonManager kryptonManager;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private ToolStripContainer toolStripContainer;
		private Krypton.Toolkit.KryptonPanel kryptonPanelMain;
		private Krypton.Toolkit.KryptonButton kryptonButtonDoriath;
		private Krypton.Toolkit.KryptonButton kryptonButtonGilathar;
		private Krypton.Toolkit.KryptonButton kryptonButtonOstiath;
		private Krypton.Toolkit.KryptonButton kryptonButtonTarmenel;
		private Krypton.Toolkit.KryptonButton kryptonButtonEssin;
		private Krypton.Toolkit.KryptonButton kryptonButtonLassath;
		private Krypton.Toolkit.KryptonButton kryptonButtonBrethin;
		private Krypton.Toolkit.KryptonButton kryptonButtonMirath;
		private Krypton.Toolkit.KryptonButton kryptonButtonLamath;
		private ToolStripStatusLabel toolStripStatusLabelInfo;
		private Krypton.Toolkit.KryptonButton kryptonButtonInfo;
		private Krypton.Toolkit.KryptonButton kryptonButtonLanguage;
		private Krypton.Toolkit.KryptonButton kryptonButtonSettings;
		private Krypton.Toolkit.KryptonButton kryptonButtonHelp;
	}
}
