namespace even_fibonacci_numbers
{
    class even_fibonacci_numbers
    {
        static void Main(string[] args)
        {
            //Calculate the sum of even fibonacci terms below 4000000

            //Define an integer list named fib
            List<int>fib = new List<int>();

            //Set first two elements as fib[0] = 1 and fib[1] = 2
            fib.Add(1);
            fib.Add(2);

            //Set appropriate loop variable
            int i = 2;

            //#Initialize sum as 0
            int sum = 0;

            while (true)
            {

                //Calculate the next element according to the Fibonacci sequence formula
                int next = fib[i - 1] + fib[i - 2];

                //Check the next element is smaller than 4000000
                if (next < 4000000)
                {

                    //If smaller, then add the next element to the array
                    fib.Add(next);
                    i++;
                }
                else
                {

                    //If not smaller, end the loop
                    break;
                }
            }
            for (int element = 0; element < fib.Count; element++)
            {

                //Check if the ith element of fib is even
                if (fib[element] % 2 == 0)
                {

                    //If even, add it to the sum
                    sum += fib[element];
                }
            }

            //Print the sum
            Console.WriteLine(sum);
        }
    }
}
