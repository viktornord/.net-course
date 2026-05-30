using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;

namespace Task5App;

partial class Form1
{
    private Button button_sbyte = null!;
    private Button button_byte = null!;
    private Button button_short = null!;
    private Button button_ushort = null!;
    private Button button_int = null!;
    private Button button_uint = null!;
    private Button button_long = null!;
    private Button button_ulong = null!;

    private void InitializeComponent()
    {
        Title = "Task 5 — Integral types";
        Width = 360;
        Height = 320;
        Padding = new Thickness(16);

        button_sbyte = CreateTypeButton("sbyte", button_sbyte_Click);
        button_byte = CreateTypeButton("byte", button_byte_Click);
        button_short = CreateTypeButton("short", button_short_Click);
        button_ushort = CreateTypeButton("ushort", button_ushort_Click);
        button_int = CreateTypeButton("int", button_int_Click);
        button_uint = CreateTypeButton("uint", button_uint_Click);
        button_long = CreateTypeButton("long", button_long_Click);
        button_ulong = CreateTypeButton("ulong", button_ulong_Click);

        Content = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star),
            },
            RowDefinitions =
            {
                new RowDefinition(GridLength.Star),
                new RowDefinition(GridLength.Star),
                new RowDefinition(GridLength.Star),
                new RowDefinition(GridLength.Star),
            },
            Children =
            {
                Place(button_sbyte, 0, 0),
                Place(button_byte, 1, 0),
                Place(button_short, 0, 1),
                Place(button_ushort, 1, 1),
                Place(button_int, 0, 2),
                Place(button_uint, 1, 2),
                Place(button_long, 0, 3),
                Place(button_ulong, 1, 3),
            },
        };
    }

    private static Button CreateTypeButton(string typeName, EventHandler<Avalonia.Interactivity.RoutedEventArgs> onClick)
    {
        var button = new Button
        {
            Content = typeName,
            Margin = new Thickness(4),
            HorizontalAlignment = HorizontalAlignment.Stretch,
            VerticalAlignment = VerticalAlignment.Stretch,
        };
        button.Click += onClick;
        return button;
    }

    private static Control Place(Control control, int column, int row)
    {
        Grid.SetColumn(control, column);
        Grid.SetRow(control, row);
        return control;
    }
}
