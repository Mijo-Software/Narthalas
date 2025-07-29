namespace Narthalas
{
	partial class GilatharForm
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
            ((System.ComponentModel.ISupportInitialize)kryptonPanel).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel
            // 
            kryptonPanel.AccessibleDescription = "Just a Panel";
            kryptonPanel.AccessibleName = "Panel";
            kryptonPanel.AccessibleRole = AccessibleRole.Grouping;
            kryptonPanel.Dock = DockStyle.Fill;
            kryptonPanel.Location = new Point(0, 0);
            kryptonPanel.Name = "kryptonPanel";
            kryptonPanel.Size = new Size(324, 201);
            kryptonPanel.TabIndex = 2;
            kryptonPanel.TabStop = true;
            // 
            // GilatharForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 201);
            Controls.Add(kryptonPanel);
            Name = "GilatharForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GilatharForm";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel;
	}
}