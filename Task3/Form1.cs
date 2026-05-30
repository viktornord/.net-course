using Avalonia.Controls;

namespace Task3;

/// <summary>
/// Cross-platform equivalent of a Windows Forms app (Mac, Windows, Linux).
/// </summary>
public partial class Form1 : Window
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        textBox2.Text = textBox1.Text;
    }
}
