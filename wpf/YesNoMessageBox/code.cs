/// <summary>
/// Shows a YES/NO MessageBox with a custom message and caption.
/// Returns true if the user clicks Yes, otherwise returns false.
/// </summary>
/// <param name="message">The message to display in the MessageBox.</param>
/// <param name="caption">The caption of the MessageBox.</param>
/// <returns>True if the user clicks Yes, otherwise false.</returns>
public static bool ShowYESNOMessageBox(string message, string caption)
{
    MessageBoxButton button = MessageBoxButton.YesNo;
    MessageBoxResult result = MessageBox.Show(message, caption, button);

    return result == MessageBoxResult.Yes;
}
