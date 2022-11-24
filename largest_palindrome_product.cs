namespace largest_palindrome_product
{
    class largest_palindrome_product
    {
        static void Main(string[] args)
        {
            //Program that calculate the largest palindrome made from the product of two 3-digit numbers

            //Define max_palindrome and product variables
            int max_palindrome = 1;
            int product = 1;

            for(int i = 100; i < 1000; i++)
            {
                for(int j = 100; j < 1000; j++)
                {

                    //Calculate the product
                    product = i * j;

                    //Convert int product to string
                    string str_product = product.ToString();

                    //Determine the length of str_product
                    int length = str_product.Length;

                    //Define an empty string
                    string reverse = String.Empty;

                    for(int element = length - 1; element > -1; element--)
                    {

                        //Find the reverse of str_product
                        reverse += str_product[element];
                    }
                    
                    //Check if str_product and its reverse is equal
                    if(String.Equals(str_product, reverse))
                    {

                        //If equal, then check if product is greater than max_palindrome
                        if(product > max_palindrome)
                        {

                            //If greater, set product as new max_palindrome
                            max_palindrome = product;
                        }
                    }
                }
            }

            //Print max_palindrome
            Console.WriteLine(max_palindrome);
        }
    }
}
