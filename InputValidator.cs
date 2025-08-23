using System.Text.RegularExpressions;

/* Example usage:
 * 
 * TextBox1 → ALL Unicode letters (including umlauts)
 * Note: This method allows letters in different languages, including accents and special characters.
 * Examples: "A", "ä", "ß", "é", "ç", "Я", "α", "أ".
 * InputValidator.AllowOnlyLetters(textBox1);
 * 
 * TextBox2 → Unicode letters + spaces
 * Note: This method allows letters in different languages, including accents and special characters.
 * InputValidator.AllowOnlyLettersWithSpaces(textBox2);
 * 
 * TextBox3 → Custom pattern (e.g. only Cyrillic characters)
 * Note: \p{IsCyrillic} is a Unicode class that includes Cyrillic characters.
 * InputValidator.AllowCustomRegex(textBox3, @"^[\p{IsCyrillic}]$");
 * 
 * TextBox4 → Custom pattern (e.g. only Chinese characters)
 * Note: \p{IsCJKUnifiedIdeographs} is a Unicode class that includes Chinese characters.
 * InputValidator.AllowCustomRegex(textBox4, @"^[\p{IsCJKUnifiedIdeographs}]$");
 */

namespace Narthalas
{
	/// <summary>
	/// Provides static helper methods to restrict and validate user input in <see cref="TextBox"/> controls.
	/// Supports filtering for Unicode letters, letters with spaces, and custom regular expression patterns.
	/// </summary>
	internal class InputValidator
	{
		/// <summary>
		/// Allows all Unicode letters (A-Z, umlauts, accents, Cyrillic, Greek, Arabic, etc.).
		/// No spaces.
		/// </summary>
		public static void AllowOnlyLetters(TextBox textBox)
		{
			textBox.KeyPress -= TextBox_AllowOnlyLetters;
			textBox.KeyPress += TextBox_AllowOnlyLetters;
		}

		/// <summary>
		/// Allows all Unicode letters + spaces.
		/// </summary>
		public static void AllowOnlyLettersWithSpaces(TextBox textBox)
		{
			textBox.KeyPress -= TextBox_AllowOnlyLettersWithSpaces;
			textBox.KeyPress += TextBox_AllowOnlyLettersWithSpaces;
		}

		/// <summary>
		/// Allows any input using a custom regex pattern.
		/// </summary>
		public static void AllowCustomRegex(TextBox textBox, string pattern)
		{
			// Remove any old handlers if multiple filters have been assigned to the TextBox
			textBox.KeyPress -= CustomRegexHandlerWrapper;
			textBox.KeyPress += CustomRegexHandlerWrapper;

			// Define a local function to handle the KeyPress event with the provided pattern
			// This allows the use of the pattern variable within the event handler
			// without needing to capture it in a lambda or closure.
			// This is necessary because the KeyPress event handler must match the delegate signature.
			// The pattern is passed as a parameter to the local function.
			// This way, we can use the same method for different patterns without creating multiple methods.
			// Note: The pattern should be a valid regex pattern that matches the desired input.
			// Example patterns:
			// - @"^[\p{IsCyrillic}]+$" for Cyrillic characters
			// - @"^[\p{IsCJKUnifiedIdeographs}]+$" for Chinese characters
			// - @"^[a-zA-Z0-9]+$" for alphanumeric characters
			// - @"^[\p{L}]+$" for all Unicode letters (including umlauts, accents, etc.)
			// - @"^[\p{L}\s]+$" for all Unicode letters + spaces
			void CustomRegexHandlerWrapper(object? sender, KeyPressEventArgs e) => CustomRegexHandler(sender: sender!, e: e, pattern: pattern);
		}

		/// <summary>
		/// Handles the KeyPress event to allow only Unicode letter characters (no spaces).
		/// Suppresses any non-letter and non-control key input.
		/// </summary>
		/// <param name="sender">The source of the event, typically a <see cref="TextBox"/>.</param>
		/// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
		private static void TextBox_AllowOnlyLetters(object? sender, KeyPressEventArgs e)
		{
			// Check if the key pressed is a control key (like Backspace, Enter, etc.)
			if (char.IsControl(c: e.KeyChar))
			{
				return;
			}
			// Check if the key pressed is a letter
			if (!char.IsLetter(c: e.KeyChar))
			{
				e.Handled = true;
			}
		}

		/// <summary>
		/// Handles the KeyPress event to allow only Unicode letter characters and spaces.
		/// Suppresses any input that is not a letter, space, or control key.
		/// </summary>
		/// <param name="sender">The source of the event, typically a <see cref="TextBox"/>.</param>
		/// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
		private static void TextBox_AllowOnlyLettersWithSpaces(object? sender, KeyPressEventArgs e)
		{
			// Check if the key pressed is a control key (like Backspace, Enter, etc.)
			if (char.IsControl(c: e.KeyChar))
			{
				return;
			}

			// Check if the key pressed is a letter or a whitespace character
			if (!(char.IsLetter(c: e.KeyChar) || char.IsWhiteSpace(c: e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		/// <summary>
		/// Handles the KeyPress event to allow input matching a custom regular expression pattern.
		/// Suppresses any input that does not match the provided regex pattern, except control keys.
		/// </summary>
		/// <param name="sender">The source of the event, typically a <see cref="TextBox"/>.</param>
		/// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
		/// <param name="pattern">The regular expression pattern to validate input against.</param>
		private static void CustomRegexHandler(object? sender, KeyPressEventArgs e, string pattern)
		{
			// Check if the sender is a TextBox
			if (char.IsControl(c: e.KeyChar))
			{
				return;
			}

			// Check if the key pressed matches the custom regex pattern
			if (!Regex.IsMatch(input: e.KeyChar.ToString(), pattern: pattern))
			{
				e.Handled = true;
			}
		}
	}
}