import datetime
import genetic
import unittest

class GuessPasswordTests(unittest.TestCase):
    genSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!?. "

    def test_Hello_World(self):
        target = "Hello World!"
        self.guess_password(target)

    def guess_password(self, target):
        startTime = datetime.datetime.now()

        def fnGetFitness(genes):
            return get_fitness(genes, target)

        def fnDisplay(genes):
            display(genes, target, startTime)

        optimalFitness = len(target)
        best = genetic.getBest(fnGetFitness, len(target), optimalFitness, self.genSet, fnDisplay)

        self.assertEqual(best, target)


def display(genes, target, startTime):
    timeD = datetime.datetime.now() - startTime
    fitness = get_fitness(genes, target)
    print("{0}\t{1}\t{2}".format(genes, fitness, str(timeD)))

def get_fitness(genes, target):
    return sum(1 for expected, actual in zip(target, genes) if expected == actual)

if __name__ == '__main__' :
    unittest.main()