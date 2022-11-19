#Calculate the sum of even fibonacci terms below 4000000

#Define an empty list
fib = []

#Set first two elements as fib[0] = 1 and fib[1] = 2
fib.append(1)
fib.append(2)

#Set appropriate loop variable
i = 2

#Initialize sum as 0
sum = 0

while True:

    #Calculate the next element according to the Fibonacci sequence formula
    next = fib[i - 1] + fib[i - 2]

    #Check the next element is smaller than 4000000
    if next < 4000000:

        #If smaller, then add the next element to the list
        fib.append(next)
        i += 1

    else:

        #If not smaller, end the loop
        break

for i in fib:

    #Check if the ith element of fib is even
    if i % 2 == 0:

        #If even, add it to the sum
        sum += i

#Print the sum
print(sum)