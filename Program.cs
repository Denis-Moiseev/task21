double ShowDistanceTwoPoints3D(int xa, int ya, int za, int xb, int yb, int zb)
{
    double AB = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    return AB;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int xa = GetInput("Введите координату - xa: ");
int ya = GetInput("Введите координату - ya: ");
int za = GetInput("Введите координату - za: ");
int xb = GetInput("Введите координату - xb: ");
int yb = GetInput("Введите координату - yb: ");
int zb = GetInput("Введите координату - zb: ");
Console.Write($"Расстояние между точками {ShowDistanceTwoPoints3D(xa, ya, za, xb, yb, zb)}");