float s, a, pa;
do
{
    Console.WriteLine("Digite o salario normal: ");
    s = float.Parse(Console.ReadLine());
} while (s <= 0);

do
{
    Console.WriteLine("Digite o salario com aumento: ");
    a = float.Parse(Console.ReadLine());
} while (a <= 0 || a <= s);

pa = a - s;
pa = pa / s;
pa = pa * 100;
Console.WriteLine($"O salario anterior era de R${s} e depois de um aumento de {pa}% foi para R${a}");


