int[] numbers = new int[4];
int maior, menor;

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite um numero: ");
    numbers[i] = int.Parse(Console.ReadLine());
}
maior = numbers.Max();
menor = numbers.Min();
Console.Write("Maior número digitado: {0}\n" +
    "Menor número digitado: {1}", maior, menor);