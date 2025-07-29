using System.Text;

namespace Narthalas
{
    public partial class EssinForm : Form
    {
        public EssinForm()
        {
            InitializeComponent();
            kryptonTextBoxSyllablesResults.Text = string.Empty;
        }

        private static readonly Random random = new();

        private static readonly char[] vowels =
        {
            'a', 'e', 'i', 'o', 'u'
        };

        private static readonly char[] consonants =
        {
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v', 'w', 'z'
        };

        private static readonly string[] syllablesBegin =
        {
            "Al", "Bel", "Dar", "El", "Fen", "Gar", "Hal", "Is", "Jon", "Kel", "Lor", "Mar", "Nor", "Or", "Per", "Quin",
            "Ran", "Sor", "Tor", "Ul", "Val", "Wil", "Xan", "Yor", "Zan"
        };

        private static readonly string[] syllablesMiddle =
        {
            "a", "e", "i", "o", "u", "ae", "ia", "ou", "ar", "ir", "or", "ur", "el", "an", "en", "in", "on", "un"
        };

        private static readonly string[] syllablesEnd =
        {
            "dor", "ric", "son", "mir", "tis", "las", "nix", "zor", "ran", "th", "ien", "dus", "var", "len", "mon",
            "gorn", "rek", "wyn", "dil", "rix"
        };

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

        private static char RandomChar(char[] chars)
        {
            return chars[random.Next(maxValue: chars.Length)];
        }

        // Muster z. B. "CVCV", "VCVC", "CVCVC", etc.
        private static string GenerateLettersName(string pattern = "CVCVC")
        {
            StringBuilder name = new();

            foreach (char c in pattern.ToUpper())
            {
                if (c == 'C')
                    name.Append(value: RandomChar(chars: consonants));
                else if (c == 'V')
                    name.Append(value: RandomChar(chars: vowels));
            }

            // Ersten Buchstaben großschreiben
            if (name.Length > 0)
                name[index: 0] = char.ToUpper(c: name[index: 0]);

            return name.ToString();
        }

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

        private void KryptonButtonStartSyllabesOutput_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kryptonNumericUpDownSetSyllablesNumberNames.Value; i++)
            {
                kryptonTextBoxSyllablesResults.Text = string.IsNullOrWhiteSpace(value: kryptonTextBoxSyllablesResults.Text)
                    ? $"{GenerateSyllablesName()}"
                    : $"{kryptonTextBoxSyllablesResults.Text} {GenerateSyllablesName()} ";
                kryptonTextBoxSyllablesResults.SelectionStart = kryptonTextBoxSyllablesResults.Text.Length;
                kryptonTextBoxSyllablesResults.ScrollToCaret();
            }
        }

        private void KryptonButtonLettersOutputOptions_Click(object sender, EventArgs e)
        {
            // Position des Buttons relativ zum Formular
            Point buttonPosition = kryptonButtonLettersOutputOptions.PointToScreen(p: Point.Empty);
            // Position unterhalb des Buttons berechnen
            Point menuPosition = new(x: buttonPosition.X, y: buttonPosition.Y + kryptonButtonLettersOutputOptions.Height);
            // Kontextmenü an dieser Position anzeigen
            contextMenuStripResultOptions.Show(screenLocation: menuPosition);
        }

        private void KryptonButtonSyllablesOutputOptions_Click(object sender, EventArgs e)
        {
            // Position des Buttons relativ zum Formular
            Point buttonPosition = kryptonButtonSyllablesOutputOptions.PointToScreen(p: Point.Empty);
            // Position unterhalb des Buttons berechnen
            Point menuPosition = new(x: buttonPosition.X, y: buttonPosition.Y + kryptonButtonSyllablesOutputOptions.Height);
            // Kontextmenü an dieser Position anzeigen
            contextMenuStripResultOptions.Show(screenLocation: menuPosition);
        }

        private void ToolStripMenuItemOutputOptionsEntriesLineByLine_Click(object sender, EventArgs e)
        {

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

        private void KryptonButtonStartLettersOutput_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kryptonNumericUpDownSetLettersNumberNames.Value; i++)
            {
                kryptonTextBoxLettersResults.Text = string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text)
                    ? $"{GenerateLettersName(pattern: "CVCVC")}"
                    : $"{kryptonTextBoxLettersResults.Text} {GenerateLettersName(pattern: "CVCVC")} ";
                kryptonTextBoxLettersResults.SelectionStart = kryptonTextBoxLettersResults.Text.Length;
                kryptonTextBoxLettersResults.ScrollToCaret();

            }
        }
    }
}
