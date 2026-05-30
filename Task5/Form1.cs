using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Task5App;

/// <summary>
/// Cross-platform equivalent of Windows Forms Task 5 (Mac, Windows, Linux).
/// Eight buttons — one per integral type — show each type's valid value range.
/// </summary>
public partial class Form1 : Window
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void button_sbyte_Click(object? sender, RoutedEventArgs e) =>
        await ShowRange("sbyte", sbyte.MinValue, sbyte.MaxValue);

    private async void button_byte_Click(object? sender, RoutedEventArgs e) =>
        await ShowRange("byte", byte.MinValue, byte.MaxValue);

    private async void button_short_Click(object? sender, RoutedEventArgs e) =>
        await ShowRange("short", short.MinValue, short.MaxValue);

    private async void button_ushort_Click(object? sender, RoutedEventArgs e) =>
        await ShowRange("ushort", ushort.MinValue, ushort.MaxValue);

    private async void button_int_Click(object? sender, RoutedEventArgs e) =>
        await ShowRange("int", int.MinValue, int.MaxValue);

    private async void button_uint_Click(object? sender, RoutedEventArgs e) =>
        await ShowRange("uint", uint.MinValue, uint.MaxValue);

    private async void button_long_Click(object? sender, RoutedEventArgs e) =>
        await ShowRange("long", long.MinValue, long.MaxValue);

    private async void button_ulong_Click(object? sender, RoutedEventArgs e) =>
        await ShowRange("ulong", ulong.MinValue, ulong.MaxValue);

    private Task ShowRange<T>(string typeName, T min, T max) where T : struct =>
        MessageBoxHelper.ShowAsync(
            this,
            $"{typeName}: valid range is {min} to {max}");
}
