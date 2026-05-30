namespace Task2;

public class Converter
{
    private readonly double _usdRate;
    private readonly double _eurRate;
    private readonly double _gbpRate;

    public Converter(double usd, double eur, double gbp)
    {
        _usdRate = usd;
        _eurRate = eur;
        _gbpRate = gbp;
    }

    public double ToUsd(double uah) => uah / _usdRate;

    public double ToEur(double uah) => uah / _eurRate;

    public double ToGbp(double uah) => uah / _gbpRate;

    public double FromUsd(double usd) => usd * _usdRate;

    public double FromEur(double eur) => eur * _eurRate;

    public double FromGbp(double gbp) => gbp * _gbpRate;
}
