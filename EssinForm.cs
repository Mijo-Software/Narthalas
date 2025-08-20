using System.Text;

namespace Narthalas
{
	/// <summary>
	/// Represents the main form for the Essin name generator application.
	/// Provides functionality for generating names based on letter patterns or syllables.
	/// </summary>
	public partial class EssinForm : Form
	{
		/// <summary>
		/// Static random number generator used for name generation.
		/// </summary>
		private static readonly Random random = new();

		/// <summary>
		/// Array of vowel characters used in letter-based name generation.
		/// </summary>
		private static readonly char[] vowels =
		{
			'a', 'e', 'i', 'o', 'u'
		};

		/// <summary>
		/// Array of consonant characters used in letter-based name generation.
		/// </summary>
		private static readonly char[] consonants =
		{
			'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v', 'w', 'z'
		};

		/// <summary>
		/// Array of possible syllable beginnings for syllable-based name generation.
		/// </summary>
		private static readonly string[] syllablesBegin =
		{
			"Al", "Bel", "Dar", "El", "Fen", "Gar", "Hal", "Is", "Jon", "Kel", "Lor", "Mar", "Nor", "Or", "Per", "Quin",
			"Ran", "Sor", "Tor", "Ul", "Val", "Wil", "Xan", "Yor", "Zan"
		};

		/// <summary>
		/// Array of possible syllable middles for syllable-based name generation.
		/// </summary>
		private static readonly string[] syllablesMiddle =
		{
			"a", "e", "i", "o", "u", "ae", "ia", "ou", "ar", "ir", "or", "ur", "el", "an", "en", "in", "on", "un"
		};

		/// <summary>
		/// Array of possible syllable endings for syllable-based name generation.
		/// </summary>
		private static readonly string[] syllablesEnd =
		{
			"dor", "ric", "son", "mir", "tis", "las", "nix", "zor", "ran", "th", "ien", "dus", "var", "len", "mon",
			"gorn", "rek", "wyn", "dil", "rix"
		};

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="EssinForm"/> class.
		/// Sets up the form and its components.
		/// </summary>
		public EssinForm()
		{
			InitializeComponent();
		}

		#endregion

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

		/// <summary>
		/// Handles the click event for the button that starts the syllable-based name generation.
		/// Initiates the background worker to generate names based on syllables.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonStartSyllabesOutput_Click(object sender, EventArgs e)
		{
			backgroundWorkerSyllableName.RunWorkerAsync();
		}

		/// <summary>
		/// Handles the click event for the button that shows the output options for letter-based names.
		/// Displays the context menu with result options below the button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonLettersOutputOptions_Click(object sender, EventArgs e)
		{
			// Position des Buttons relativ zum Formular
			Point buttonPosition = kryptonButtonLettersOutputOptions.PointToScreen(p: Point.Empty);
			// Position unterhalb des Buttons berechnen
			Point menuPosition = new(x: buttonPosition.X, y: buttonPosition.Y + kryptonButtonLettersOutputOptions.Height);
			// Kontextmenü an dieser Position anzeigen
			contextMenuStripResultOptions.Show(screenLocation: menuPosition);
		}

		/// <summary>
		/// Handles the click event for the button that shows the output options for syllable-based names.
		/// Displays the context menu with result options below the button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonSyllablesOutputOptions_Click(object sender, EventArgs e)
		{
			// Position des Buttons relativ zum Formular
			Point buttonPosition = kryptonButtonSyllablesOutputOptions.PointToScreen(p: Point.Empty);
			// Position unterhalb des Buttons berechnen
			Point menuPosition = new(x: buttonPosition.X, y: buttonPosition.Y + kryptonButtonSyllablesOutputOptions.Height);
			// Kontextmenü an dieser Position anzeigen
			contextMenuStripResultOptions.Show(screenLocation: menuPosition);
		}

		#endregion

		/// <summary>
		/// Returns a random character from the specified array.
		/// </summary>
		/// <param name="chars">The array of characters to choose from.</param>
		/// <returns>A randomly selected character from the array.</returns>
		private static char RandomChar(char[] chars)
		{
			return chars[random.Next(maxValue: chars.Length)];
		}

		/// <summary>
		/// Generates a name based on a given pattern of consonants (C) and vowels (V).
		/// </summary>
		/// <param name="pattern">A string pattern using 'C' for consonant and 'V' for vowel (e.g., "CVCVC").</param>
		/// <returns>A generated name following the specified pattern, with the first letter capitalized.</returns>
		private static string GenerateLettersName(string pattern = "CVCVC")
		{
			StringBuilder name = new();

			foreach (char c in pattern.ToUpper())
			{
				if (c == 'C')
				{
					_ = name.Append(value: RandomChar(chars: consonants));
				}
				else if (c == 'V')
				{
					_ = name.Append(value: RandomChar(chars: vowels));
				}
			}

			// Capitalize the first letter
			if (name.Length > 0)
			{
				name[index: 0] = char.ToUpper(c: name[index: 0]);
			}

			return name.ToString();
		}

