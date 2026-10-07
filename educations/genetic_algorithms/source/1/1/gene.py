# Step 1
genSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!?. "
target = "Hello World!"


# Step 2
import random

def generate_parent(lenght):
    genes = []
    while len(genes) < lenght:
        sampleSize = min(lenght - len(genes), len(genSet))
        genes.extend(random.sample(genSet, sampleSize))
    return ''.join(genes)


# Step 3
def get_fitness(guess):
    return sum(1 for expected, actual in zip(target, guess) if expected == actual)


# Step 4
def mutate(parent):
    index = random.randrange(0, len(parent))
    childGenes = list(parent)
    newGene, alternate = random.sample(genSet, 2)
    childGenes[index] = alternate \
        if newGene == childGenes[index] \
        else newGene
    return ''.join(childGenes)


# Step 5
import datetime

def display(guess):
    timeD = datetime.datetime.now() - startTime
    fitness = get_fitness(guess)
    print("{0}\t{1}\t{2}".format(guess, fitness, str(timeD)))


# Step 6
random.seed()
startTime = datetime.datetime.now()
bestParent = generate_parent(len(target))
bestFitness = get_fitness(bestParent)
display(bestParent)


# Step 7
while(True):
    child = mutate(bestParent)
    childFitness = get_fitness(child)
    if bestFitness >= childFitness:
        continue
    display(child)
    if childFitness >= len(bestParent):
        break
    bestFitness = childFitness
    bestParent = child