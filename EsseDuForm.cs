namespace Narthalas
{
	/// <summary>
	/// Represents the form displaying the letter table in the Narthalas application.
	/// Provides helper methods for status bar management.
	/// </summary>
	public partial class EsseDuForm : Form
	{
		#region Fields and Properties

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="EsseDuForm"/> class.
		/// </summary>
		public EsseDuForm()
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

			// Check if the Control key is pressed along with the 'A' key
			if (e.Control && e.KeyCode == Keys.A)
			{
				// If the active control is a TextBox, select all text
				if (ActiveControl is TextBox textBox)
				{
					textBox.SelectAll();
					// Mark the event as handled to prevent further processing
					e.Handled = true;
				}
			}

			// Check if the Control key is pressed along with the 'C' key
			if (e.Control && e.KeyCode == Keys.C)
			{
				// If the active control is a TextBox, copy the selected text to the clipboard
				if (ActiveControl is TextBox textBox)
				{
					textBox.Copy();
					// Mark the event as handled to prevent further processing
					e.Handled = true;
				}
			}

			// Check if the Control key is pressed along with the 'V' key
			if (e.Control && e.KeyCode == Keys.V)
			{
				// If the active control is a TextBox, paste text from the clipboard
				if (ActiveControl is TextBox textBox)
				{
					textBox.Paste();
					// Mark the event as handled to prevent further processing
					e.Handled = true;
				}
			}

			// Check if the Control key is pressed along with the 'X' key
			if (e.Control && e.KeyCode == Keys.X)
			{
				// If the active control is a TextBox, cut the selected text to the clipboard
				if (ActiveControl is TextBox textBox)
				{
					textBox.Cut();
					// Mark the event as handled to prevent further processing
					e.Handled = true;
				}
			}

			// Check if the Control key is pressed along with the 'Z' key
			if (e.Control && e.KeyCode == Keys.Z)
			{
				// If the active control is a TextBox, undo the last action
				if (ActiveControl is TextBox textBox)
				{
					if (textBox.CanUndo)
					{
						textBox.Undo();
						// Mark the event as handled to prevent further processing
						e.Handled = true;
					}
				}
			}
		}

		#endregion

		#region Form Load event handler

		/// <summary>
		/// Handles the Load event of the <see cref="EsseDuForm"/>.
		/// Initializes the form state and clears the status bar when the form is loaded.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void EsseDuForm_Load(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the event arguments are null
			ArgumentNullException.ThrowIfNull(argument: e);

			ClearStatusBar();
		}

		#endregion
	}
}