double TriangleSquare(double x1, double y1, double x2, double y2, double x3, double y3){
    double square= ((x2-x1)*(y3-y1)-(x3-x1)*(y2-y1))/2;
    if(square<0)
        return square*(-1);
    return square;
}

Console.Clear();

Console.Write("Введите x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x3: ");
double x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y3: ");
double y3 = Convert.ToInt32(Console.ReadLine());

double result=TriangleSquare(x1,y1,x2,y2,x3,y3);

Console.Write($"Triangle's square is: {result}");