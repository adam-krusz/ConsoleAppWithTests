
//
List<int> primes = new List<int>();

for (int i = 0; i < 100; i++)
{
    if (Primes.IsPrime(i))
    {
        primes.Add(i);
    }
}

// print primes, three numbers in one row
for (int i = 0; i < primes.Count; i += 3)
{
    Console.WriteLine($"{primes[i]} {primes[i + 1]} {primes[i + 2]}");
}

// function checking if number is prime
public static class Primes
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

pub


