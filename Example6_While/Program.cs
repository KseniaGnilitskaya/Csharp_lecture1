int a = 8;
int b = 4;
int c = 9;
int d = 2;
int e = 1;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Максимальное число: ");
Console.Write(max);
