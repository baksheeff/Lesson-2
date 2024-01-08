using System;
public class Answer {
    
static void Multiplicity(){
    Console.WriteLine("введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 7 == 0 && num % 23 == 0){
        Console.WriteLine($"Число {num} одновременно кратно 7 и 23");
    } else {
    Console.WriteLine($"Число {num} не кратно 7 и(или) не кратно 23");
    }
    Console.WriteLine("__________________________________________________________________________________________________________");
}
static void Coordinates(){
    Console.WriteLine("введите координату Х: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите координату Y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    if (x == 0){
        Console.WriteLine("Точка находится на оси Х.");
    }
    if (y == 0){
        Console.WriteLine("Точка находится на оси Y.");
    }
    if (x > 0 && y > 0){
        Console.WriteLine("Точка находится в первой четверти.");
    }
    if (x < 0 && y > 0){
        Console.WriteLine("Точка находится во второй четверти.");
    }
    if (x > 0 && y < 0){
        Console.WriteLine("Точка находится в третьей четверти.");
    }
    if (x < 0 && y < 0){
        Console.WriteLine("Точка находится в четвертой четверти.");
    }
    Console.WriteLine("__________________________________________________________________________________________________________");
}

static void Max(){
    Console.WriteLine("введите число из отрезка [10,99]: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num >= 10 && num <= 99){
        int firstDigit = num/10;
        int secondDigit = num % 10;

        if (firstDigit == secondDigit){
            Console.WriteLine($"число {firstDigit} равно {secondDigit}");
        }

        if (firstDigit > secondDigit){
            Console.WriteLine($"первое цифра {firstDigit} числа {num} больше, чем вторая его цифра - {secondDigit}");
        } else{
            Console.WriteLine($"первое цифра {firstDigit} числа {num} меньше, чем вторая его цифра - {secondDigit}");
        }
    } else {
        Console.WriteLine($"число {num} не принадлежит отрезку [10,99]");
    }
    Console.WriteLine("__________________________________________________________________________________________________________");
}

static void DivideTheNumber(){
    Console.WriteLine("Введите натуральное число N:"); 

    int n = Convert.ToInt32(Console.ReadLine());
    List<int> digits = new();

    if (n <= 0 ){
        Console.WriteLine("Ваше число не натуральное!");
    }
    if (n < 10){
        Console.WriteLine(n);
    } else {
        while (n > 0){
            int currentDigit= n % 10;
            n /= 10;
            if (n >= 0){
                digits.Add(currentDigit);
            }
        }
        digits.Reverse();
        foreach(var i in digits){
            Console.Write(i);  
            if (i != digits[^1]){
                Console.Write(",");
            }  
        }
        Console.WriteLine();
    }
    Console.WriteLine("__________________________________________________________________________________________________________");
}

  static public void Main(string[] args) {
    int a;
    int[] numbers = {0,1,2,3,4};
    while (true){
        Console.WriteLine("Введите номер задачи:");
        Console.WriteLine("1 - проверить кратность 7 и 23 одновременно;");
        Console.WriteLine("2 - определить  номер координатной четверти;");
        Console.WriteLine("3 - определить  наибольшее число из отрезка [10,99];");
        Console.WriteLine("4 - разбить число на отдельные цифры;");
        Console.WriteLine("0 - выход.");

        a = Convert.ToInt32(Console.ReadLine());
        
        if (!numbers.Contains(a)){
            Console.WriteLine("Введите корректный номер задачи!");
        }
        
        if (a == 0){
            break;
        }
        
        switch (a){
            case 1:
                Multiplicity();
                break;
            case 2:
                Coordinates();
                break;
            case 3:
                Max();
                break;
            case 4:
                DivideTheNumber();
                break;
        }
    }
}
}