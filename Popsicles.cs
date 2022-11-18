namespace Popsicles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*We have certain amount of popsicles and a group of brothers 
            and sisters. If we can, we will give them equally among the 
            siblings. Else, we will them ourselves.*/

            //Get number of popsicles and siblings
            int popsicles = Convert.ToInt32(Console.ReadLine());
            int siblings = Convert.ToInt32(Console.ReadLine());

            /*Check if we can distribute popsicles equally and print the 
            result*/
            if (popsicles % siblings == 0)
            {
                Console.WriteLine("Give away");
            }
            else
            {
                Console.WriteLine("Eat them yourself");
            }

        }
    }
}

