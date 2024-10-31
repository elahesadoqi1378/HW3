Console.WriteLine("Enter numbers separated by comma:");
string input = Console.ReadLine();
string[] numbers = input.Split(',');
string result = "";
int count = 1;

for (int i = 0; i < numbers.Length; i++)
{
    if (i < numbers.Length - 1 && numbers[i] == numbers[i + 1])
    {
        count++;
    }
    else
    {
        if (count > 1)
        {
            result += $"{numbers[i]}^{count}*";
        }
        else
        {
            result += $"{numbers[i]}*";
        }
        count = 1;
    }
}

result = result.TrimEnd('*');
Console.WriteLine("result is:" + result);
