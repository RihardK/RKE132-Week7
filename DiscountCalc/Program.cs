
Console.WriteLine("Provide price total:");
int userIn = Int32.Parse(Console.ReadLine());

double discount = CalcDisc(userIn);

Console.WriteLine($"Discount is : {discount}%");

double newTotal = CalcNewTotal(userIn, discount);

Console.WriteLine($"New sum to pay with {discount}% discount: {newTotal}");
static double CalcDisc(int total)
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }
    else 
    {
        return 10;
    }
}
static double CalcNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;

}