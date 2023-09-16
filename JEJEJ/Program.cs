double accumulator;
double initialNumber = 0;
double secondNumber = 1;
double thirdNumber = 2;
double sumNumbers;

int quantityTerms;

void calculateFibonacciModificated(int quantityTerms)
{
    Console.Write(initialNumber + " " + secondNumber + " " + thirdNumber + " ");
    sumNumbers = initialNumber + secondNumber + thirdNumber;
    for (int x = 3; x < quantityTerms; x++)
    {
        accumulator = initialNumber + secondNumber + thirdNumber;
        initialNumber = secondNumber;
        secondNumber = thirdNumber;
        thirdNumber = accumulator;

        sumNumbers += accumulator;

        Console.Write(accumulator + " ");
    }

    Console.WriteLine("\nThe sum of the numbers is: " + sumNumbers);
}

Console.Write("How many terms do you want: ");
quantityTerms = int.Parse(Console.ReadLine());

calculateFibonacciModificated(quantityTerms);