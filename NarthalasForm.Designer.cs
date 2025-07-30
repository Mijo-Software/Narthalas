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
			toolStripContainer = new ToolStripContainer();
			kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			toolStripStatusLabelInfo = new ToolStripStatusLabel();
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
			kryptonManager = new Krypton.Toolkit.KryptonManager(components);
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			kryptonStatusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPanelMain).BeginInit();
			kryptonPanelMain.SuspendLayout();
			SuspendLayout();
			// 
			// toolStripContainer
			// 
			resources.ApplyResources(toolStripContainer, "toolStripContainer");
			toolStripContainer.AccessibleRole = AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			resources.ApplyResources(toolStripContainer.BottomToolStripPanel, "toolStripContainer.BottomToolStripPanel");
			toolStripContainer.BottomToolStripPanel.AccessibleRole = AccessibleRole.Grouping;
			toolStripContainer.BottomToolStripPanel.Controls.Add(kryptonStatusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			resources.ApplyResources(toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel");
			toolStripContainer.ContentPanel.Controls.Add(kryptonPanelMain);
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			resources.ApplyResources(toolStripContainer.LeftToolStripPanel, "toolStripContainer.LeftToolStripPanel");
			toolStripContainer.LeftToolStripPanel.AccessibleRole = AccessibleRole.Grouping;
			toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			resources.ApplyResources(toolStripContainer.RightToolStripPanel, "toolStripContainer.RightToolStripPanel");
			toolStripContainer.RightToolStripPanel.AccessibleRole = AccessibleRole.Grouping;
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			resources.ApplyResources(toolStripContainer.TopToolStripPanel, "toolStripContainer.TopToolStripPanel");
			toolStripContainer.TopToolStripPanel.AccessibleRole = AccessibleRole.Grouping;
			toolStripContainer.TopToolStripPanelVisible = false;
			toolStripContainer.Enter += SetStatusBar_Enter;
			toolStripContainer.Leave += ClearStatusBar_Leave;
			toolStripContainer.MouseEnter += SetStatusBar_Enter;
			toolStripContainer.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonStatusStrip
			// 
			resources.ApplyResources(kryptonStatusStrip, "kryptonStatusStrip");
			kryptonStatusStrip.AccessibleRole = AccessibleRole.StatusBar;
			kryptonStatusStrip.AllowClickThrough = true;
			kryptonStatusStrip.AllowItemReorder = true;
			kryptonStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo });
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
			// 
			// kryptonPanelMain
			// 
			resources.ApplyResources(kryptonPanelMain, "kryptonPanelMain");
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
			kryptonPanelMain.Name = "kryptonPanelMain";
			kryptonPanelMain.StateCommon.Image = Properties.Resources.nathalas_256;
			kryptonPanelMain.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
			kryptonPanelMain.TabStop = true;
			// 
			// kryptonButtonHelp
			// 
			resources.ApplyResources(kryptonButtonHelp, "kryptonButtonHelp");
			kryptonButtonHelp.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonHelp.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
			kryptonButtonHelp.Name = "kryptonButtonHelp";
			kryptonButtonHelp.TabStop = false;
			kryptonButtonHelp.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonHelp.Values.ExtraText = resources.GetString("kryptonButtonHelp.Values.ExtraText");
			kryptonButtonHelp.Values.Image = Properties.Resources.o_collection_office_question_16;
			kryptonButtonHelp.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonHelp.Values.ImageTransparentColor");
			kryptonButtonHelp.Values.Text = resources.GetString("kryptonButtonHelp.Values.Text");
			kryptonButtonHelp.Click += KryptonButtonHelp_Click;
			kryptonButtonHelp.Enter += SetStatusBar_Enter;
			kryptonButtonHelp.Leave += ClearStatusBar_Leave;
			kryptonButtonHelp.MouseEnter += SetStatusBar_Enter;
			kryptonButtonHelp.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonLanguage
			// 
			resources.ApplyResources(kryptonButtonLanguage, "kryptonButtonLanguage");
			kryptonButtonLanguage.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonLanguage.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
			kryptonButtonLanguage.Name = "kryptonButtonLanguage";
			kryptonButtonLanguage.TabStop = false;
			kryptonButtonLanguage.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonLanguage.Values.ExtraText = resources.GetString("kryptonButtonLanguage.Values.ExtraText");
			kryptonButtonLanguage.Values.Image = Properties.Resources.o_collection_office_messages_16;
			kryptonButtonLanguage.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonLanguage.Values.ImageTransparentColor");
			kryptonButtonLanguage.Values.Text = resources.GetString("kryptonButtonLanguage.Values.Text");
			kryptonButtonLanguage.Click += KryptonButtonLanguage_Click;
			kryptonButtonLanguage.Enter += SetStatusBar_Enter;
			kryptonButtonLanguage.Leave += ClearStatusBar_Leave;
			kryptonButtonLanguage.MouseEnter += SetStatusBar_Enter;
			kryptonButtonLanguage.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonSettings
			// 
			resources.ApplyResources(kryptonButtonSettings, "kryptonButtonSettings");
			kryptonButtonSettings.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonSettings.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
			kryptonButtonSettings.Name = "kryptonButtonSettings";
			kryptonButtonSettings.TabStop = false;
			kryptonButtonSettings.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonSettings.Values.ExtraText = resources.GetString("kryptonButtonSettings.Values.ExtraText");
			kryptonButtonSettings.Values.Image = Properties.Resources.o_collection_office_wrench_16;
			kryptonButtonSettings.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonSettings.Values.ImageTransparentColor");
			kryptonButtonSettings.Values.Text = resources.GetString("kryptonButtonSettings.Values.Text");
			kryptonButtonSettings.Click += KryptonButtonSettings_Click;
			kryptonButtonSettings.Enter += SetStatusBar_Enter;
			kryptonButtonSettings.Leave += ClearStatusBar_Leave;
			kryptonButtonSettings.MouseEnter += SetStatusBar_Enter;
			kryptonButtonSettings.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonInfo
			// 
			resources.ApplyResources(kryptonButtonInfo, "kryptonButtonInfo");
			kryptonButtonInfo.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonInfo.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
			kryptonButtonInfo.Name = "kryptonButtonInfo";
			kryptonButtonInfo.TabStop = false;
			kryptonButtonInfo.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonInfo.Values.ExtraText = resources.GetString("kryptonButtonInfo.Values.ExtraText");
			kryptonButtonInfo.Values.Image = Properties.Resources.o_collection_office_information_16;
			kryptonButtonInfo.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonInfo.Values.ImageTransparentColor");
			kryptonButtonInfo.Values.Text = resources.GetString("kryptonButtonInfo.Values.Text");
			kryptonButtonInfo.Click += KryptonButtonInfo_Click;
			kryptonButtonInfo.Enter += SetStatusBar_Enter;
			kryptonButtonInfo.Leave += ClearStatusBar_Leave;
			kryptonButtonInfo.MouseEnter += SetStatusBar_Enter;
			kryptonButtonInfo.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonDoriath
			// 
			resources.ApplyResources(kryptonButtonDoriath, "kryptonButtonDoriath");
			kryptonButtonDoriath.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonDoriath.Name = "kryptonButtonDoriath";
			kryptonButtonDoriath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonDoriath.ToolTipValues.Description = resources.GetString("resource.Description");
			kryptonButtonDoriath.ToolTipValues.EnableToolTips = true;
			kryptonButtonDoriath.ToolTipValues.Heading = resources.GetString("resource.Heading");
			kryptonButtonDoriath.ToolTipValues.Image = Properties.Resources.o_collection_office_environment_16;
			kryptonButtonDoriath.ToolTipValues.ImageTransparentColor = (Color)resources.GetObject("resource.ImageTransparentColor");
			kryptonButtonDoriath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonDoriath.Values.ExtraText = resources.GetString("kryptonButtonDoriath.Values.ExtraText");
			kryptonButtonDoriath.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonDoriath.Values.ImageTransparentColor");
			kryptonButtonDoriath.Values.Text = resources.GetString("kryptonButtonDoriath.Values.Text");
			kryptonButtonDoriath.Click += KryptonButtonDoriath_Click;
			kryptonButtonDoriath.Enter += SetStatusBar_Enter;
			kryptonButtonDoriath.Leave += ClearStatusBar_Leave;
			kryptonButtonDoriath.MouseEnter += SetStatusBar_Enter;
			kryptonButtonDoriath.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonGilathar
			// 
			resources.ApplyResources(kryptonButtonGilathar, "kryptonButtonGilathar");
			kryptonButtonGilathar.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonGilathar.Name = "kryptonButtonGilathar";
			kryptonButtonGilathar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonGilathar.ToolTipValues.Description = resources.GetString("resource.Description1");
			kryptonButtonGilathar.ToolTipValues.EnableToolTips = true;
			kryptonButtonGilathar.ToolTipValues.Heading = resources.GetString("resource.Heading1");
			kryptonButtonGilathar.ToolTipValues.Image = Properties.Resources.o_collection_office_star_16;
			kryptonButtonGilathar.ToolTipValues.ImageTransparentColor = (Color)resources.GetObject("resource.ImageTransparentColor1");
			kryptonButtonGilathar.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonGilathar.Values.ExtraText = resources.GetString("kryptonButtonGilathar.Values.ExtraText");
			kryptonButtonGilathar.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonGilathar.Values.ImageTransparentColor");
			kryptonButtonGilathar.Values.Text = resources.GetString("kryptonButtonGilathar.Values.Text");
			kryptonButtonGilathar.Click += KryptonButtonGilathar_Click;
			kryptonButtonGilathar.Enter += SetStatusBar_Enter;
			kryptonButtonGilathar.Leave += ClearStatusBar_Leave;
			kryptonButtonGilathar.MouseEnter += SetStatusBar_Enter;
			kryptonButtonGilathar.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonOstiath
			// 
			resources.ApplyResources(kryptonButtonOstiath, "kryptonButtonOstiath");
			kryptonButtonOstiath.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonOstiath.Name = "kryptonButtonOstiath";
			kryptonButtonOstiath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonOstiath.ToolTipValues.Description = resources.GetString("resource.Description2");
			kryptonButtonOstiath.ToolTipValues.EnableToolTips = true;
			kryptonButtonOstiath.ToolTipValues.Heading = resources.GetString("resource.Heading2");
			kryptonButtonOstiath.ToolTipValues.Image = Properties.Resources.o_collection_office_houses_16;
			kryptonButtonOstiath.ToolTipValues.ImageTransparentColor = (Color)resources.GetObject("resource.ImageTransparentColor2");
			kryptonButtonOstiath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonOstiath.Values.ExtraText = resources.GetString("kryptonButtonOstiath.Values.ExtraText");
			kryptonButtonOstiath.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonOstiath.Values.ImageTransparentColor");
			kryptonButtonOstiath.Values.Text = resources.GetString("kryptonButtonOstiath.Values.Text");
			kryptonButtonOstiath.Click += KryptonButtonOstiath_Click;
			kryptonButtonOstiath.Enter += SetStatusBar_Enter;
			kryptonButtonOstiath.Leave += ClearStatusBar_Leave;
			kryptonButtonOstiath.MouseEnter += SetStatusBar_Enter;
			kryptonButtonOstiath.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonTarmenel
			// 
			resources.ApplyResources(kryptonButtonTarmenel, "kryptonButtonTarmenel");
			kryptonButtonTarmenel.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonTarmenel.Name = "kryptonButtonTarmenel";
			kryptonButtonTarmenel.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonTarmenel.ToolTipValues.Description = resources.GetString("resource.Description3");
			kryptonButtonTarmenel.ToolTipValues.EnableToolTips = true;
			kryptonButtonTarmenel.ToolTipValues.Heading = resources.GetString("resource.Heading3");
			kryptonButtonTarmenel.ToolTipValues.Image = Properties.Resources.o_collection_office_planet_16;
			kryptonButtonTarmenel.ToolTipValues.ImageTransparentColor = (Color)resources.GetObject("resource.ImageTransparentColor3");
			kryptonButtonTarmenel.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonTarmenel.Values.ExtraText = resources.GetString("kryptonButtonTarmenel.Values.ExtraText");
			kryptonButtonTarmenel.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonTarmenel.Values.ImageTransparentColor");
			kryptonButtonTarmenel.Values.Text = resources.GetString("kryptonButtonTarmenel.Values.Text");
			kryptonButtonTarmenel.Click += KryptonButtonTarmenel_Click;
			kryptonButtonTarmenel.Enter += SetStatusBar_Enter;
			kryptonButtonTarmenel.Leave += ClearStatusBar_Leave;
			kryptonButtonTarmenel.MouseEnter += SetStatusBar_Enter;
			kryptonButtonTarmenel.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonEssin
			// 
			resources.ApplyResources(kryptonButtonEssin, "kryptonButtonEssin");
			kryptonButtonEssin.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonEssin.Name = "kryptonButtonEssin";
			kryptonButtonEssin.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonEssin.ToolTipValues.Description = resources.GetString("resource.Description4");
			kryptonButtonEssin.ToolTipValues.EnableToolTips = true;
			kryptonButtonEssin.ToolTipValues.Heading = resources.GetString("resource.Heading4");
			kryptonButtonEssin.ToolTipValues.Image = Properties.Resources.o_collection_office_speech_balloon_16;
			kryptonButtonEssin.ToolTipValues.ImageTransparentColor = (Color)resources.GetObject("resource.ImageTransparentColor4");
			kryptonButtonEssin.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonEssin.Values.ExtraText = resources.GetString("kryptonButtonEssin.Values.ExtraText");
			kryptonButtonEssin.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonEssin.Values.ImageTransparentColor");
			kryptonButtonEssin.Values.Text = resources.GetString("kryptonButtonEssin.Values.Text");
			kryptonButtonEssin.Click += KryptonButtonEssin_Click;
			kryptonButtonEssin.Enter += SetStatusBar_Enter;
			kryptonButtonEssin.Leave += ClearStatusBar_Leave;
			kryptonButtonEssin.MouseEnter += SetStatusBar_Enter;
			kryptonButtonEssin.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonLassath
			// 
			resources.ApplyResources(kryptonButtonLassath, "kryptonButtonLassath");
			kryptonButtonLassath.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonLassath.Name = "kryptonButtonLassath";
			kryptonButtonLassath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonLassath.ToolTipValues.Description = resources.GetString("resource.Description5");
			kryptonButtonLassath.ToolTipValues.EnableToolTips = true;
			kryptonButtonLassath.ToolTipValues.Heading = resources.GetString("resource.Heading5");
			kryptonButtonLassath.ToolTipValues.Image = Properties.Resources.o_collection_office_tree_16;
			kryptonButtonLassath.ToolTipValues.ImageTransparentColor = (Color)resources.GetObject("resource.ImageTransparentColor5");
			kryptonButtonLassath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonLassath.Values.ExtraText = resources.GetString("kryptonButtonLassath.Values.ExtraText");
			kryptonButtonLassath.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonLassath.Values.ImageTransparentColor");
			kryptonButtonLassath.Values.Text = resources.GetString("kryptonButtonLassath.Values.Text");
			kryptonButtonLassath.Click += KryptonButtonLassath_Click;
			kryptonButtonLassath.Enter += SetStatusBar_Enter;
			kryptonButtonLassath.Leave += ClearStatusBar_Leave;
			kryptonButtonLassath.MouseEnter += SetStatusBar_Enter;
			kryptonButtonLassath.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonBrethin
			// 
			resources.ApplyResources(kryptonButtonBrethin, "kryptonButtonBrethin");
			kryptonButtonBrethin.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonBrethin.Name = "kryptonButtonBrethin";
			kryptonButtonBrethin.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonBrethin.ToolTipValues.Description = resources.GetString("resource.Description6");
			kryptonButtonBrethin.ToolTipValues.EnableToolTips = true;
			kryptonButtonBrethin.ToolTipValues.Heading = resources.GetString("resource.Heading6");
			kryptonButtonBrethin.ToolTipValues.Image = Properties.Resources.o_collection_office_spider_16;
			kryptonButtonBrethin.ToolTipValues.ImageTransparentColor = (Color)resources.GetObject("resource.ImageTransparentColor6");
			kryptonButtonBrethin.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonBrethin.Values.ExtraText = resources.GetString("kryptonButtonBrethin.Values.ExtraText");
			kryptonButtonBrethin.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonBrethin.Values.ImageTransparentColor");
			kryptonButtonBrethin.Values.Text = resources.GetString("kryptonButtonBrethin.Values.Text");
			kryptonButtonBrethin.Click += KryptonButtonBrethin_Click;
			kryptonButtonBrethin.Enter += SetStatusBar_Enter;
			kryptonButtonBrethin.Leave += ClearStatusBar_Leave;
			kryptonButtonBrethin.MouseEnter += SetStatusBar_Enter;
			kryptonButtonBrethin.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonMirath
			// 
			resources.ApplyResources(kryptonButtonMirath, "kryptonButtonMirath");
			kryptonButtonMirath.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonMirath.Name = "kryptonButtonMirath";
			kryptonButtonMirath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonMirath.ToolTipValues.Description = resources.GetString("resource.Description7");
			kryptonButtonMirath.ToolTipValues.EnableToolTips = true;
			kryptonButtonMirath.ToolTipValues.Heading = resources.GetString("resource.Heading7");
			kryptonButtonMirath.ToolTipValues.Image = Properties.Resources.o_collection_office_bacteria_16;
			kryptonButtonMirath.ToolTipValues.ImageTransparentColor = (Color)resources.GetObject("resource.ImageTransparentColor7");
			kryptonButtonMirath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonMirath.Values.ExtraText = resources.GetString("kryptonButtonMirath.Values.ExtraText");
			kryptonButtonMirath.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonMirath.Values.ImageTransparentColor");
			kryptonButtonMirath.Values.Text = resources.GetString("kryptonButtonMirath.Values.Text");
			kryptonButtonMirath.Click += KryptonButtonMirath_Click;
			kryptonButtonMirath.Enter += SetStatusBar_Enter;
			kryptonButtonMirath.Leave += ClearStatusBar_Leave;
			kryptonButtonMirath.MouseEnter += SetStatusBar_Enter;
			kryptonButtonMirath.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonLamath
			// 
			resources.ApplyResources(kryptonButtonLamath, "kryptonButtonLamath");
			kryptonButtonLamath.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonLamath.Name = "kryptonButtonLamath";
			kryptonButtonLamath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonLamath.ToolTipValues.Description = resources.GetString("resource.Description8");
			kryptonButtonLamath.ToolTipValues.EnableToolTips = true;
			kryptonButtonLamath.ToolTipValues.Heading = resources.GetString("resource.Heading8");
			kryptonButtonLamath.ToolTipValues.Image = Properties.Resources.o_collection_office_messages_16;
			kryptonButtonLamath.ToolTipValues.ImageTransparentColor = (Color)resources.GetObject("resource.ImageTransparentColor8");
			kryptonButtonLamath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonLamath.Values.ExtraText = resources.GetString("kryptonButtonLamath.Values.ExtraText");
			kryptonButtonLamath.Values.ImageTransparentColor = (Color)resources.GetObject("kryptonButtonLamath.Values.ImageTransparentColor");
			kryptonButtonLamath.Values.Text = resources.GetString("kryptonButtonLamath.Values.Text");
			kryptonButtonLamath.Click += KryptonButtonLamath_Click;
			kryptonButtonLamath.Enter += SetStatusBar_Enter;
			kryptonButtonLamath.Leave += ClearStatusBar_Leave;
			kryptonButtonLamath.MouseEnter += SetStatusBar_Enter;
			kryptonButtonLamath.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonManager
			// 
			kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.ApplicationBase = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.ApplicationBase");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.ApplicationName = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.ApplicationName");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.CachePath = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.CachePath");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.CallingAssembly = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.CallingAssembly");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.ConfigurationFile = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.ConfigurationFile");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.DynamicBase = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.DynamicBase");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.EntryAssembly = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.EntryAssembly");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.ExecutingAssembly = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.ExecutingAssembly");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.FriendlyName = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.FriendlyName");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.LicenseFile = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.LicenseFile");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.PrivateBinPath = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.PrivateBinPath");
			kryptonManager.ToolkitStrings.AboutBoxBasicStrings.ShadowCopyDirectories = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxBasicStrings.ShadowCopyDirectories");
			kryptonManager.ToolkitStrings.AboutBoxStrings.About = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.About");
			kryptonManager.ToolkitStrings.AboutBoxStrings.BuildDate = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.BuildDate");
			kryptonManager.ToolkitStrings.AboutBoxStrings.Company = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.Company");
			kryptonManager.ToolkitStrings.AboutBoxStrings.Copyright = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.Copyright");
			kryptonManager.ToolkitStrings.AboutBoxStrings.Description = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.Description");
			kryptonManager.ToolkitStrings.AboutBoxStrings.ImageRuntimeVersion = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.ImageRuntimeVersion");
			kryptonManager.ToolkitStrings.AboutBoxStrings.LoadedFromGlobalAssemblyCache = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.LoadedFromGlobalAssemblyCache");
			kryptonManager.ToolkitStrings.AboutBoxStrings.Product = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.Product");
			kryptonManager.ToolkitStrings.AboutBoxStrings.Title = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.Title");
			kryptonManager.ToolkitStrings.AboutBoxStrings.Trademark = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.Trademark");
			kryptonManager.ToolkitStrings.AboutBoxStrings.Version = resources.GetString("kryptonManager.ToolkitStrings.AboutBoxStrings.Version");
			kryptonManager.ToolkitStrings.ButtonOrientationStrings.Auto = resources.GetString("kryptonManager.ToolkitStrings.ButtonOrientationStrings.Auto");
			kryptonManager.ToolkitStrings.ButtonOrientationStrings.FixedBottom = resources.GetString("kryptonManager.ToolkitStrings.ButtonOrientationStrings.FixedBottom");
			kryptonManager.ToolkitStrings.ButtonOrientationStrings.FixedLeft = resources.GetString("kryptonManager.ToolkitStrings.ButtonOrientationStrings.FixedLeft");
			kryptonManager.ToolkitStrings.ButtonOrientationStrings.FixedRight = resources.GetString("kryptonManager.ToolkitStrings.ButtonOrientationStrings.FixedRight");
			kryptonManager.ToolkitStrings.ButtonOrientationStrings.FixedTop = resources.GetString("kryptonManager.ToolkitStrings.ButtonOrientationStrings.FixedTop");
			kryptonManager.ToolkitStrings.ButtonOrientationStrings.Inherit = resources.GetString("kryptonManager.ToolkitStrings.ButtonOrientationStrings.Inherit");
			kryptonManager.ToolkitStrings.ColorStrings.Color = resources.GetString("kryptonManager.ToolkitStrings.ColorStrings.Color");
			kryptonManager.ToolkitStrings.ColorStrings.Colors = resources.GetString("kryptonManager.ToolkitStrings.ColorStrings.Colors");
			kryptonManager.ToolkitStrings.ColorStrings.MoreColors = resources.GetString("kryptonManager.ToolkitStrings.ColorStrings.MoreColors");
			kryptonManager.ToolkitStrings.ColorStrings.NoColor = resources.GetString("kryptonManager.ToolkitStrings.ColorStrings.NoColor");
			kryptonManager.ToolkitStrings.ColorStrings.RecentColors = resources.GetString("kryptonManager.ToolkitStrings.ColorStrings.RecentColors");
			kryptonManager.ToolkitStrings.ColorStrings.StandardColors = resources.GetString("kryptonManager.ToolkitStrings.ColorStrings.StandardColors");
			kryptonManager.ToolkitStrings.ColorStrings.ThemeColors = resources.GetString("kryptonManager.ToolkitStrings.ColorStrings.ThemeColors");
			kryptonManager.ToolkitStrings.CustomStrings.Apply = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Apply");
			kryptonManager.ToolkitStrings.CustomStrings.Back = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Back");
			kryptonManager.ToolkitStrings.CustomStrings.ClearClipboard = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.ClearClipboard");
			kryptonManager.ToolkitStrings.CustomStrings.Collapse = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Collapse");
			kryptonManager.ToolkitStrings.CustomStrings.Copy = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Copy");
			kryptonManager.ToolkitStrings.CustomStrings.CurrentTheme = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.CurrentTheme");
			kryptonManager.ToolkitStrings.CustomStrings.Cut = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Cut");
			kryptonManager.ToolkitStrings.CustomStrings.DoNotShowAgain = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.DoNotShowAgain");
			kryptonManager.ToolkitStrings.CustomStrings.Exit = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Exit");
			kryptonManager.ToolkitStrings.CustomStrings.Expand = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Expand");
			kryptonManager.ToolkitStrings.CustomStrings.Finish = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Finish");
			kryptonManager.ToolkitStrings.CustomStrings.Next = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Next");
			kryptonManager.ToolkitStrings.CustomStrings.NoToAll = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.NoToAll");
			kryptonManager.ToolkitStrings.CustomStrings.OkToAll = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.OkToAll");
			kryptonManager.ToolkitStrings.CustomStrings.Paste = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Paste");
			kryptonManager.ToolkitStrings.CustomStrings.Previous = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Previous");
			kryptonManager.ToolkitStrings.CustomStrings.Reset = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.Reset");
			kryptonManager.ToolkitStrings.CustomStrings.SelectAll = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.SelectAll");
			kryptonManager.ToolkitStrings.CustomStrings.SystemInformation = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.SystemInformation");
			kryptonManager.ToolkitStrings.CustomStrings.YesToAll = resources.GetString("kryptonManager.ToolkitStrings.CustomStrings.YesToAll");
			kryptonManager.ToolkitStrings.GeneralStrings.Abort = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.Abort");
			kryptonManager.ToolkitStrings.GeneralStrings.Cancel = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.Cancel");
			kryptonManager.ToolkitStrings.GeneralStrings.Close = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.Close");
			kryptonManager.ToolkitStrings.GeneralStrings.Continue = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.Continue");
			kryptonManager.ToolkitStrings.GeneralStrings.Help = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.Help");
			kryptonManager.ToolkitStrings.GeneralStrings.Ignore = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.Ignore");
			kryptonManager.ToolkitStrings.GeneralStrings.No = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.No");
			kryptonManager.ToolkitStrings.GeneralStrings.OK = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.OK");
			kryptonManager.ToolkitStrings.GeneralStrings.Retry = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.Retry");
			kryptonManager.ToolkitStrings.GeneralStrings.Today = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.Today");
			kryptonManager.ToolkitStrings.GeneralStrings.TryAgain = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.TryAgain");
			kryptonManager.ToolkitStrings.GeneralStrings.Yes = resources.GetString("kryptonManager.ToolkitStrings.GeneralStrings.Yes");
			kryptonManager.ToolkitStrings.MiscellaneousThemeStrings.Import = resources.GetString("kryptonManager.ToolkitStrings.MiscellaneousThemeStrings.Import");
			kryptonManager.ToolkitStrings.MiscellaneousThemeStrings.Silent = resources.GetString("kryptonManager.ToolkitStrings.MiscellaneousThemeStrings.Silent");
			kryptonManager.ToolkitStrings.MiscellaneousThemeStrings.ThemeBrowserDescription = resources.GetString("kryptonManager.ToolkitStrings.MiscellaneousThemeStrings.ThemeBrowserDescription");
			kryptonManager.ToolkitStrings.MiscellaneousThemeStrings.ThemeBrowserWindowTitle = resources.GetString("kryptonManager.ToolkitStrings.MiscellaneousThemeStrings.ThemeBrowserWindowTitle");
			kryptonManager.ToolkitStrings.MiscellaneousThemeStrings.Upgrade = resources.GetString("kryptonManager.ToolkitStrings.MiscellaneousThemeStrings.Upgrade");
			kryptonManager.ToolkitStrings.OutlookGridStrings.AfterNextMonth = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.AfterNextMonth");
			kryptonManager.ToolkitStrings.OutlookGridStrings.AlphabeticGroupText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.AlphabeticGroupText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Bar = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Bar");
			kryptonManager.ToolkitStrings.OutlookGridStrings.BeforePreviousMonth = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.BeforePreviousMonth");
			kryptonManager.ToolkitStrings.OutlookGridStrings.BestFit = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.BestFit");
			kryptonManager.ToolkitStrings.OutlookGridStrings.BestFitAll = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.BestFitAll");
			kryptonManager.ToolkitStrings.OutlookGridStrings.ClearGrouping = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.ClearGrouping");
			kryptonManager.ToolkitStrings.OutlookGridStrings.ClearRules = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.ClearRules");
			kryptonManager.ToolkitStrings.OutlookGridStrings.ClearSorting = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.ClearSorting");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Collapse = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Collapse");
			kryptonManager.ToolkitStrings.OutlookGridStrings.ColumnNameXMLNodeText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.ColumnNameXMLNodeText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Columns = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Columns");
			kryptonManager.ToolkitStrings.OutlookGridStrings.ConditionalFormatting = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.ConditionalFormatting");
			kryptonManager.ToolkitStrings.OutlookGridStrings.ConditionXMLNodeText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.ConditionXMLNodeText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatFillLabelText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatFillLabelText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatIntermediateColorButtonText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatIntermediateColorButtonText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatLabelText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatLabelText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatMaximumColorButtonText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatMaximumColorButtonText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatMinimumColorButtonText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatMinimumColorButtonText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatPreviewLabelText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatPreviewLabelText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatWindowTitle = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.CustomFormatWindowTitle");
			kryptonManager.ToolkitStrings.OutlookGridStrings.CustomThreeDots = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.CustomThreeDots");
			kryptonManager.ToolkitStrings.OutlookGridStrings.DateGroupText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.DateGroupText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Day = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Day");
			kryptonManager.ToolkitStrings.OutlookGridStrings.DragColumnToGroup = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.DragColumnToGroup");
			kryptonManager.ToolkitStrings.OutlookGridStrings.EarlierDuringThisMonth = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.EarlierDuringThisMonth");
			kryptonManager.ToolkitStrings.OutlookGridStrings.EarlierDuringThisYear = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.EarlierDuringThisYear");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Expand = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Expand");
			kryptonManager.ToolkitStrings.OutlookGridStrings.FormatParamsXMLNodeText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.FormatParamsXMLNodeText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.FormatTypeXMLNodeText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.FormatTypeXMLNodeText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Friday = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Friday");
			kryptonManager.ToolkitStrings.OutlookGridStrings.FullCollapse = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.FullCollapse");
			kryptonManager.ToolkitStrings.OutlookGridStrings.FullExpand = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.FullExpand");
			kryptonManager.ToolkitStrings.OutlookGridStrings.GradientFill = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.GradientFill");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Group = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Group");
			kryptonManager.ToolkitStrings.OutlookGridStrings.GroupInterval = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.GroupInterval");
			kryptonManager.ToolkitStrings.OutlookGridStrings.HideGroupBox = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.HideGroupBox");
			kryptonManager.ToolkitStrings.OutlookGridStrings.InThreeWeeks = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.InThreeWeeks");
			kryptonManager.ToolkitStrings.OutlookGridStrings.InTwoWeeks = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.InTwoWeeks");
			kryptonManager.ToolkitStrings.OutlookGridStrings.LaterDuringThisMonth = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.LaterDuringThisMonth");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Monday = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Monday");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Month = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Month");
			kryptonManager.ToolkitStrings.OutlookGridStrings.NextMonth = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.NextMonth");
			kryptonManager.ToolkitStrings.OutlookGridStrings.NextWeek = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.NextWeek");
			kryptonManager.ToolkitStrings.OutlookGridStrings.NoDate = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.NoDate");
			kryptonManager.ToolkitStrings.OutlookGridStrings.NumberOfItems = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.NumberOfItems");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Older = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Older");
			kryptonManager.ToolkitStrings.OutlookGridStrings.OneItem = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.OneItem");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Other = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Other");
			kryptonManager.ToolkitStrings.OutlookGridStrings.PaletteCustom = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.PaletteCustom");
			kryptonManager.ToolkitStrings.OutlookGridStrings.PaletteCustomHeading = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.PaletteCustomHeading");
			kryptonManager.ToolkitStrings.OutlookGridStrings.PreviousMonth = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.PreviousMonth");
			kryptonManager.ToolkitStrings.OutlookGridStrings.PreviousWeek = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.PreviousWeek");
			kryptonManager.ToolkitStrings.OutlookGridStrings.PreviousYear = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.PreviousYear");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Quarter = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Quarter");
			kryptonManager.ToolkitStrings.OutlookGridStrings.QuarterFour = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.QuarterFour");
			kryptonManager.ToolkitStrings.OutlookGridStrings.QuarterOne = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.QuarterOne");
			kryptonManager.ToolkitStrings.OutlookGridStrings.QuarterThree = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.QuarterThree");
			kryptonManager.ToolkitStrings.OutlookGridStrings.QuarterTwo = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.QuarterTwo");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Saturday = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Saturday");
			kryptonManager.ToolkitStrings.OutlookGridStrings.ShowGroupBox = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.ShowGroupBox");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Smart = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Smart");
			kryptonManager.ToolkitStrings.OutlookGridStrings.SolidFill = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.SolidFill");
			kryptonManager.ToolkitStrings.OutlookGridStrings.SortAscending = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.SortAscending");
			kryptonManager.ToolkitStrings.OutlookGridStrings.SortBySummaryCount = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.SortBySummaryCount");
			kryptonManager.ToolkitStrings.OutlookGridStrings.SortDescending = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.SortDescending");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Sunday = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Sunday");
			kryptonManager.ToolkitStrings.OutlookGridStrings.ThreeColorsRange = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.ThreeColorsRange");
			kryptonManager.ToolkitStrings.OutlookGridStrings.ThreeWeeksAgo = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.ThreeWeeksAgo");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Thursday = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Thursday");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Today = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Today");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Tomorrow = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Tomorrow");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Tuesday = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Tuesday");
			kryptonManager.ToolkitStrings.OutlookGridStrings.TwoColorsRange = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.TwoColorsRange");
			kryptonManager.ToolkitStrings.OutlookGridStrings.TwoWeeksAgo = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.TwoWeeksAgo");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Ungroup = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Ungroup");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Unknown = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Unknown");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Wednesday = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Wednesday");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Year = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Year");
			kryptonManager.ToolkitStrings.OutlookGridStrings.YearGroupText = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.YearGroupText");
			kryptonManager.ToolkitStrings.OutlookGridStrings.Yesterday = resources.GetString("kryptonManager.ToolkitStrings.OutlookGridStrings.Yesterday");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Custom = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Custom");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365Black = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365Black");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365BlackDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365BlackDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365BlackDarkModeAlternate = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365BlackDarkModeAlternate");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365Blue = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365Blue");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365BlueDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365BlueDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365BlueLightMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365BlueLightMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365DarkGray = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365DarkGray");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365LightGray = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365LightGray");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365Silver = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365Silver");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365SilverDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365SilverDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365SilverLightMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365SilverLightMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365White = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Microsoft365White");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007Black = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007Black");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007BlackDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007BlackDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007Blue = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007Blue");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007BlueDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007BlueDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007BlueLightMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007BlueLightMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007DarkGray = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007DarkGray");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007LightGray = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007LightGray");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007Silver = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007Silver");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007SilverDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007SilverDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007SilverLightMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007SilverLightMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007White = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2007White");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010Black = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010Black");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010BlackDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010BlackDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010Blue = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010Blue");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010BlueDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010BlueDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010BlueLightMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010BlueLightMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010DarkGray = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010DarkGray");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010LightGray = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010LightGray");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010Silver = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010Silver");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010SilverDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010SilverDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010SilverLightMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010SilverLightMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010White = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2010White");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2013DarkGray = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2013DarkGray");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2013LightGray = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2013LightGray");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Office2013White = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Office2013White");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Professional = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Professional");
			kryptonManager.ToolkitStrings.PaletteModeStrings.Professional2003 = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.Professional2003");
			kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleBlue = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleBlue");
			kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleBlueDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleBlueDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleBlueLightMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleBlueLightMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleOrange = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleOrange");
			kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleOrangeDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleOrangeDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleOrangeLightMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.SparkleOrangeLightMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.SparklePurple = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.SparklePurple");
			kryptonManager.ToolkitStrings.PaletteModeStrings.SparklePurpleDarkMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.SparklePurpleDarkMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.SparklePurpleLightMode = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.SparklePurpleLightMode");
			kryptonManager.ToolkitStrings.PaletteModeStrings.VisualStudio2010With2007Renderer = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.VisualStudio2010With2007Renderer");
			kryptonManager.ToolkitStrings.PaletteModeStrings.VisualStudio2010With2010Renderer = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.VisualStudio2010With2010Renderer");
			kryptonManager.ToolkitStrings.PaletteModeStrings.VisualStudio2010With2013Renderer = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.VisualStudio2010With2013Renderer");
			kryptonManager.ToolkitStrings.PaletteModeStrings.VisualStudio2010With365Renderer = resources.GetString("kryptonManager.ToolkitStrings.PaletteModeStrings.VisualStudio2010With365Renderer");
			kryptonManager.ToolkitStrings.RibbonStrings.AppButtonKeyTip = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.AppButtonKeyTip");
			kryptonManager.ToolkitStrings.RibbonStrings.AppButtonText = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.AppButtonText");
			kryptonManager.ToolkitStrings.RibbonStrings.CustomizeQuickAccessToolbar = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.CustomizeQuickAccessToolbar");
			kryptonManager.ToolkitStrings.RibbonStrings.Minimize = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.Minimize");
			kryptonManager.ToolkitStrings.RibbonStrings.MoreColors = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.MoreColors");
			kryptonManager.ToolkitStrings.RibbonStrings.NoColor = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.NoColor");
			kryptonManager.ToolkitStrings.RibbonStrings.RecentColors = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.RecentColors");
			kryptonManager.ToolkitStrings.RibbonStrings.RecentDocuments = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.RecentDocuments");
			kryptonManager.ToolkitStrings.RibbonStrings.ShowAboveRibbon = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.ShowAboveRibbon");
			kryptonManager.ToolkitStrings.RibbonStrings.ShowBelowRibbon = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.ShowBelowRibbon");
			kryptonManager.ToolkitStrings.RibbonStrings.ShowQATAboveRibbon = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.ShowQATAboveRibbon");
			kryptonManager.ToolkitStrings.RibbonStrings.ShowQATBelowRibbon = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.ShowQATBelowRibbon");
			kryptonManager.ToolkitStrings.RibbonStrings.StandardColors = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.StandardColors");
			kryptonManager.ToolkitStrings.RibbonStrings.ThemeColors = resources.GetString("kryptonManager.ToolkitStrings.RibbonStrings.ThemeColors");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Application = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Application");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Asterisk = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Asterisk");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Custom = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Custom");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Error = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Error");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Exclamation = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Exclamation");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Hand = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Hand");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Information = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Information");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.None = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.None");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Ok = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Ok");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Question = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Question");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Shield = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Shield");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Stop = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Stop");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemApplication = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemApplication");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemAsterisk = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemAsterisk");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemError = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemError");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemExclamation = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemExclamation");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemHand = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemHand");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemInformation = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemInformation");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemQuestion = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemQuestion");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemStop = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemStop");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemWarning = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.SystemWarning");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Warning = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.Warning");
			kryptonManager.ToolkitStrings.ToastNotificationIconStrings.WindowsLogo = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationIconStrings.WindowsLogo");
			kryptonManager.ToolkitStrings.ToastNotificationStrings.Dismiss = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationStrings.Dismiss");
			kryptonManager.ToolkitStrings.ToastNotificationStrings.DoNotShowAgain = resources.GetString("kryptonManager.ToolkitStrings.ToastNotificationStrings.DoNotShowAgain");
			// 
			// NarthalasForm
			// 
			resources.ApplyResources(this, "$this");
			AccessibleRole = AccessibleRole.Window;
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			KeyPreview = true;
			MaximizeBox = false;
			Name = "NarthalasForm";
			KeyDown += NarthalasForm_KeyDown;
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			kryptonStatusStrip.ResumeLayout(false);
			kryptonStatusStrip.PerformLayout();
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
