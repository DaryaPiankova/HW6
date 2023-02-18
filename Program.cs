void CountResult(double k1, double b1, double k2, double b2){
    double x=(b2-b1)/(k1-k2);
    double y= k1*x+b1;
    Console.Write($"({x};{y})");
}

Console.Clear();
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

CountResult(k1,b1,k2,b2);


