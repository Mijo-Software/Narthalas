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
			toolStripContainer.ContentPanel.Controls.Add(kryptonPanelMain);
			resources.ApplyResources(toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel");
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
			kryptonButtonHelp.Values.Image = Properties.Resources.o_collection_office_question_16;
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
			kryptonButtonLanguage.Values.Image = Properties.Resources.o_collection_office_messages_16;
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
			kryptonButtonSettings.Values.Image = Properties.Resources.o_collection_office_wrench_16;
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
			kryptonButtonInfo.Values.Image = Properties.Resources.o_collection_office_information_16;
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
			kryptonButtonDoriath.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F);
			kryptonButtonDoriath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonDoriath.ToolTipValues.Description = resources.GetString("resource.Description");
			kryptonButtonDoriath.ToolTipValues.EnableToolTips = true;
			kryptonButtonDoriath.ToolTipValues.Heading = resources.GetString("resource.Heading");
			kryptonButtonDoriath.ToolTipValues.Image = Properties.Resources.o_collection_office_environment_16;
			kryptonButtonDoriath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonDoriath.Values.ExtraText = resources.GetString("kryptonButtonDoriath.Values.ExtraText");
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
			kryptonButtonGilathar.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			kryptonButtonGilathar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonGilathar.ToolTipValues.Description = resources.GetString("resource.Description1");
			kryptonButtonGilathar.ToolTipValues.EnableToolTips = true;
			kryptonButtonGilathar.ToolTipValues.Heading = resources.GetString("resource.Heading1");
			kryptonButtonGilathar.ToolTipValues.Image = Properties.Resources.o_collection_office_star_16;
			kryptonButtonGilathar.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonGilathar.Values.ExtraText = resources.GetString("kryptonButtonGilathar.Values.ExtraText");
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
			kryptonButtonOstiath.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F);
			kryptonButtonOstiath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonOstiath.ToolTipValues.Description = resources.GetString("resource.Description2");
			kryptonButtonOstiath.ToolTipValues.EnableToolTips = true;
			kryptonButtonOstiath.ToolTipValues.Heading = resources.GetString("resource.Heading2");
			kryptonButtonOstiath.ToolTipValues.Image = Properties.Resources.o_collection_office_houses_16;
			kryptonButtonOstiath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonOstiath.Values.ExtraText = resources.GetString("kryptonButtonOstiath.Values.ExtraText");
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
			kryptonButtonTarmenel.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F);
			kryptonButtonTarmenel.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonTarmenel.ToolTipValues.Description = resources.GetString("resource.Description3");
			kryptonButtonTarmenel.ToolTipValues.EnableToolTips = true;
			kryptonButtonTarmenel.ToolTipValues.Heading = resources.GetString("resource.Heading3");
			kryptonButtonTarmenel.ToolTipValues.Image = Properties.Resources.o_collection_office_planet_16;
			kryptonButtonTarmenel.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonTarmenel.Values.ExtraText = resources.GetString("kryptonButtonTarmenel.Values.ExtraText");
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
			kryptonButtonEssin.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F);
			kryptonButtonEssin.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonEssin.ToolTipValues.Description = resources.GetString("resource.Description4");
			kryptonButtonEssin.ToolTipValues.EnableToolTips = true;
			kryptonButtonEssin.ToolTipValues.Heading = resources.GetString("resource.Heading4");
			kryptonButtonEssin.ToolTipValues.Image = Properties.Resources.o_collection_office_speech_balloon_16;
			kryptonButtonEssin.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonEssin.Values.ExtraText = resources.GetString("kryptonButtonEssin.Values.ExtraText");
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
			kryptonButtonLassath.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F);
			kryptonButtonLassath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonLassath.ToolTipValues.Description = resources.GetString("resource.Description5");
			kryptonButtonLassath.ToolTipValues.EnableToolTips = true;
			kryptonButtonLassath.ToolTipValues.Heading = resources.GetString("resource.Heading5");
			kryptonButtonLassath.ToolTipValues.Image = Properties.Resources.o_collection_office_tree_16;
			kryptonButtonLassath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonLassath.Values.ExtraText = resources.GetString("kryptonButtonLassath.Values.ExtraText");
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
			kryptonButtonBrethin.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F);
			kryptonButtonBrethin.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonBrethin.ToolTipValues.Description = resources.GetString("resource.Description6");
			kryptonButtonBrethin.ToolTipValues.EnableToolTips = true;
			kryptonButtonBrethin.ToolTipValues.Heading = resources.GetString("resource.Heading6");
			kryptonButtonBrethin.ToolTipValues.Image = Properties.Resources.o_collection_office_spider_16;
			kryptonButtonBrethin.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonBrethin.Values.ExtraText = resources.GetString("kryptonButtonBrethin.Values.ExtraText");
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
			kryptonButtonMirath.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F);
			kryptonButtonMirath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonMirath.ToolTipValues.Description = resources.GetString("resource.Description7");
			kryptonButtonMirath.ToolTipValues.EnableToolTips = true;
			kryptonButtonMirath.ToolTipValues.Heading = resources.GetString("resource.Heading7");
			kryptonButtonMirath.ToolTipValues.Image = Properties.Resources.o_collection_office_bacteria_16;
			kryptonButtonMirath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonMirath.Values.ExtraText = resources.GetString("kryptonButtonMirath.Values.ExtraText");
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
			kryptonButtonLamath.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F);
			kryptonButtonLamath.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			kryptonButtonLamath.ToolTipValues.Description = resources.GetString("resource.Description8");
			kryptonButtonLamath.ToolTipValues.EnableToolTips = true;
			kryptonButtonLamath.ToolTipValues.Heading = resources.GetString("resource.Heading8");
			kryptonButtonLamath.ToolTipValues.Image = Properties.Resources.o_collection_office_messages_16;
			kryptonButtonLamath.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonLamath.Values.ExtraText = resources.GetString("kryptonButtonLamath.Values.ExtraText");
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
