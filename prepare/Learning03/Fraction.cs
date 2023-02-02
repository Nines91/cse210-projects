using System;

public class Fraction {

    private int _top = 0;
    private int _bottom = 0;

    public Fraction() {
        _top = 1;
        _bottom = 1;
        //Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
        //Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
        //Console.WriteLine($"{_top}/{_bottom}");
    }

    public string GetFractionString(){
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue(){
        double value = (double)_top / (double)_bottom;
        return value;

    }
}