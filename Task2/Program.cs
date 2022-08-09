// // int[] array = new Random().Next(0, 3);
// // Console.Write(array[0] + array[2]);

// Console.WriteLine("Введите первое число");
// int numA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numB = int.Parse(Console.ReadLine());

// if(numB == 0)
// {
//     Console.WriteLine("На ноль делить нельзя");
// }
// else if(numA % numB == 0)
// {
//     Console.WriteLine("Да, кратно");
// }
// else
// {
// Console.WriteLine("Нет, не кратно. Остаток от деления " + numA % numB);
// }


// Console.WriteLine("Введите трехзначное число");


int num = new Random().Next(100, 1000);
string str = num.ToString();
// array1[0] = new Random().Next(0, 9);
// array1[1] = new Random().Next(0, 9);
// array1[2] = new Random().Next(0, 9);
Console.WriteLine("Сгенерированное число " + num);
Console.Write(str[0]);
Console.WriteLine(str[2]);
// int num = new Random().Next(100, 1000);
// Console.WriteLine("Число сгенерировано " + num);
// Console.WriteLine(array[0] + array[2]);
