#include <stdio.h>

int main(void)
{
    //Define a integer list with a proper size
    int fib[100];

    //Set first two elements as fib[0] = 1 and fib[1] = 2
    fib[0] = 1;
    fib[1] = 2;

    //Set appropriate loop variable
    int i = 2;

    //Initialize sum as 0
    int sum = 0;

    while (1)
    {

        //Calculate the next element according to the Fibonacci sequence formula
        int next = fib[i - 1] + fib[i - 2];

        //Check the next element is smaller than 4000000
        if (next < 4000000)
        {

            //If smaller, then add the next element to the list
            fib[i] = next;
            i++;
        }
        else
        {

            //If not smaller, end the loop
            break;
        }
    }
    for(int element = 0; element < sizeof(fib) / sizeof(fib[0]); element++)
    {

        //Check if the ith element of fib is even
        if (fib[element] % 2 == 0)
        {

            //If even, add it to the sum
            sum += fib[element];
        }
    }

    //Print the sum
    printf("%i\n", sum);

}