		/// <summary>
		/// Generates a name by combining random syllables.
		/// </summary>
		/// <param name="silbenAnzahl">The number of syllables to include in the name (minimum 2).</param>
		/// <returns>A generated name composed of a beginning, middle, and ending syllable.</returns>
		private static string GenerateSyllablesName(int silbenAnzahl = 2)
		{
			StringBuilder sb = new();

			_ = sb.Append(value: syllablesBegin[random.Next(maxValue: syllablesBegin.Length)]);

			for (int i = 0; i < silbenAnzahl - 1; i++)
			{
				_ = sb.Append(value: syllablesMiddle[random.Next(maxValue: syllablesMiddle.Length)]);
			}

			_ = sb.Append(value: syllablesEnd[random.Next(maxValue: syllablesEnd.Length)]);

			return sb.ToString();
		}

		private void ToolStripMenuItemOutputOptionsClearListWithEveryGeneration_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripMenuItemOutputOptionsSeparatorIsSpace_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripMenuItemOutputOptionsSeparatorIsComma_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripMenuItemOutputOptionsSeparatorIsPipe_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripMenuItemOutputOptionsSeparatorIsSemikolon_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripMenuItemOutputOptionsEnclosedWithQuotes_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the button that starts the letter-based name generation.
		/// Initiates the background worker to generate names based on letter patterns.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonStartLettersOutput_Click(object sender, EventArgs e)
		{
			backgroundWorkerLetterNames.RunWorkerAsync();
		}

		/// <summary>
		/// Handles the click event for copying the syllable-based results to the clipboard.
		/// Copies the contents of the syllable results textbox to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonCopySyllablesResultsToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: kryptonTextBoxSyllablesResults.Text);
		}

