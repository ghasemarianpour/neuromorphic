import random


# Guess Generate
def _generate_parent(lenght, genSet):
    genes = []
    while len(genes) < lenght:
        sampleSize = min(lenght - len(genes), len(genSet))
        genes.extend(random.sample(genSet, sampleSize))
    return ''.join(genes)


# Mutate
def _mutate(parent, genSet):
    index = random.randrange(0 , len(parent))
    childGenes = list(parent)
    newGene, alternate = random.sample(genSet, 2)
    childGenes[index] = alternate \
        if newGene == childGenes[index] \
        else newGene
    return ''.join(childGenes)


# Best
def getBest(get_fitness, targetLen, optimalFitness, genSet, display):
    random.seed()
    bestParent = _generate_parent(targetLen, genSet)
    bestFitness = get_fitness(bestParent)
    display(bestParent)

    if bestFitness >= optimalFitness:
        return bestParent

    while(True):
        child = _mutate(bestParent, genSet)
        childFitness = get_fitness(child)
        if bestFitness >= childFitness:
            continue
        display(child)
        if childFitness >= optimalFitness:
            return child
        bestFitness = childFitness
        bestParent = child