import datetime
import genetic

def test_Hello_World():
    target = "Hello World!"
    guess_password(target)

def guess_password(target):
    genSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!?. "
    startTime = datetime.datetime.now()

    def fnGetFitness(genes):
        return get_fitness(genes, target)

    def fnDisplay(genes):
        display(genes, target, startTime)

    optimalFitness = len(target)
    genetic.getBest(fnGetFitness, len(target), optimalFitness, genSet, fnDisplay)

def display(genes, target, startTime):
    timeD = datetime.datetime.now() - startTime
    fitness = get_fitness(genes, target)
    print("{0}\t{1}\t{2}".format(genes, fitness, str(timeD)))

def get_fitness(genes, target):
    return sum(1 for expected, actual in zip(target, genes) if expected == actual)

if __name__ == '__main__' :
    test_Hello_World()