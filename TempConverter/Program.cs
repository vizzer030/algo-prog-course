double celsius = 34.2;
const int F = 32;
const double K = 273.15;
Console.WriteLine($"Температура по Фаренгейту: {celsius * 9/5 + F}");
Console.WriteLine($"Температура по Кельвину: {celsius + K}");
Console.WriteLine($"{celsius}°C = {celsius * 9 / 5 + F}°F = {(int)((celsius + K) * 100) / 100.0}K");