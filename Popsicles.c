#include <stdio.h>
#include <cs50.h>

/*We have certain amount of popsicles and a group of brothers
and sisters. If we can, we will give them equally among the
siblings. Else, we will them ourselves.*/

int main(void)
{

    //Get number of popsicles and siblings

    int popsicles = get_int("Popsicles: ");
    int siblings = get_int("Siblings: ");

    //Check if we can distribute popsicles equally and print the result

    if (popsicles % siblings == 0)
    {
        printf("Give away\n");
    }
    else
    {
        printf("Eat them yourself\n");
    }

}