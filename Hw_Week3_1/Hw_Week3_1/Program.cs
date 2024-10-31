using System.Globalization;

Console.WriteLine("Enter the numbers (0,1):");
string binarynum = Console.ReadLine();

int result = BinaryToDecimal(binarynum);
Console.WriteLine("The decimal number is:" + result);

static int BinaryToDecimal(string binarynum)
{
    int result = 0;
    int length = binarynum.Length;
    for (int i = 0; i < length; i++)
    {
        char currentchar = binarynum[length - 1 - i];
        if (currentchar == '1')
        {
            result += (int)Math.Pow(2, i);
        }
        else if (currentchar == '0')
        {

        }
        else
        {
            Console.WriteLine("the entered number is not true");
            break;
        }
    }
    return result;
}

