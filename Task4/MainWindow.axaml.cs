using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Task4;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonCalculate_Click(object? sender, RoutedEventArgs e)
    {
        if (radioButtonConcatenation.IsChecked == true)
        {
            textBox3.Text = textBox1.Text + textBox2.Text;
            return;
        }

        if (!double.TryParse(textBox1.Text, out double left) ||
            !double.TryParse(textBox2.Text, out double right))
        {
            textBox3.Text = "Enter valid numbers in textBox1 and textBox2.";
            return;
        }

        if (radioButtonRemainder.IsChecked == true)
        {
            if (right == 0)
            {
                textBox3.Text = "Cannot compute remainder: divisor is zero.";
                return;
            }

            textBox3.Text = (left % right).ToString();
            return;
        }

        if (radioButtonExponentiation.IsChecked == true)
        {
            textBox3.Text = Math.Pow(left, right).ToString();
            return;
        }

        if (radioButtonDivision.IsChecked == true)
        {
            if (right == 0)
            {
                textBox3.Text = "Cannot divide by zero.";
                return;
            }

            textBox3.Text = (left / right).ToString();
            return;
        }

        textBox3.Text = "Select an operation.";
    }
}
