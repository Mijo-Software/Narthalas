using Krypton.Toolkit;

namespace Narthalas
{
	public partial class NarthalasForm : Form
	{
		public NarthalasForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The main text to be displayed on the status bar.</param>
		/// <param name="additionalInfo">Additional information to be displayed alongside the main text.</param>
		private void SetStatusBar(string text, string additionalInfo = "")
		{
			// Check if the text is not null or whitespace
			if (string.IsNullOrWhiteSpace(value: text))
			{
				return;
			}
			// Set the status bar text and enable it
			toolStripStatusLabelInfo.Enabled = true;
			toolStripStatusLabelInfo.Text = string.IsNullOrWhiteSpace(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
		}

		/// <summary>
		/// Clears the status bar text.
		/// </summary>
		private void ClearStatusBar()
		{
			// Clear the status bar text and disable it
			toolStripStatusLabelInfo.Enabled = false;
			toolStripStatusLabelInfo.Text = string.Empty;
		}

		#region Enter-Handler

		/// <summary>
		/// Called when the mouse pointer moves over a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusBar_Enter(object sender, EventArgs e)
		{
			// Set the status bar text based on the sender's accessible description
			switch (sender)
			{
				// If the sender is a control with an accessible description, set the status bar text
				// If the sender is a ToolStripItem with an accessible description, set the status bar text
				case Control { AccessibleDescription: not null } control:
					SetStatusBar(text: control.AccessibleDescription);
					break;
				case ToolStripItem { AccessibleDescription: not null } item:
					SetStatusBar(text: item.AccessibleDescription);
					break;
			}
		}

		#endregion

		#region Leave-Handler

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusBar_Leave(object sender, EventArgs e) => ClearStatusBar();

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the NarthalasForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NarthalasForm_KeyDown(object? sender, KeyEventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the Escape key is pressed
			if (e.KeyCode == Keys.Escape)
			{
				// Close the form
				Close();
			}
		}

		#endregion

		private void KryptonButtonGilathar_Click(object sender, EventArgs e)
		{
			using GilatharForm formGilathar = new();
			_ = formGilathar.ShowDialog();
		}

		private void KryptonButtonTarmenel_Click(object sender, EventArgs e)
		{
			using TarmenelForm formTarmenel = new();
			_ = formTarmenel.ShowDialog();
		}

		private void KryptonButtonDoriath_Click(object sender, EventArgs e)
		{
			using DoriathForm formDoriath = new();
			_ = formDoriath.ShowDialog();
		}

		private void KryptonButtonOstiath_Click(object sender, EventArgs e)
		{
			using OstiathForm formOstiath = new();
			_ = formOstiath.ShowDialog();
		}

		private void KryptonButtonEssin_Click(object sender, EventArgs e)
		{
			using EssinForm formEssin = new();
			_ = formEssin.ShowDialog();
		}

		private void KryptonButtonLamath_Click(object sender, EventArgs e)
		{
			using LamathForm formLamath = new();
			_ = formLamath.ShowDialog();
		}

		private void KryptonButtonMirath_Click(object sender, EventArgs e)
		{
			using MirathForm formMirath = new();
			_ = formMirath.ShowDialog();
		}

		private void KryptonButtonLassath_Click(object sender, EventArgs e)
		{
			using LassathForm formLassath = new();
			_ = formLassath.ShowDialog();
		}

		private void KryptonButtonBrethin_Click(object sender, EventArgs e)
		{
			using BrethinForm formBrethin = new();
			_ = formBrethin.ShowDialog();
		}

		private void KryptonButtonInfo_Click(object sender, EventArgs e)
		{
			using AboutBoxForm aboutBoxForm = new();
			_ = aboutBoxForm.ShowDialog();
		}

		private void KryptonButtonSettings_Click(object sender, EventArgs e)
		{
			using SettingsForm settingsForm = new();
			_ = settingsForm.ShowDialog();
		}

		private void KryptonButtonLanguage_Click(object sender, EventArgs e)
		{
		}

		private void KryptonButtonHelp_Click(object sender, EventArgs e)
		{
			using HelpForm helpForm = new();
			_ = helpForm.ShowDialog();
		}
	}
}
