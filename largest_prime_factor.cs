namespace largest_prime_factor
{
    class largest_prime_factor
    {
        static void Main(string[] args)
        {
            //Calculate the largest prime factor of 600851475143

            
            long num = 600851475143;

            //Set appropriate loop variable
            int i = 2;

            //Keep looping until the number is 1
            while (num != 1)
            {

                //Check if i divides number
                if (num % i != 0)
                {

                    //If i does not divide the number, skip to the next i
                    i++;
                }
                else
                {

                    //If i does divide the number, divide num by i and set the result as a new num
                    num /= i;
                }
            }

            //Print the last i that divides the number
            Console.WriteLine(i);
        }
    }
}
