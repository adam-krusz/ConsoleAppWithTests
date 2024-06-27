List<int> primes = new List<int>();
for (int i = 0; i < 100; i++)
{
    if (Primes.IsPrime(i))
    {
        primes.Add(i);
    }
}

Console.WriteLine($"Found {primes.Count} primes.");
//display primes
for (int i = 0; i < primes.Count; i++)
{
    Console.Write(primes[i] + " ");
    if ((i + 1) % 3 == 0)
    {
        Console.WriteLine();
    }
}

// function checking if number is prime
static class Primes
{
    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}


