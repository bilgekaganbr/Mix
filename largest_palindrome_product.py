#Program that calculate the largest palindrome made from the product of two 3-digit numbers

#Define max_palindrome
max_palindrome = 1

for i in range(100,1000):

    for j in range(100,1000):

        #Calculate the product
        product = i * j

        #Convert int product to string
        str_product = str(product)

        #Check if str_product and its reverse is equal
        if str_product == str_product[::-1]:

            #If equal, then check if product is greater than max_palindrome
            if product > max_palindrome:

                #If greater, set product as new max_palindrome
                max_palindrome = product

#Print max_palindrome
print(max_palindrome)

