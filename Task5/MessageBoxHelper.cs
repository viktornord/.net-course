using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

namespace Task5App;

/// <summary>Cross-platform stand-in for System.Windows.Forms.MessageBox.Show.</summary>
internal static class MessageBoxHelper
{
    public static async Task ShowAsync(Window owner, string message, string title = "Information")
    {
        owner.Activate();
        owner.BringIntoView();

        var messageBlock = new TextBlock
        {
            Text = message,
            TextWrapping = TextWrapping.Wrap,
            MaxWidth = 420,
        };

        var okButton = new Button
        {
            Content = "OK",
            HorizontalAlignment = HorizontalAlignment.Center,
            MinWidth = 80,
            IsDefault = true,
        };

        var panel = new StackPanel
        {
            Margin = new Thickness(20),
            Spacing = 16,
            Children = { messageBlock, okButton },
        };

        var dialog = new Window
        {
            Title = title,
            Content = panel,
            SizeToContent = SizeToContent.WidthAndHeight,
            WindowStartupLocation = WindowStartupLocation.CenterOwner,
            CanResize = false,
            Topmost = true,
            ShowInTaskbar = false,
            ShowActivated = true,
        };

        okButton.Click += (_, _) => dialog.Close();

        dialog.Opened += (_, _) =>
        {
            dialog.Activate();
            dialog.Topmost = true;
            okButton.Focus();
        };

        try
        {
            await dialog.ShowDialog(owner);
        }
        finally
        {
            owner.Activate();
        }
    }
}
