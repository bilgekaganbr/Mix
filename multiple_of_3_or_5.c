#include <stdio.h>
#include <cs50.h>

int main(void)
{
    //Find the sum of all the multiples of 3 or 5 below 1000

    //Initialize the sum from 0
    int sum = 0;

    //The for loop for numbers between 1 and 1000
    for (int i = 0; i < 1000; i++)
    {
        //Check if the ith number is divisible by 3 or 5
        if (i % 3 == 0 || i % 5 == 0)
        {
            //If divisible, add number to the sum
            sum += i;
        }
    }
    //Print the final sum
    printf("%i\n", sum);
}