		/// <summary>
		/// Handles the click event for copying the letter-based results to the clipboard.
		/// Copies the contents of the letter results textbox to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonCopyLettersResultsToClipboard_Click(object sender, EventArgs e)
		{
			// Copy the letters results to the clipboard
			ArgumentNullException.ThrowIfNull(argument: kryptonTextBoxLettersResults);
			// Check if the text box is not null or empty
			if (string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text))
			{
				_ = MessageBox.Show(text: "Keine Buchstabenergebnisse zum Kopieren vorhanden.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Keine Buchstabenergebnisse zum Kopieren vorhanden.");
				return;
			}
			Clipboard.SetText(text: kryptonTextBoxLettersResults.Text);
		}

		/// <summary>
		/// Handles the click event for deleting the letter-based results.
		/// Clears the contents of the letter results textbox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonDeleteLettersResultsToClipboard_Click(object sender, EventArgs e)
		{
			kryptonTextBoxLettersResults.Text = string.Empty;
		}

		/// <summary>
		/// Handles the click event for deleting the syllable-based results.
		/// Clears the contents of the syllable results textbox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonDeleteSyllablesResultsToClipboard_Click(object sender, EventArgs e)
		{
			kryptonTextBoxSyllablesResults.Text = string.Empty;
		}

		/// <summary>
		/// Handles the click event for saving the letter-based results to a file.
		/// Opens a save file dialog, writes the contents of the letter results textbox to the selected file,
		/// and updates the status bar with the result.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonSaveLettersResultsToClipboard_Click(object sender, EventArgs e)
		{
			// Save the letters results to a file
			SaveFileDialog saveFileDialog = new()
			{
				Title = "Buchstabenbasiertes Ergebnis speichern",
				Filter = "Textdateien (*.txt)|*.txt|alle Dateien (*.*)|*.*",
				DefaultExt = "txt",
				AddExtension = true
			};
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					System.IO.File.WriteAllText(path: saveFileDialog.FileName, contents: kryptonTextBoxLettersResults.Text);
					_ = MessageBox.Show(text: "Ergebnis abgespeichert.", caption: "Erfolg", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
					SetStatusBar(text: "Ergebnis abgespeichert.", additionalInfo: saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					_ = MessageBox.Show(text: "Fehler bei der Abspeicherung des Ergebnisses", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
					SetStatusBar(text: "Fehler bei der Abspeicherung des Ergebnisses", additionalInfo: ex.Message);
				}
			}
		}

		/// <summary>
		/// Handles the click event for saving the syllable-based results to a file.
		/// Opens a save file dialog, writes the contents of the syllable results textbox to the selected file,
		/// and updates the status bar with the result.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonSaveSyllablesResultsToClipboard_Click(object sender, EventArgs e)
		{
			// Save the letters results to a file
			SaveFileDialog saveFileDialog = new()
			{
				Title = "Silbenbasiertes Ergebnis speichern",
				Filter = "Textdateien (*.txt)|*.txt|alle Dateien (*.*)|*.*",
				DefaultExt = "txt",
				AddExtension = true
			};
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					System.IO.File.WriteAllText(path: saveFileDialog.FileName, contents: kryptonTextBoxSyllablesResults.Text);
					_ = MessageBox.Show(text: "Ergebnis abgespeichert.", caption: "Erfolg", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
					SetStatusBar(text: "Ergebnis abgespeichert.", additionalInfo: saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					_ = MessageBox.Show(text: "Fehler bei der Abspeicherung des Ergebnisses", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
					SetStatusBar(text: "Fehler bei der Abspeicherung des Ergebnisses", additionalInfo: ex.Message);
				}
			}

		}

		/// <summary>
		/// Handles the background worker operation for generating letter-based names.
		/// Generates the specified number of names and appends them to the letter results textbox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
		private void BackgroundWorkerLetterNames_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			kryptonButtonStartLettersOutput.Enabled = false; // Disable the button to prevent multiple clicks during generation

			string separator = " "; // Default separator is space
									// Check the selected output options and set the separator accordingly
			if (toolStripMenuItemOutputOptionsSeparatorIsSpace.Checked)
			{
				separator = " "; // Use space as separator
			}
			else if (toolStripMenuItemOutputOptionsSeparatorIsComma.Checked)
			{
				separator = ","; // Use comma as separator
			}
			else if (toolStripMenuItemOutputOptionsSeparatorIsPipe.Checked)
			{
				separator = "|"; // Use pipe as separator
			}
			else if (toolStripMenuItemOutputOptionsSeparatorIsSemicolon.Checked)
			{
				separator = ";"; // Use semicolon as separator
			}
			else if (toolStripMenuItemOutputOptionsEntriesLineByLine.Checked)
			{
				separator = Environment.NewLine; // Use newline as separator
			}

			if (kryptonNumericUpDownSetLettersNumberNames.Value > kryptonNumericUpDownSetLettersNumberNames.Maximum)
			{
				_ = MessageBox.Show(text: "Die Anzahl der zu generierenden Namen darf maximal 100 sein.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Die Anzahl der zu generierenden Namen darf maximal 100 sein.");
				return;
			}
			if (kryptonNumericUpDownSetLettersNumberNames.Value < kryptonNumericUpDownSetLettersNumberNames.Minimum)
			{
				_ = MessageBox.Show(text: "Die Anzahl der zu generierenden Namen muss mindestens 1 sein.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Die Anzahl der zu generierenden Namen muss mindestens 1 sein.");
				return;
			}

			/*
						if (toolStripMenuItemOutputOptionsEnclosedWithQuotes.Checked)
						{
							// If enclosed with quotes, we will use a space as the separator
							separator = ' ';
							// Enclose each generated name in quotes
							kryptonTextBoxLettersResults.Text = string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text)
								? $"\"{GenerateLettersName(pattern: "CVCVC")}\""
								: $"{kryptonTextBoxLettersResults.Text}{separator}\"{GenerateLettersName(pattern: "CVCVC")}\"";
							kryptonTextBoxLettersResults.SelectionStart = kryptonTextBoxLettersResults.Text.Length;
							kryptonTextBoxLettersResults.ScrollToCaret();
							return; // Exit early since we handle quotes differently
						}
			// If not enclosed with quotes, we will use the selected separator
			if (kryptonTextBoxLettersResults.Text.Length > 0 && !kryptonTextBoxLettersResults.Text.EndsWith(value: separator.ToString()))
			{
				kryptonTextBoxLettersResults.AppendText(value: separator.ToString());
			}
			  */


			if (toolStripMenuItemOutputOptionsClearListWithEveryGeneration.Checked)
			{
				// Clear the results textbox before generating new names
				kryptonTextBoxLettersResults.Text = string.Empty;
			}
			// Generate the specified number of names
			for (int i = 0; i < kryptonNumericUpDownSetLettersNumberNames.Value; i++)
			{
				kryptonTextBoxLettersResults.Text = string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text)
					? $"{GenerateLettersName(pattern: "CVCVC")}"
					: $"{kryptonTextBoxLettersResults.Text}{separator}{GenerateLettersName(pattern: "CVCVC")}";
				kryptonTextBoxLettersResults.SelectionStart = kryptonTextBoxLettersResults.Text.Length;
				kryptonTextBoxLettersResults.ScrollToCaret();
			}

			kryptonButtonStartLettersOutput.Enabled = true; // Re-enable the button after generation is complete
		}

		/// <summary>
		/// Handles the background worker operation for generating syllable-based names.
		/// Generates the specified number of names and appends them to the syllable results textbox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
		private void BackgroundWorkerSyllableName_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			for (int i = 0; i < kryptonNumericUpDownSetSyllablesNumberNames.Value; i++)
			{
				kryptonTextBoxSyllablesResults.Text = string.IsNullOrWhiteSpace(value: kryptonTextBoxSyllablesResults.Text)
					? $"{GenerateSyllablesName()}"
					: $"{kryptonTextBoxSyllablesResults.Text} {GenerateSyllablesName()}";
				kryptonTextBoxSyllablesResults.SelectionStart = kryptonTextBoxSyllablesResults.Text.Length;
				kryptonTextBoxSyllablesResults.ScrollToCaret();
			}
		}
	}
}
