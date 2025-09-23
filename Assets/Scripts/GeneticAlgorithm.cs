using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using System.IO;

public class GeneticAlgorithm : MonoBehaviour
{
    public int mu = 50;
    public int lambda = 50;
    public int maxGenerations = 5;
    public int maxFitness = 10;
    public bool restart = false;

    public List<Individual> population;

    private int currentGeneration = 0;

    private Coroutine algorithm;

    private void OnValidate()
    {
        if (restart)
        {
            restart = false;

            if (algorithm != null)
            {
                StopCoroutine(algorithm);
            }

            population = new();
            currentGeneration = 0;
            InitializePopulation();
            algorithm = StartCoroutine(PlayAlgorithm());
        }
    }

    private void Start()
    {
        population ??= new();
        InitializePopulation();

        algorithm = StartCoroutine(PlayAlgorithm());
    }

    private void InitializePopulation()
    {
        for (int i = 0; i < mu + lambda; i++)
        {
            Individual individual = new Individual(Random.Range(1, 5));
            population.Add(individual);
        }
    }

    private void ShufflePopulation()
    {
        for (int i = 0; i < population.Count; i++)
        {
            Individual temp = population[i];
            int randomIndex = Random.Range(i, population.Count);
            population[i] = population[randomIndex];
            population[randomIndex] = temp;
        }
    }

    private void EvaluateAndSortIndividuals()
    {
        population.Sort((a, b) => FitnessFunction(b).CompareTo(FitnessFunction(a)));
    }

    private void KeepElitePopulation()
    {
        if (population.Count > mu)
        {
            population = population.GetRange(0, mu);
            //population.RemoveRange(mu, population.Count - mu);
        }
    }

    private void GenerateOffspring()
    {
        List<Individual> offspring = MakeEliteIndividualCopies();

        PerturbeOffspring(offspring);

        population.AddRange(offspring);
    }

    private List<Individual> MakeEliteIndividualCopies()
    {
        List<Individual> offspring = new();

        for (int i = 0; i < mu; i++)
        {
            offspring.Add(population[i]);
        }

        return offspring;
    }

    private void PerturbeOffspring(List<Individual> offspring)
    {
        for (int i = 0; i < offspring.Count; i++)
        {
            if (Random.value < 0.1f)
            {
                offspring[i].speed += Random.Range(-1, 2);
                offspring[i].speed = Mathf.Clamp(offspring[i].speed, 1, 10);
            }
        }
    }

    private int FitnessFunction(Individual individual)
    {
        return individual.speed;
    }

    private IEnumerator PlayAlgorithm()
    {
        Debug.Log($"Starting Genetic Algorithm with population size {population.Count}");

        while (currentGeneration < maxGenerations && GetHighestFitness() < maxFitness)
        {
            Debug.Log($"Generación {currentGeneration}");

            ShufflePopulation();
            EvaluateAndSortIndividuals();
            KeepElitePopulation();
            GenerateOffspring();

            Debug.Log($"Highest fitness: {GetHighestFitness()}");

            currentGeneration++;

            WriteGenerationToFile(currentGeneration);

            yield return null;
        }
    }

    private int GetHighestFitness()
    {
        int highestFitness = int.MinValue;
        foreach (Individual individual in population)
        {
            int fitness = FitnessFunction(individual);
            if (fitness > highestFitness)
            {
                highestFitness = fitness;
            }
        }
        return highestFitness;
    }

    private bool isFirstGeneration = true;

    private void WriteGenerationToFile(int generation)
    {
        string path = Application.dataPath + "/GeneticAlgorithmLog.txt";
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Generación: {generation}");

        // Crear una copia ordenada de la población
        List<Individual> sortedPopulation = new List<Individual>(population);
        sortedPopulation.Sort((a, b) => FitnessFunction(b).CompareTo(FitnessFunction(a)));

        for (int i = 0; i < sortedPopulation.Count; i++)
        {
            int fitness = FitnessFunction(sortedPopulation[i]);
            sb.AppendLine($"Individuo {i + 1}: speed = {sortedPopulation[i].speed}, fitness = {fitness}");
        }
        sb.AppendLine();

        try
        {
            if (isFirstGeneration)
            {
                File.WriteAllText(path, sb.ToString(), Encoding.UTF8); // Sobrescribe el archivo
                isFirstGeneration = false;
            }
            else
            {
                File.AppendAllText(path, sb.ToString(), Encoding.UTF8); // Añade al archivo
            }
        }
        catch (IOException ex)
        {
            Debug.LogError($"Error al escribir el archivo: {ex.Message}");
        }
    }
}
