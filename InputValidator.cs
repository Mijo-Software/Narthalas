using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Narthalas
{
    internal class InputValidator
    {
        /// <summary>
        /// Erlaubt alle Unicode-Buchstaben (A-Z, Umlaute, Akzente, kyrillisch, griechisch, arabisch etc.).
        /// Keine Leerzeichen.
        /// </summary>
        public static void AllowOnlyLetters(TextBox textBox)
        {
            textBox.KeyPress -= TextBox_AllowOnlyLetters;
            textBox.KeyPress += TextBox_AllowOnlyLetters;
        }

        /// <summary>
        /// Erlaubt alle Unicode-Buchstaben + Leerzeichen.
        /// </summary>
        public static void AllowOnlyLettersWithSpaces(TextBox textBox)
        {
            textBox.KeyPress -= TextBox_AllowOnlyLettersWithSpaces;
            textBox.KeyPress += TextBox_AllowOnlyLettersWithSpaces;
        }

        /// <summary>
        /// Erlaubt beliebige Eingaben anhand eines Custom-Regex-Musters.
        /// </summary>
        public static void AllowCustomRegex(TextBox textBox, string pattern)
        {
            // Entferne eventuelle alte Handler, falls der TextBox mehrere Filter zugewiesen wurden
            textBox.KeyPress -= CustomRegexHandlerWrapper;
            textBox.KeyPress += CustomRegexHandlerWrapper;

            void CustomRegexHandlerWrapper(object? sender, KeyPressEventArgs e) => CustomRegexHandler(sender: sender!, e: e, pattern: pattern);
        }

        // Ändere die Signatur der Eventhandler-Methoden, um die Nullable-Annotationen zu berücksichtigen
        private static void TextBox_AllowOnlyLetters(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(c: e.KeyChar))
                return;

            if (!char.IsLetter(c: e.KeyChar))
                e.Handled = true;
        }

        // Eventhandler: Buchstaben + Leerzeichen
        private static void TextBox_AllowOnlyLettersWithSpaces(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(c: e.KeyChar))
                return;

            if (!(char.IsLetter(c: e.KeyChar) || char.IsWhiteSpace(c: e.KeyChar)))
                e.Handled = true;
        }

        // Eventhandler: Regex-basiert
        private static void CustomRegexHandler(object? sender, KeyPressEventArgs e, string pattern)
        {
            if (char.IsControl(c: e.KeyChar))
                return;

            if (!Regex.IsMatch(input: e.KeyChar.ToString(), pattern: pattern))
                e.Handled = true;
        }
    }
}