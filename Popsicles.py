"""We have certain amount of popsicles and a group of brothers
and sisters. If we can, we will give them equally among the
siblings. Else, we will them ourselves."""

#Get number of popsicles and siblings

popsicles = int(input("Popsicles: "))
siblings = int(input("Siblings: "))

#Check if we can distribute popsicles equally and print the result

if popsicles % siblings == 0:

    print("Give away")

else:

    print("Eat them yourself")