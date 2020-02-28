import random, re, sys

def generateUsers(usersToGenerate):
    firstNames = []
    with open("fornavne.csv","r") as f:
        lines = f.readlines()
        for line in lines:
            firstNames.append(line.replace("\n",""))


    lastNames = []
    with open("efternavne.txt","rb") as f:
        names = f.read().decode("utf-8")
        lastNames = re.findall("[A-ZÆØÅ][^A-ZÆØÅ]*", names)


    illegalCharacters = ["æ","ø","å","Æ","Ø","Å","ü"]
    ids = [i for i in range(usersToGenerate)]
    firstNames = [name for name in firstNames if not any(n in name for n in illegalCharacters)]
    lastNames = [name for name in lastNames if not any(n in name for n in illegalCharacters)]

    with open("TextFile1.txt", "w") as f:
        for i in range(usersToGenerate):
            user = str(random.choice(ids))+";" + random.choice(firstNames) + " "+ random.choice(lastNames) +";" + str(random.randrange(18,75)) + ";" + str(random.randrange(0,200))
            f.write(user+"\n")

if __name__ == '__main__':
    try:
        generateUsers(int(sys.argv[1]))
    except:
        generateUsers(1000)

