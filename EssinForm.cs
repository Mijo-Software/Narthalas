using System.Text;

namespace Narthalas
{
	public partial class EssinForm : Form
	{
		public EssinForm()
		{
			InitializeComponent();
			kryptonTextBoxResults.Text = string.Empty;
		}

		#region Helpers

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

		#endregion

		#region Enter event handlers

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

		#region Leave event handler

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusBar_Leave(object sender, EventArgs e) => ClearStatusBar();

		#endregion

		#region KeyDown event handlers

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

		#region Click event handlers

		#endregion

		private static readonly string[] SilbenAnfang = { "Al", "Bel", "Dar", "El", "Fen", "Gar", "Hal", "Is", "Jon", "Kel", "Lor", "Mar", "Nor", "Or", "Per", "Quin", "Ran", "Sor", "Tor", "Ul", "Val", "Wil", "Xan", "Yor", "Zan" };
		private static readonly string[] SilbenMitte = { "a", "e", "i", "o", "u", "ae", "ia", "ou", "ar", "ir", "or", "ur", "el", "an", "en", "in", "on", "un" };
		private static readonly string[] SilbenEnde = { "dor", "ric", "son", "mir", "tis", "las", "nix", "zor", "ran", "th", "ien", "dus", "var", "len", "mon", "gorn", "rek", "wyn", "dil", "rix" };

		private static readonly Random random = new();

		public static string GenerateName(int silbenAnzahl = 2)
		{
			StringBuilder sb = new();

			_ = sb.Append(SilbenAnfang[random.Next(SilbenAnfang.Length)]);

			for (int i = 0; i < silbenAnzahl - 1; i++)
			{
				_ = sb.Append(SilbenMitte[random.Next(SilbenMitte.Length)]);
			}

			_ = sb.Append(SilbenEnde[random.Next(SilbenEnde.Length)]);

			return sb.ToString();
		}

		public static string GenerateFullName()
		{
			string vorname = GenerateName(random.Next(2, 4));
			string nachname = GenerateName(random.Next(2, 4));
			return $"{vorname} {nachname}";
		}


		private void KryptonButtonStart_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < kryptonNumericUpDownSetResultNames.Value; i++)
			{
				kryptonTextBoxResults.Text = string.IsNullOrWhiteSpace(kryptonTextBoxResults.Text)
					? $"{GenerateName()}"
					: $"{kryptonTextBoxResults.Text} {GenerateName()} ";
			}
		}

		private void kryptonButtonOutputOptions_Click(object sender, EventArgs e)
		{
			// Position des Buttons relativ zum Formular
			Point buttonPosition = kryptonButtonOutputOptions.PointToScreen(Point.Empty);

			// Position unterhalb des Buttons berechnen
			Point menuPosition = new(buttonPosition.X, buttonPosition.Y + kryptonButtonOutputOptions.Height);

			// Kontextmenü an dieser Position anzeigen
			contextMenuStripResultOptions.Show(menuPosition);
		}

		private void toolStripMenuItemOutputOptionsEntriesLineByLine_Click(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItemOutputOptionsClearListWithEveryGeneration_Click(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItemOutputOptionsSeparatorIsSpace_Click(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItemOutputOptionsSeparatorIsComma_Click(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItemOutputOptionsSeparatorIsPipe_Click(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItemOutputOptionsSeparatorIsSemikolon_Click(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItemOutputOptionsEnclosedWithQuotes_Click(object sender, EventArgs e)
		{

		}
	}
}
