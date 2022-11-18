#Find the sum of all the multiples of 3 or 5 below 1000

#Initialize the sum from 0
sum = 0

#The for loop for numbers between 1 and 1000
for i in range(1,1000):

    #Check if the ith number is divisible by 3 or 5
    if i % 3 == 0 or i % 5 == 0:

        #If divisible, add number to the sum
        sum += i

#Print the final sum
print(sum)
