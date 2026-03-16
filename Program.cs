// multiplication table

float number;
int quantity;

Console.WriteLine("Enter a number:  ");
number = float.Parse(Console.ReadLine());

Console.WriteLine("Enter the quantity:  ");
quantity = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantity; i++)
{
    float result = number * i;
    Console.WriteLine(number + " X " + i + " = " + result);
}