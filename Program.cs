int countElem(int [] elem){
    int counter=0;
    for(int i=0; i<elem.Length; i++){
        if(elem[i]>0){
            counter++;
        }
    }
    return counter;
}

void PrintArr(int [] arr){
        Console.WriteLine($"Введенный массив: [{string.Join(", ", arr)}]");    
}

Console.Clear();
Console.Write("Введите числа: ");
int[] elements = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
PrintArr(elements);
Console.Write($"Результат: {countElem(elements)}");


