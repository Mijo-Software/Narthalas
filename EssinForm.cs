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
		[
			'a', 'e', 'i', 'o', 'u'
		];

		/// <summary>
		/// Array of consonant characters used in letter-based name generation.
		/// </summary>
		private static readonly char[] consonants =
		[
			'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v', 'w', 'z'
		];

		/// <summary>
		/// The default vowel set used for letter-based name generation.
		/// This string is initialized from the <see cref="vowels"/> character array.
		/// </summary>
		private readonly string DefaultVowelSet = new(value: vowels);

		/// <summary>
		/// The default consonant set used for letter-based name generation.
		/// This string is initialized from the <see cref="consonants"/> character array.
		/// </summary>
		private readonly string DefaultConsonantSet = new(value: consonants);

		/// <summary>
		/// Array of possible syllable beginnings for syllable-based name generation.
		/// </summary>
		private static readonly string[] syllablesBegin =
		[
			"Al", "Bel", "Dar", "El", "Fen", "Gar", "Hal", "Is", "Jon", "Kel", "Lor", "Mar", "Nor", "Or", "Per", "Quin",
			"Ran", "Sor", "Tor", "Ul", "Val", "Wil", "Xan", "Yor", "Zan"
		];

		/// <summary>
		/// Array of possible syllable middles for syllable-based name generation.
		/// </summary>
		private static readonly string[] syllablesMiddle =
		[
			"a", "e", "i", "o", "u", "ae", "ia", "ou", "ar", "ir", "or", "ur", "el", "an", "en", "in", "on", "un"
		];

		/// <summary>
		/// Array of possible syllable endings for syllable-based name generation.
		/// </summary>
		private static readonly string[] syllablesEnd =
		[
			"dor", "ric", "son", "mir", "tis", "las", "nix", "zor", "ran", "th", "ien", "dus", "var", "len", "mon",
			"gorn", "rek", "wyn", "dil", "rix"
		];

		/// <summary>
		/// Stores the enclosing quote character(s) to be used for generated names, if the option is enabled.
		/// If empty, names will not be enclosed in quotes.
		/// </summary>
		private string quote = string.Empty;

		/// <summary>
		/// The default pattern used for letter-based name generation.
		/// 'C' stands for consonant, 'V' for vowel (e.g., "CVCVC").
		/// </summary>
		private const string DefaultPattern = "CVCVC"; // Default pattern for letter-based name generation

		/// <summary>
		/// Stores the current pattern used for letter-based name generation.
		/// This pattern can be changed at runtime and is initialized with the default pattern.
		/// </summary>
		private string pattern = DefaultPattern; // Random pattern for letter-based name generation

		/// <summary>
		/// Stores the newline character(s) to use between generated names in the output.
		/// Is set to <see cref="Environment.NewLine"/> if line-by-line output is enabled, otherwise empty.
		/// </summary>
		private string newLine = string.Empty; // Default new line character for output

		/// <summary>
		/// Stores the separator string to use between generated names in the output.
		/// Can be changed by the user (e.g., space, comma, pipe, semicolon).
		/// </summary>
		private string separator = " "; // Default separator for output, can be changed based on user selection

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

		private static char RandomChar(string input)
		{
			// Check if the input string is null or empty
			ArgumentNullException.ThrowIfNull(argument: input, paramName: nameof(input));

			// If the input string is null or empty, throw an exception
			// This ensures that the method does not throw an exception when trying to access an empty string
			// This will ensure that the method does not throw an exception when trying to access an empty string
			if (string.IsNullOrEmpty(value: input))
			{
				// If the string is empty, throw an exception
				throw new ArgumentException(message: "Input string cannot be null or empty.", paramName: nameof(input));
			}

			// Generate a random index within the bounds of the input string
			// This will return a random character from the provided string
			return input[index: random.Next(maxValue: input.Length)];
		}

		/// <summary>
		/// Returns a random character from the specified array.
		/// </summary>
		/// <param name="chars">The array of characters to choose from.</param>
		/// <returns>A randomly selected character from the array.</returns>
		private static char RandomChar(char[] chars)
		{
			// Check if the chars array is null or empty
			ArgumentNullException.ThrowIfNull(argument: chars);
			if (chars.Length == 0)
			{
				// If the array is empty, throw an exception
				throw new ArgumentException(message: "Character array cannot be empty.", paramName: nameof(chars));
			}
			// Generate a random index within the bounds of the chars array
			// This will return a random character from the provided array of characters
			// The random index is generated using the static Random instance
			return chars[random.Next(maxValue: chars.Length)];
		}

		/// <summary>
		/// Scrolls the letter results textbox to the end, ensuring the latest generated name is visible.
		/// </summary>
		private void ScrollToTextBoxLettersResultEnd()
		{
			// Check if the letters results textbox is not null
			ArgumentNullException.ThrowIfNull(argument: kryptonTextBoxLettersResults);
			// Scroll to the end of the text in the letters results textbox
			kryptonTextBoxLettersResults.SelectionStart = kryptonTextBoxLettersResults.Text.Length;
			kryptonTextBoxLettersResults.ScrollToCaret();
		}

		/// <summary>
		/// Creates a random letter pattern of the specified length, alternating between vowels ('V') and consonants ('C').
		/// The starting character type (vowel or consonant) is determined by the selected radio button.
		/// </summary>
		/// <param name="length">The length of the pattern to generate. Must be at least 1.</param>
		/// <returns>A string pattern consisting of 'C' and 'V' characters.</returns>
		/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="length"/> is less than 1.</exception>
		/// <exception cref="InvalidOperationException">Thrown if no valid starting option is selected.</exception>
		private string CreateRandomLetterPattern(int length)
		{
			// Create a random letter pattern with alternating vowels and consonants
			// Check if the length is less than 1
			if (length < 1)
			{
				// If the length is less than 1, throw an exception
				throw new ArgumentOutOfRangeException(paramName: nameof(length), message: "Length must be at least 1.");
			}
			// Initialize an empty string to hold the pattern
			// This pattern will alternate between vowels and consonants based on the starting option selected by the user
			string pattern = string.Empty;
			// Determine whether to start with a vowel or consonant based on the selected radio button
			// This will ensure that the pattern starts with the correct type of letter based on user preference
			// Initialize boolean flags to track whether the next character should be a vowel or consonant
			// These flags will be used to alternate between vowels and consonants as per the selected starting option
			bool isVowel;
			bool isConsonant;

			// Check which radio button is selected to determine the starting character type
			// This will set the initial state for whether the first character should be a vowel or consonant
			// Based on the selected radio button, set the initial state for isVowel and isConsonant
			// This will ensure that the pattern starts with the correct type of letter based on user preference
			// If the starting option is set to start with a consonant, set isVowel to false and isConsonant to true
			// If the starting option is set to start with a random letter, randomly decide whether to start with a vowel or consonant
			// If the starting option is set to start with a vowel, set isVowel to true and isConsonant to false
			// If none of the radio buttons are checked, throw an exception to ensure a valid starting option is selected
			// This will ensure that the user has selected a valid starting option for the letter pattern
			if (kryptonRadioButtonStartingWithConsonant.Checked)
			{
				// Start with a consonant
				isVowel = false;
				// Next character should be a consonant
				isConsonant = true;
			}
			else if (kryptonRadioButtonStartingWithRandomLetter.Checked)
			{
				// Randomly decide whether to start with a vowel or consonant
				isVowel = random.Next(maxValue: 2) == 0; // 50% chance to start with a vowel
				isConsonant = !isVowel; // If not a vowel, it must be a consonant
			}
			else if (kryptonRadioButtonStartingWithVowel.Checked)
			{
				// Start with a vowel
				isVowel = true;
				// Next character should be a consonant
				isConsonant = false;
			}
			else
			{
				// If none of the radio buttons are checked, throw an exception
				// This ensures that the user has selected a valid starting option for the letter pattern
				throw new InvalidOperationException(message: "Unrecognized starting option for letter pattern.");
			}

			// Loop through the specified length to create the pattern
			// This loop will alternate between vowels and consonants based on the starting option selected by the user
			// For each character in the pattern, append either a vowel or consonant based on the current state
			// This will ensure that the pattern alternates correctly between vowels and consonants
			// The loop will run for the specified length, appending characters to the pattern string
			// The pattern will be built by appending either a vowel or consonant based on the current state
			// The isVowel and isConsonant flags will be toggled after each character is appended
			// This will ensure that the next character will be of the opposite type (vowel or consonant)
			// The final pattern will be a string of alternating vowels and consonants based on the selected starting option
			for (int j = 0; j < length; j++)
			{
				// Check if the current character should be a vowel or consonant based on the flags
				// If isVowel is true, append a random vowel to the pattern
				// If isConsonant is true, append a random consonant to the pattern
				// After appending a character, toggle the flags to switch to the opposite type for the next character
				// This will ensure that the next character will be of the opposite type (vowel or consonant)
				// If the current character is a vowel, append a random vowel to the pattern
				// If the current character is a consonant, append a random consonant to the pattern
				// The pattern will alternate between vowels and consonants based on the selected starting option
				if (isVowel)
				{
					// Append a random vowel to the pattern
					pattern += "V";
					// Next character should be a consonant
					isVowel = false;
					// Next character should be a consonant
					isConsonant = true;
				}
				else if (isConsonant)
				{
					// Append a random consonant to the pattern
					pattern += "C";
					// Next character should be a vowel
					isVowel = true;
					// Next character should be a vowel
					isConsonant = false;
				}
			}
			// Return the generated pattern
			// This pattern will be a string of alternating vowels and consonants based on the selected starting option
			// The pattern will be used to generate names based on the specified length
			// The final pattern will be a string of 'C' and 'V' characters representing consonants and vowels
			return pattern;
		}

		/// <summary>
		/// Creates a random letter pattern with the specified fixed length.
		/// The pattern alternates between vowels ('V') and consonants ('C') based on the starting option.
		/// </summary>
		/// <param name="length">The length of the pattern to generate.</param>
		/// <returns>A string pattern consisting of 'C' and 'V' characters.</returns>
		private string CreateRandomLetterPatternWithLength(int length)
		{
			// Create a random letter pattern with the specified length
			return CreateRandomLetterPattern(length);
		}

		/// <summary>
		/// Creates a random letter pattern with a random length between the specified minimum and maximum values (inclusive).
		/// The pattern alternates between vowels ('V') and consonants ('C') based on the starting option.
		/// </summary>
		/// <param name="minLength">The minimum length of the pattern.</param>
		/// <param name="maxLength">The maximum length of the pattern.</param>
		/// <returns>A string pattern consisting of 'C' and 'V' characters.</returns>
		private string CreateRandomLetterPatternWithRandomMinAndMaxLength(int minLength, int maxLength)
		{
			// Create a random letter pattern with alternating vowels and consonants
			int length = random.Next(minValue: minLength, maxValue: maxLength + 1);
			// Generate a random length between minLength and maxLength (inclusive)
			return CreateRandomLetterPattern(length);
		}

		/// <summary>
		/// Generates a name based on a given pattern of consonants (C) and vowels (V).
		/// </summary>
		/// <param name="pattern">A string pattern using 'C' for consonant and 'V' for vowel (e.g., "CVCVC").</param>
		/// <returns>A generated name following the specified pattern, with the first letter capitalized.</returns>
		private string GenerateLettersName(string pattern = DefaultPattern)
		{
			// Define a StringBuilder to build the name
			StringBuilder name = new();

			// Validate the pattern to ensure it contains only 'C' and 'V'
			if (string.IsNullOrWhiteSpace(value: pattern))
			{
				throw new ArgumentException(message: "Pattern cannot be null or empty.", paramName: nameof(pattern));
			}

			// Iterate through each character in the pattern
			// Ensure the pattern contains only 'C' and 'V'
			// If the pattern contains any character other than 'C' or 'V', it will throw an exception
			// This ensures that the pattern is strictly followed
			foreach (char c in pattern.ToUpper())
			{
				// Check if the character is 'C' for consonant or 'V' for vowel
				if (c != 'C' && c != 'V')
				{
					throw new ArgumentException(message: "Pattern must contain only 'C' for consonants and 'V' for vowels.", paramName: nameof(pattern));
				}

				// Append a random character based on the pattern
				// If the character is 'C', append a random consonant; if 'V', append a random vowel
				// If the character is neither 'C' nor 'V', it will throw an exception
				// This ensures that the pattern is strictly followed
				if (c == 'C')
				{
					// Append a random consonant
					_ = name.Append(value: RandomChar(input: kryptonTextBoxLetterSetConsonants.Text));
				}
				else if (c == 'V')
				{
					// Append a random vowel
					_ = name.Append(value: RandomChar(input: kryptonTextBoxLetterSetVowels.Text));
				}
			}

			// Capitalize the first letter
			if (name.Length > 0)
			{
				// Ensure the first character is uppercase
				// This is done by converting the first character to uppercase and replacing it in the StringBuilder
				name[index: 0] = char.ToUpper(c: name[index: 0]);
			}

			// Return the generated name as a string
			return name.ToString();
		}

		/// <summary>
		/// Generates a name based on a given pattern and ensures the result has the specified fixed length.
		/// Tries multiple times to generate a name matching the fixed length; if unsuccessful, returns a name with the given pattern.
		/// </summary>
		/// <param name="pattern">A string pattern using 'C' for consonant and 'V' for vowel (e.g., "CVCVC").</param>
		/// <param name="fixedLength">The required fixed length of the generated name.</param>
		/// <returns>A generated name of the specified fixed length, or a name with the given pattern if no match is found.</returns>
		private string GenerateLettersName(string pattern = DefaultPattern, int fixedLength = 5)
		{
			for (int i = 0; i < fixedLength + 1; i++)
			{
				// Generate a name based on the provided pattern
				string generatedName = GenerateLettersName(pattern: pattern);
				// Check if the generated name's length matches the specified fixed length
				if (generatedName.Length == fixedLength)
				{
					return generatedName;
				}
			}
			// Fallback: Return a name with the pattern if no matching length is found
			return GenerateLettersName(pattern: pattern);
		}

		/// <summary>
		/// Generates a name based on a given pattern and ensures the result is within the specified length range.
		/// Tries multiple times to generate a name within the range; if unsuccessful, returns a name with the given pattern.
		/// </summary>
		/// <param name="pattern">A string pattern using 'C' for consonant and 'V' for vowel (e.g., "CVCVC").</param>
		/// <param name="minLength">The minimum allowed length of the generated name.</param>
		/// <param name="maxLength">The maximum allowed length of the generated name.</param>
		/// <returns>A generated name within the specified length range, or a name with the given pattern if no match is found.</returns>
		private string GenerateLettersName(string pattern = DefaultPattern, int minLength = 2, int maxLength = 10)
		{
			for (int i = minLength; i < maxLength + 1; i++)
			{
				// Generate a name based on the provided pattern
				string generatedName = GenerateLettersName(pattern: pattern);

				// Check if the generated name's length is within the specified range
				if (generatedName.Length >= minLength && generatedName.Length <= maxLength)
				{
					return generatedName;
				}
			}
			// Fallback: Return a name with the pattern if no matching length is found
			return GenerateLettersName(pattern: pattern);
		}

		/// <summary>
		/// Generates a name by combining random syllables.
		/// </summary>
		/// <param name="numberSyllables">The number of syllables to include in the name (minimum 2).</param>
		/// <returns>A generated name composed of a beginning, middle, and ending syllable.</returns>
		private static string GenerateSyllablesName(int numberSyllables = 2)
		{
			StringBuilder sb = new();
			_ = sb.Append(value: syllablesBegin[random.Next(maxValue: syllablesBegin.Length)]);

			for (int i = 0; i < numberSyllables - 1; i++)
			{
				// Append a random middle syllable

				/*
                // If the number of syllables is less than 2, it will not append any middle syllables
                if (i > 0)
                {
                    // Add a space before the middle syllable if it's not the first one
                    _ = sb.Append(value: " ");
                }
                // Append a random middle syllable
                // This allows for multiple middle syllables to be added based on the specified count
                // The random middle syllable is chosen from the syllablesMiddle array
                if (numberSyllables > 2 || i < numberSyllables - 2)
                {
                    _ = sb.Append(value: syllablesMiddle[random.Next(maxValue: syllablesMiddle.Length)]);
                }
                // If the number of syllables is 2, it will not append any middle syllables
                else if (numberSyllables == 2 && i == 0)
                {
                    // Append a middle syllable only for the first iteration if the total syllables are 2
                    _ = sb.Append(value: syllablesMiddle[random.Next(maxValue: syllablesMiddle.Length)]);
                }
                */

				_ = sb.Append(value: syllablesMiddle[random.Next(maxValue: syllablesMiddle.Length)]);
			}

			_ = sb.Append(value: syllablesEnd[random.Next(maxValue: syllablesEnd.Length)]);

			return sb.ToString();
		}

		#endregion

		#region Load event handler

		/// <summary>
		/// Handles the Load event of the <see cref="EssinForm"/>.
		/// Sets the default output separator option to space when the form is loaded.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void EssinForm_Load(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Set the status bar text to indicate that the form has loaded
			SetStatusBar(text: "Essin-Modul geladen. Bitte wählen Sie eine Option aus, um Namen zu generieren.");
			// Set the default pattern for letter-based name generation
			//kryptonTextBoxLetterSetPattern.TextBox.Text = DefaultPattern;
			// Set the default letter set for consonants and vowels
			kryptonTextBoxLetterSetConsonants.TextBox.Text = new string(value: consonants);
			kryptonTextBoxLetterSetVowels.TextBox.Text = new string(value: vowels);
			// Set the default letter set for language style consonants and vowels
			kryptonTextBoxLettersLanguageStyleConsonants.TextBox.Text = new string(value: consonants);
			kryptonTextBoxLettersLanguageStyleVowels.TextBox.Text = new string(value: vowels);
			// Set the default individual pattern for letter-based name generation
			kryptonTextBoxIndividualPattern.TextBox.Text = string.Empty;
			// Allow only letters in the relevant textboxes
			InputValidator.AllowOnlyLetters(textBox: kryptonTextBoxLetterSetConsonants.TextBox); // Allow only letters in the consonants textbox
			InputValidator.AllowOnlyLetters(textBox: kryptonTextBoxLetterSetVowels.TextBox); // Allow only letters in the vowels textbox
			InputValidator.AllowOnlyLetters(textBox: kryptonTextBoxLettersLanguageStyleConsonants.TextBox); // Allow only letters in the language style consonants textbox
			InputValidator.AllowOnlyLetters(textBox: kryptonTextBoxLettersLanguageStyleVowels.TextBox); // Allow only letters in the language style vowels textbox
			InputValidator.AllowOnlyLetters(textBox: kryptonTextBoxIndividualPattern.TextBox); // Allow only letters in the individual pattern textbox
																							   // Set the default fixed word length to 5
			kryptonNumericUpDownWordLengthFixed.Value = 5;
			// Set the minimum word length for variable word lengths
			kryptonNumericUpDownWordLengthVariableMinimum.Value = 2;
			// Set the maximum word length for variable word lengths
			kryptonNumericUpDownWordLengthVariableMaximum.Value = 10;
			// Set the default radio button for starting with a random letter
			kryptonRadioButtonStartingWithRandomLetter.Checked = true;
			// This will prevent user input until the individual pattern option is selected
			kryptonTextBoxIndividualPattern.ReadOnly = true;
			// Disable the button to set the individual pattern
			kryptonButtonIndividualPatternSetConsonant.Enabled = false;
			// Disable the button to clear the individual pattern textbox
			kryptonButtonClearTextBoxIndividualPattern.Enabled = false;
			// Disable the button to set the individual pattern for vowels
			kryptonButtonkryptonButtonIndividualPatternSetVowel.Enabled = false;
			// Set the default radio button for variable word length
			kryptonRadioButtonWordLengthVariable.Checked = true;
			// Set default separator to space
			toolStripMenuItemOutputOptionsSeparatorIsSpace.Checked = true;
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
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

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
		private void ClearStatusBar_Leave(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);
			// Clear the status bar text when the mouse leaves the control
			ClearStatusBar();
		}

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
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

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
		/// Handles the click event for the button that starts the letter-based name generation.
		/// Initiates the background worker to generate names based on letter patterns.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonStartLettersOutput_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Check if the background worker for letter names is not already running
			if (backgroundWorkerLetterNames.IsBusy)
			{
				// If the background worker is already running, show a message and return
				_ = MessageBox.Show(text: "Die Generierung von Buchstabennamen läuft bereits.", caption: "Info", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
				SetStatusBar(text: "Die Generierung von Buchstabennamen läuft bereits.");
				return;
			}
			// If the background worker is not busy, start it to generate letter-based names
			backgroundWorkerLetterNames.RunWorkerAsync();
		}

		/// <summary>
		/// Handles the click event for the button that starts the syllable-based name generation.
		/// Initiates the background worker to generate names based on syllables.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonStartSyllabesOutput_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Check if the background worker for syllable names is not already running
			if (backgroundWorkerSyllableName.IsBusy)
			{
				// If the background worker is already running, show a message and return
				_ = MessageBox.Show(text: "Die Generierung von Silbennamen läuft bereits.", caption: "Info", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
				SetStatusBar(text: "Die Generierung von Silbennamen läuft bereits.");
				return;
			}
			// If the background worker is not busy, start it to generate syllable-based names
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
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

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
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Position des Buttons relativ zum Formular
			Point buttonPosition = kryptonButtonSyllablesOutputOptions.PointToScreen(p: Point.Empty);
			// Position unterhalb des Buttons berechnen
			Point menuPosition = new(x: buttonPosition.X, y: buttonPosition.Y + kryptonButtonSyllablesOutputOptions.Height);
			// Kontextmenü an dieser Position anzeigen
			contextMenuStripResultOptions.Show(screenLocation: menuPosition);
		}

		/// <summary>
		/// Handles the click event for setting the output separator to a space character.
		/// Updates the separator, status bar, and unchecks other separator options.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemOutputOptionsSeparatorIsSpace_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Set the separator to space and update the status bar
			separator = " ";
			SetStatusBar(text: "Ergebnisse werden mit Leerzeichen getrennt.");
			// Uncheck other separator options
			toolStripMenuItemOutputOptionsSeparatorIsComma.Checked = false;
			toolStripMenuItemOutputOptionsSeparatorIsPipe.Checked = false;
			toolStripMenuItemOutputOptionsSeparatorIsSemicolon.Checked = false;
		}

		/// <summary>
		/// Handles the click event for setting the output separator to a comma.
		/// Updates the separator, status bar, and unchecks other separator options.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemOutputOptionsSeparatorIsComma_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Set the separator to comma and update the status bar
			separator = ",";
			SetStatusBar(text: "Ergebnisse werden mit Kommas getrennt.");
			// Uncheck other separator options
			toolStripMenuItemOutputOptionsSeparatorIsSpace.Checked = false;
			toolStripMenuItemOutputOptionsSeparatorIsPipe.Checked = false;
			toolStripMenuItemOutputOptionsSeparatorIsSemicolon.Checked = false;
		}

		/// <summary>
		/// Handles the click event for setting the output separator to a pipe character.
		/// Updates the separator, status bar, and unchecks other separator options.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemOutputOptionsSeparatorIsPipe_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);
			// If the sender is not a Form, throw an exception

			// Set the separator to pipe and update the status bar
			separator = "|";
			SetStatusBar(text: "Ergebnisse werden mit Pipes getrennt.");
			// Uncheck other separator options
			toolStripMenuItemOutputOptionsSeparatorIsSpace.Checked = false;
			toolStripMenuItemOutputOptionsSeparatorIsComma.Checked = false;
			toolStripMenuItemOutputOptionsSeparatorIsSemicolon.Checked = false;
		}

		/// <summary>
		/// Handles the click event for setting the output separator to a semicolon.
		/// Updates the separator, status bar, and unchecks other separator options.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemOutputOptionsSeparatorIsSemikolon_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Set the separator to semicolon and update the status bar
			separator = ";";
			SetStatusBar(text: "Ergebnisse werden mit Semikolons getrennt.");
			// Uncheck other separator options
			toolStripMenuItemOutputOptionsSeparatorIsSpace.Checked = false;
			toolStripMenuItemOutputOptionsSeparatorIsComma.Checked = false;
			toolStripMenuItemOutputOptionsSeparatorIsPipe.Checked = false;
		}

		/// <summary>
		/// Handles the click event for the option to output entries line by line.
		/// Sets the new line character and updates the status bar based on the checked state of the menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemOutputOptionsEntriesLineByLine_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);
			// If the sender is not a Form, throw an exception

			// Set newLine and status bar text based on the checked state
			newLine = toolStripMenuItemOutputOptionsEntriesLineByLine.Checked ? Environment.NewLine : string.Empty;
			SetStatusBar(text: toolStripMenuItemOutputOptionsEntriesLineByLine.Checked
				? "Ergebnisse werden zeilenweise ausgegeben."
				: "Ergebnisse werden nicht zeilenweise ausgegeben.");
		}

		/// <summary>
		/// Handles the click event for toggling the option to enclose generated results with quotes.
		/// Sets the <c>quote</c> field based on the checked state and updates the status bar accordingly.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemOutputOptionsEnclosedWithQuotes_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);
			// If the sender is not a Form, throw an exception

			// Set quote to enclose results if the option is checked, otherwise use no quotes
			quote = toolStripMenuItemOutputOptionsEnclosedWithQuotes.Checked ? "\"" : string.Empty;
			// Update the status bar to reflect the change
			SetStatusBar(text: toolStripMenuItemOutputOptionsEnclosedWithQuotes.Checked
				? "Ergebnisse werden in Anführungszeichen gesetzt."
				: "Ergebnisse werden nicht in Anführungszeichen gesetzt.");
		}

		/// <summary>
		/// Handles the click event for copying the letter-based results to the clipboard.
		/// Copies the contents of the letter results textbox to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonCopyLettersResultsToClipboard_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Check if the text box is not null or empty
			if (string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text))
			{
				// Show an error message if there are no letters results to copy
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Keine Buchstabenergebnisse zum Kopieren vorhanden.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Keine Buchstabenergebnisse zum Kopieren vorhanden.");
				return;
			}
			// Copy the text to the clipboard
			// This will copy the text from the letters results textbox to the clipboard
			Clipboard.SetText(text: kryptonTextBoxLettersResults.Text);
		}

		/// <summary>
		/// Handles the click event for copying the syllable-based results to the clipboard.
		/// Copies the contents of the syllable results textbox to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonCopySyllablesResultsToClipboard_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Check if the text box is not null or empty
			if (string.IsNullOrWhiteSpace(value: kryptonTextBoxSyllablesResults.Text))
			{
				// Show an error message if there are no letters results to copy
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Keine Silbenergebnisse zum Kopieren vorhanden.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Keine Silbenergebnisse zum Kopieren vorhanden.");
				return;
			}
			// Copy the text to the clipboard
			// This will copy the text from the syllables results textbox to the clipboard
			Clipboard.SetText(text: kryptonTextBoxSyllablesResults.Text);
		}

		/// <summary>
		/// Handles the click event for deleting the letter-based results.
		/// Clears the contents of the letter results textbox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonDeleteLettersResultsToClipboard_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);
			// If the sender is not a Form, throw an exception

			// Check if the text box is not null or empty
			if (string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text))
			{
				// Show an error message if there are no letters results to delete
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Keine Buchstabenergebnisse zum Löschen vorhanden.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Keine Buchstabenergebnisse zum Löschen vorhanden.");
				return;
			}
			// Clear the text box
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
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Check if the text box is not null or empty
			if (string.IsNullOrWhiteSpace(value: kryptonTextBoxSyllablesResults.Text))
			{
				// Show an error message if there are no letters results to delete
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Keine Silbenergebnisse zum Löschen vorhanden.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Keine Silbenergebnisse zum Löschen vorhanden.");
				return;
			}
			// Clear the text box
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
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			if (string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text))
			{
				// Show an error message if there are no letters results to save
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Keine Buchstabenergebnisse zum Speichern vorhanden.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Keine Buchstabenergebnisse zum Speichern vorhanden.");
				return;
			}

			// Save the letters results to a file
			SaveFileDialog saveFileDialog = new()
			{
				Title = "Buchstabenbasiertes Ergebnis speichern",
				Filter = "Textdateien (*.txt)|*.txt|alle Dateien (*.*)|*.*",
				DefaultExt = "txt",
				AddExtension = true
			};

			// Show the save file dialog to the user
			// If the user selects a file and clicks OK, proceed to save the results
			// This will display a dialog for the user to choose where to save the results
			// If the user cancels the dialog, no action is taken
			// If the user selects a file and clicks OK, proceed to save the results
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Attempt to write the contents of the letters results textbox to the selected file
				try
				{
					// Write the contents of the letters results textbox to the selected file
					System.IO.File.WriteAllText(path: saveFileDialog.FileName, contents: kryptonTextBoxLettersResults.Text);
					_ = MessageBox.Show(text: "Ergebnis abgespeichert.", caption: "Erfolg", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
					SetStatusBar(text: "Ergebnis abgespeichert.", additionalInfo: saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					// Show an error message if there was an issue saving the results
					// This will display an error message box with the exception details
					// and update the status bar with the error message
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
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			if (string.IsNullOrWhiteSpace(value: kryptonTextBoxSyllablesResults.Text))
			{
				// Show an error message if there are no syllables results to save
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Keine Silbenergebnisse zum Speichern vorhanden.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Keine Silbenergebnisse zum Speichern vorhanden.");
				return;
			}

			// Save the letters results to a file
			SaveFileDialog saveFileDialog = new()
			{
				Title = "Silbenbasiertes Ergebnis speichern",
				Filter = "Textdateien (*.txt)|*.txt|alle Dateien (*.*)|*.*",
				DefaultExt = "txt",
				AddExtension = true
			};

			// Show the save file dialog to the user
			// If the user selects a file and clicks OK, proceed to save the results
			// This will display a dialog for the user to choose where to save the results
			// If the user cancels the dialog, no action is taken
			// If the user selects a file and clicks OK, proceed to save the results
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Attempt to write the contents of the syllables results textbox to the selected file
				try
				{
					// Write the contents of the syllables results textbox to the selected file
					System.IO.File.WriteAllText(path: saveFileDialog.FileName, contents: kryptonTextBoxSyllablesResults.Text);
					_ = MessageBox.Show(text: "Ergebnis abgespeichert.", caption: "Erfolg", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
					SetStatusBar(text: "Ergebnis abgespeichert.", additionalInfo: saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					// Show an error message if there was an issue saving the results
					// This will display an error message box with the exception details
					// and update the status bar with the error message
					_ = MessageBox.Show(text: "Fehler bei der Abspeicherung des Ergebnisses", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
					SetStatusBar(text: "Fehler bei der Abspeicherung des Ergebnisses", additionalInfo: ex.Message);
				}
			}
		}

		/// <summary>
		/// Handles the click event for toggling the use of an individual pattern for name generation.
		/// Enables or disables related controls based on the checkbox state.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonCheckBoxUseIndividualPattern_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Enable or disable the letter set, word length, starting, and language styles group boxes based on the checkbox state
			// This will enable or disable the letter set, word length, starting, and language styles group boxes
			// when the user checks or unchecks the individual pattern checkbox
			// ToggleIndividualPatternControls();
			if (kryptonCheckBoxUseIndividualPattern.Checked)
			{
				groupBoxWordLength.Enabled = false; // Disable the word length group box when using an individual pattern
				groupBoxStarting.Enabled = false; // Disable the starting group box when using an individual pattern
				groupBoxLettersLanguageStyles.Enabled = false; // Disable the language styles group box when using an individual pattern
				kryptonButtonIndividualPatternSetConsonant.Enabled = true; // Enable the button to set the individual pattern
				kryptonButtonkryptonButtonIndividualPatternSetVowel.Enabled = true; // Enable the button to set the individual pattern for vowels
				kryptonButtonClearTextBoxIndividualPattern.Enabled = true; // Enable the button to clear the individual pattern textbox
			}
			else
			{
				groupBoxWordLength.Enabled = true; // Enable the word length group box when not using an individual pattern
				groupBoxStarting.Enabled = true; // Enable the starting group box when not using an individual pattern
				groupBoxLettersLanguageStyles.Enabled = true; // Enable the language styles group box when not using an individual pattern
				kryptonButtonIndividualPatternSetConsonant.Enabled = false; // Disable the button to set the individual pattern
				kryptonButtonkryptonButtonIndividualPatternSetVowel.Enabled = false; // Disable the button to set the individual pattern for vowels
				kryptonButtonClearTextBoxIndividualPattern.Enabled = false; // Disable the button to clear the individual pattern textbox
			}
		}

		/// <summary>
		/// Handles the click event for adding a consonant ('C') to the individual pattern textbox.
		/// Appends 'C' to the textbox for custom pattern creation.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonIndividualPatternSetConsonant_Click(object sender, EventArgs e)
		{
			// Check if the individual pattern textbox is not null
			ArgumentNullException.ThrowIfNull(argument: kryptonTextBoxIndividualPattern);
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Append 'C' for consonant to the individual pattern textbox
			kryptonTextBoxIndividualPattern.Text += "C";
		}

		/// <summary>
		/// Handles the click event for adding a vowel ('V') to the individual pattern textbox.
		/// Appends 'V' to the textbox for custom pattern creation.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonkryptonButtonIndividualPatternSetVowel_Click(object sender, EventArgs e)
		{
			// Check if the individual pattern textbox is not null
			ArgumentNullException.ThrowIfNull(argument: kryptonTextBoxIndividualPattern);
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Append 'V' for vowel to the individual pattern textbox
			kryptonTextBoxIndividualPattern.Text += "V";
		}

		/// <summary>
		/// Handles the click event for clearing the individual pattern textbox.
		/// Removes all content from the textbox used for custom letter patterns.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonClearTextBoxIndividualPattern_Click(object sender, EventArgs e)
		{
			// Check if the individual pattern textbox is not null
			ArgumentNullException.ThrowIfNull(argument: kryptonTextBoxIndividualPattern);
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Clear the individual pattern textbox
			kryptonTextBoxIndividualPattern.Text = string.Empty;
		}

		/// <summary>
		/// Handles the click event for applying the selected language style to the letter set text boxes.
		/// Updates the consonant and vowel text boxes with the values from the language style text boxes and updates the status bar.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonApplyLettersLanguageStyle_Click(object sender, EventArgs e)
		{
			// Check if the letter set text boxes are not null
			ArgumentNullException.ThrowIfNull(argument: kryptonTextBoxLetterSetConsonants);
			ArgumentNullException.ThrowIfNull(argument: kryptonTextBoxLetterSetVowels);
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Update the consonants language style textbox with the letter set for consonants
			kryptonTextBoxLetterSetConsonants.Text = kryptonTextBoxLettersLanguageStyleConsonants.Text;
			// Update the vowels language style textbox with the letter set for vowels
			kryptonTextBoxLetterSetVowels.Text = kryptonTextBoxLettersLanguageStyleVowels.Text;
			// Update the status bar to reflect the applied language style
			SetStatusBar(text: "Buchstabenstil angewendet.");
		}

		/// <summary>
		/// Handles the click event for resetting the letter set text boxes to their default values.
		/// Resets the consonant and vowel sets to their default values and updates the status bar.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void KryptonButtonLettersResetDefault_Click(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);
			// Reset the letter set text boxes to their default values
			kryptonTextBoxLetterSetConsonants.Text = DefaultConsonantSet;
			kryptonTextBoxLetterSetVowels.Text = DefaultVowelSet;
			// Update the status bar to reflect the reset action
			SetStatusBar(text: "Buchstabensätze auf Standard zurückgesetzt.");
		}

		#endregion

		#region BackgroundWorker event handlers

		/// <summary>
		/// Handles the background worker operation for generating letter-based names.
		/// Generates the specified number of names and appends them to the letter results textbox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
		private void BackgroundWorkerLetterNames_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			// Variable to hold the pattern for name generation
			if (string.IsNullOrEmpty(value: kryptonTextBoxLetterSetConsonants.Text) || string.IsNullOrEmpty(value: kryptonTextBoxLetterSetVowels.Text))
			{
				// Show an error message if the letter sets are not defined
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Bitte definieren Sie die Buchstabensätze für Konsonanten und Vokale.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Bitte definieren Sie die Buchstabensätze für Konsonanten und Vokale.");
				return;
			}

			// Validate the number of names to generate
			if (kryptonNumericUpDownSetLettersNumberNames.Value > kryptonNumericUpDownSetLettersNumberNames.Maximum)
			{
				// Show an error message if the number of names exceeds the maximum limit
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Die Anzahl der zu generierenden Namen darf maximal 100 sein.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Die Anzahl der zu generierenden Namen darf maximal 100 sein.");
				return;
			}

			// Validate the number of names to generate
			if (kryptonNumericUpDownSetLettersNumberNames.Value < kryptonNumericUpDownSetLettersNumberNames.Minimum)
			{
				// Show an error message if the number of names is below the minimum limit
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Die Anzahl der zu generierenden Namen muss mindestens 1 sein.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Die Anzahl der zu generierenden Namen muss mindestens 1 sein.");
				return;
			}

			if (toolStripMenuItemOutputOptionsClearListWithEveryGeneration.Checked)
			{
				// Clear the results textbox before generating new names
				kryptonTextBoxLettersResults.Text = string.Empty;
			}

			// Disable the button to prevent multiple clicks during generation
			kryptonButtonStartLettersOutput.Enabled = false;

			// Generate the specified number of names
			for (int i = 0; i < kryptonNumericUpDownSetLettersNumberNames.Value; i++)
			{
				if (kryptonCheckBoxUseIndividualPattern.Checked)
				{
					// Generate a name based on the individual pattern specified by the user
					// This will generate a name using the pattern defined in the individual pattern textbox
					// The pattern can include 'C' for consonants and 'V' for vowels
					pattern = kryptonTextBoxIndividualPattern.Text;
					if (string.IsNullOrWhiteSpace(value: pattern))
					{
						// Show an error message if the individual pattern is empty
						// This will display an error message box and update the status bar with the error message
						_ = MessageBox.Show(text: "Bitte geben Sie ein individuelles Muster ein.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
						SetStatusBar(text: "Bitte geben Sie ein individuelles Muster ein.");
						kryptonButtonStartLettersOutput.Enabled = true;
						return;
					}
					// Generate a name based on the individual pattern and append it to the results textbox
					// This will generate a name using the pattern defined in the individual pattern textbox
					kryptonTextBoxLettersResults.Text = string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text)
						? $"{quote}{GenerateLettersName(pattern: pattern)}{quote}"
						: $"{kryptonTextBoxLettersResults.Text}{separator}{newLine}{quote}{GenerateLettersName(pattern: pattern)}{quote}";
					ScrollToTextBoxLettersResultEnd();
				}
				else if (kryptonRadioButtonWordLengthVariable.Checked)
				{
					// Generate a name with variable word length
					// This will generate a name with a random length between the specified minimum and maximum values
					int minLength = (int)kryptonNumericUpDownWordLengthVariableMinimum.Value;
					int maxLength = (int)kryptonNumericUpDownWordLengthVariableMaximum.Value;

					// Ensure minLength is less than or equal to maxLength
					if (minLength > maxLength)
					{
						// Show an error message if the minimum length is greater than the maximum length
						// This will display an error message box and update the status bar with the error message
						_ = MessageBox.Show(text: "Die minimale Wortlänge darf nicht größer als die maximale Wortlänge sein.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
						SetStatusBar(text: "Die minimale Wortlänge darf nicht größer als die maximale Wortlänge sein.");
						kryptonButtonStartLettersOutput.Enabled = true;
						return;
					}

					pattern = CreateRandomLetterPatternWithRandomMinAndMaxLength(minLength: minLength, maxLength: maxLength);

					// Generate a name with variable word length and append it to the results textbox
					// This will generate a name with a random length between the specified minimum and maximum values
					kryptonTextBoxLettersResults.Text = string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text)
						? $"{quote}{GenerateLettersName(pattern: pattern, minLength: minLength, maxLength: maxLength)}{quote}"
						: $"{kryptonTextBoxLettersResults.Text}{separator}{newLine}{quote}{GenerateLettersName(pattern: pattern, minLength: minLength, maxLength: maxLength)}{quote}";
					ScrollToTextBoxLettersResultEnd();
				}
				else if (kryptonRadioButtonWordLengthFixed.Checked)
				{
					// Generate a name with fixed word length
					// This will generate a name with the specified fixed length
					int fixedLength = (int)kryptonNumericUpDownWordLengthFixed.Value;
					pattern = CreateRandomLetterPatternWithLength(length: fixedLength);

					// Generate a name with fixed word length and append it to the results textbox
					// This will generate a name with a fixed length
					kryptonTextBoxLettersResults.Text = string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text)
						? $"{quote}{GenerateLettersName(pattern: pattern, fixedLength: fixedLength)}{quote}"
						: $"{kryptonTextBoxLettersResults.Text}{separator}{newLine}{quote}{GenerateLettersName(pattern: pattern, fixedLength: fixedLength)}{quote}";
					ScrollToTextBoxLettersResultEnd();
				}
				else
				{
					// Generate a name based on the specified pattern and append it to the results textbox
					// This will generate a name using the default pattern defined in the class
					kryptonTextBoxLettersResults.Text = string.IsNullOrWhiteSpace(value: kryptonTextBoxLettersResults.Text)
						? $"{quote}{GenerateLettersName(pattern: DefaultPattern)}{quote}"
						: $"{kryptonTextBoxLettersResults.Text}{separator}{newLine}{quote}{GenerateLettersName(pattern: DefaultPattern)}{quote}";
					ScrollToTextBoxLettersResultEnd();
				}
			}

			// Re-enable the button after generation is complete
			kryptonButtonStartLettersOutput.Enabled = true;
		}

		/// <summary>
		/// Handles the background worker operation for generating syllable-based names.
		/// Generates the specified number of names and appends them to the syllable results textbox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
		private void BackgroundWorkerSyllableName_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			kryptonButtonStartSyllablesOutput.Enabled = false; // Disable the button to prevent multiple clicks during generation

			// Validate the number of names to generate
			if (kryptonNumericUpDownSetSyllablesNumberNames.Value > kryptonNumericUpDownSetSyllablesNumberNames.Maximum)
			{
				// Show an error message if the number of names exceeds the maximum limit
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Die Anzahl der zu generierenden Namen darf maximal 100 sein.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Die Anzahl der zu generierenden Namen darf maximal 100 sein.");
				return;
			}

			// Validate the number of names to generate
			if (kryptonNumericUpDownSetSyllablesNumberNames.Value < kryptonNumericUpDownSetSyllablesNumberNames.Minimum)
			{
				// Show an error message if the number of names is below the minimum limit
				// This will display an error message box and update the status bar with the error message
				_ = MessageBox.Show(text: "Die Anzahl der zu generierenden Namen muss mindestens 1 sein.", caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				SetStatusBar(text: "Die Anzahl der zu generierenden Namen muss mindestens 1 sein.");
				return;
			}

			// Check if the syllable sets are defined
			for (int i = 0; i < kryptonNumericUpDownSetSyllablesNumberNames.Value; i++)
			{
				// Generate a syllable-based name and append it to the results textbox
				kryptonTextBoxSyllablesResults.Text = string.IsNullOrWhiteSpace(value: kryptonTextBoxSyllablesResults.Text)
					? $"{quote}{GenerateSyllablesName()}{quote}"
					: $"{kryptonTextBoxSyllablesResults.Text}{separator}{newLine}{quote}{GenerateSyllablesName()}{quote}";
				kryptonTextBoxSyllablesResults.SelectionStart = kryptonTextBoxSyllablesResults.Text.Length;
				kryptonTextBoxSyllablesResults.ScrollToCaret();
			}

			// Re-enable the button after generation is complete
			kryptonButtonStartSyllablesOutput.Enabled = true;
		}

		#endregion

		private void KryptonButtonLetterTable_Click(object sender, EventArgs e)
		{
			using EsseDuForm letterTable = new();
			_ = letterTable.ShowDialog();
		}
	}
}
