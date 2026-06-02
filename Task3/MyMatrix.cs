namespace Task3;

public class MyMatrix
{
    private int[,] _data;

    public MyMatrix(int rows, int columns)
    {
        if (rows <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(rows), "Rows must be greater than zero.");
        }

        if (columns <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(columns), "Columns must be greater than zero.");
        }

        _data = new int[rows, columns];
    }

    public int Rows
    {
        get => _data.GetLength(0);
        set => Resize(value, Columns);
    }

    public int Columns
    {
        get => _data.GetLength(1);
        set => Resize(Rows, value);
    }

    public int this[int row, int column]
    {
        get => _data[row, column];
        set => _data[row, column] = value;
    }

    public override string ToString()
    {
        var lines = new List<string>();

        for (var i = 0; i < Rows; i++)
        {
            var rowValues = new string[Columns];
            for (var j = 0; j < Columns; j++)
            {
                rowValues[j] = _data[i, j].ToString();
            }

            lines.Add(string.Join("\t", rowValues));
        }

        return string.Join(Environment.NewLine, lines);
    }

    private void Resize(int newRows, int newColumns)
    {
        if (newRows <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(newRows), "Rows must be greater than zero.");
        }

        if (newColumns <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(newColumns), "Columns must be greater than zero.");
        }

        var resized = new int[newRows, newColumns];
        var rowsToCopy = Math.Min(Rows, newRows);
        var columnsToCopy = Math.Min(Columns, newColumns);

        for (var i = 0; i < rowsToCopy; i++)
        {
            for (var j = 0; j < columnsToCopy; j++)
            {
                resized[i, j] = _data[i, j];
            }
        }

        _data = resized;
    }
}
