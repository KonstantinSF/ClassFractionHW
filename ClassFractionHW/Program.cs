// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Fraction Sample = new(1,2,0);
Sample.print();
//Fraction Sample1 = Sample with { integer = Sample.set_integer(5)}; 

Fraction Sample1 = new Fraction();
Sample1.set_integer(5); Sample1.set_numerator(5);Sample1.set_denominator(5);
Sample1.print();

int sample1 = (int)Sample1;Console.WriteLine(sample1);

//double num1 = 0.23434;
//num1=(int)num1; 
//string num2 = ""; 
//num2=num1.ToString(); 
//Console.WriteLine(num2);

class Fraction
{
    int integer = 0;
    int numerator = 0;
    int denominator = 0;

    public int get_integer() //public int get_integer() => this.integer; 
    {
        return this.integer;
    }
    public int get_numerator()=>this.numerator;
    public int get_denominator()=>this.denominator;
    public void set_integer (int integer) => this.integer = integer;
    public void set_numerator(int nominator) => this.numerator = numerator;
    public void set_denominator(int denominator)
    {
        if (denominator == 0) this.denominator = 1; 
        else this.denominator = denominator;
    }    
    public Fraction (int integer=0, int numerator = 0, int denominator =1)//constructor
    {
        this.integer = integer; this.numerator = numerator;
        set_denominator(denominator); 
    }
    public Fraction (double number)
    {
        integer = (int) number;  //Сохраняем целую часть
        
    }
    public void print()
    {
        Console.WriteLine($"{integer} {numerator}/{denominator}");
    }
    public static explicit operator int (Fraction fraction)
    {
        return fraction.integer + fraction.numerator / fraction.denominator; 
    }
}