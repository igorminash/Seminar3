
//int [] mas = {3, 6, 8, 2, 1, -7};
int [] mas = {7, -5, 0, 1, -1, 9};

double distance = Math.Sqrt(Math.Pow(mas[0]-mas[3], 2) + Math.Pow(mas[1]-mas[4], 2) + Math.Pow(mas[2]-mas[5], 2));
Console.WriteLine($"{distance:f2}");

