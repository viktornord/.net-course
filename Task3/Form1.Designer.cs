using Avalonia;
using Avalonia.Controls;

namespace Task3;

partial class Form1
{
    private TextBox textBox1 = null!;
    private TextBox textBox2 = null!;
    private Button button1 = null!;

    private void InitializeComponent()
    {
        Title = "Task 3";
        Width = 400;
        Height = 220;
        Padding = new Thickness(16);

        textBox1 = new TextBox
        {
            Watermark = "Enter text here",
            Margin = new Thickness(0, 0, 0, 8),
        };

        button1 = new Button
        {
            Content = "Copy to textBox2",
            Margin = new Thickness(0, 0, 0, 8),
        };
        button1.Click += button_Click;

        textBox2 = new TextBox
        {
            Watermark = "Output appears here",
            IsReadOnly = true,
        };

        Content = new StackPanel
        {
            Children = { textBox1, button1, textBox2 },
        };
    }
}
