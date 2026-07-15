using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvolutionaryAlgorithm : MonoBehaviour
{
    //public GameObject agentPrefab;
    //public Transform goalPosition;
    //public int populationSize = 10;
    //private List<Individual> population = new List<Individual>();

    //void Start()
    //{
    //    // Inicializar la población de "Individuos"
    //    for (int i = 0; i < populationSize; i++)
    //    {
    //        // Crear un nuevo "Individual" con parámetros aleatorios
    //        Individual newIndividual = new Individual(
    //            Random.Range(1f, 5f), // Speed
    //            Random.Range(30f, 100f), // Turn Speed
    //            Random.Range(5f, 15f) // Detection Range
    //        );

    //        // Instanciar el prefab de agente y asignarlo
    //        GameObject newAgentObj = Instantiate(agentPrefab, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
    //        Agent newAgent = newAgentObj.GetComponent<Agent>();
    //        newIndividual.agentInstance = newAgent; // Vincular el agente a este individuo
    //        newAgent.goalPosition = goalPosition;

    //        // Aplicar los parámetros de "Individual" al "Agent"
    //        newIndividual.ApplyParametersToAgent();

    //        population.Add(newIndividual);
    //    }
    //}

    //void Update()
    //{
    //    // Evaluar el desempeño de la población
    //    foreach (Individual individual in population)
    //    {
    //        EvaluateIndividual(individual);
    //    }

    //    // Evolve la población
    //    EvolvePopulation();
    //}

    //void EvaluateIndividual(Individual individual)
    //{
    //    // Evaluar el desempeño del "Agent" en base a su comportamiento
    //    // (por ejemplo, distacia al objetivo, colisiones evitadas, etc.)
    //    float distanceToGoal = Vector3.Distance(individual.agentInstance.transform.position, individual.agentInstance.goalPosition.position);
    //    float fitness = 1 / distanceToGoal; // Mejor mientras más cerca esté del objetivo
    //    individual.fitnessScore = fitness;
    //}

    //void EvolvePopulation()
    //{
    //    // Ordenar a los individuos por su puntaje de fitness
    //    population.Sort((a, b) => b.fitnessScore.CompareTo(a.fitnessScore));

    //    // Crear una nueva población de hijos (descendientes)
    //    List<Individual> newPopulation = new List<Individual>();

    //    // Seleccionar los mejores y mutar para crear nuevos individuos
    //    for (int i = 0; i < populationSize / 2; i++)
    //    {
    //        Individual elite = population[i];
    //        Individual child = new Individual(elite.speed, elite.turnSpeed, elite.detectionRange);
    //        child.agentInstance = Instantiate(elite.agentInstance.gameObject).GetComponent<Agent>(); // Crear una nueva instancia del agente
    //        child.agentInstance.goalPosition = goalPosition;

    //        // Mutar los parámetros del nuevo "Individual"
    //        child.Mutate(0.2f);

    //        // Aplicar la mutación al "Agent"
    //        child.ApplyParametersToAgent();

    //        newPopulation.Add(child);
    //    }

    //    // Reemplazar la población antigua por la nueva
    //    population = newPopulation;
    //}












































    //public GameObject agentPrefab;
    //public int populationSize = 10;
    //public int numOffspring = 20;
    //private List<Agent> population = new List<Agent>();
    //private List<Individual> individuals = new List<Individual>();

    //public Transform pointA; // Punto A de inicio
    //public Transform pointB; // Punto B de destino
    //public float obstaclePenalty = 100f; // Penalización por colisión con obstáculos

    //public static Transform goalPosition;

    //void Start()
    //{
    //    // Inicializa la población
    //    for (int i = 0; i < populationSize; i++)
    //    {
    //        GameObject agentObject = Instantiate(agentPrefab, pointA.position, Quaternion.identity);
    //        Agent agent = agentObject.GetComponent<Agent>();

    //        // Crear individuo con parámetros aleatorios
    //        float randomSpeed = Random.Range(1.0f, 10.0f);
    //        float randomRotationSpeed = Random.Range(1.0f, 5.0f);
    //        float randomReactionTime = Random.Range(0.1f, 3.0f);

    //        Individual individual = new Individual(randomSpeed, randomRotationSpeed, randomReactionTime);
    //        individuals.Add(individual);
    //        agent.SetParameters(randomSpeed, randomRotationSpeed, randomReactionTime);

    //        // Agregar agente a la población
    //        population.Add(agent);
    //    }

    //    goalPosition = pointB;
    //}

    //void Update()
    //{
    //    // Realizar evolución en cada ciclo
    //    if (Time.frameCount % 300 == 0)
    //    {
    //        Evolve();
    //    }
    //}

    //void Evolve()
    //{
    //    List<Individual> offspring = new List<Individual>();

    //    for (int i = 0; i < numOffspring; i++)
    //    {
    //        Individual parent1 = individuals[Random.Range(0, populationSize)];
    //        Individual parent2 = individuals[Random.Range(0, populationSize)];

    //        Individual child = CreateOffspring(parent1, parent2);
    //        offspring.Add(child);
    //    }

    //    // Evaluar a los descendientes
    //    for (int i = 0; i < offspring.Count; i++)
    //    {
    //        GameObject childObject = Instantiate(agentPrefab, pointA.position, Quaternion.identity);
    //        Agent childAgent = childObject.GetComponent<Agent>();
    //        childAgent.SetParameters(offspring[i].speed, offspring[i].rotationSpeed, offspring[i].reactionTime);

    //        // Evaluar el fitness
    //        float fitness = offspring[i].EvaluateFitness(childAgent);
    //        Debug.Log($"Fitness del hijo: {fitness}");
    //    }

    //    // Seleccionar los mejores µ individuos
    //    SelectBestIndividuals();
    //}

    //// Crear un descendiente a partir de dos padres
    //Individual CreateOffspring(Individual parent1, Individual parent2)
    //{
    //    float newSpeed = (parent1.speed + parent2.speed) / 2.0f;
    //    float newRotationSpeed = (parent1.rotationSpeed + parent2.rotationSpeed) / 2.0f;
    //    float newReactionTime = (parent1.reactionTime + parent2.reactionTime) / 2.0f;

    //    // Mutación aleatoria
    //    newSpeed += Random.Range(-1.0f, 1.0f);
    //    newRotationSpeed += Random.Range(-0.5f, 0.5f);
    //    newReactionTime += Random.Range(-0.2f, 0.2f);

    //    return new Individual(newSpeed, newRotationSpeed, newReactionTime);
    //}

    //// Función para seleccionar los mejores individuos
    //void SelectBestIndividuals()
    //{
    //    individuals.Sort((x, y) => y.EvaluateFitness(population[individuals.IndexOf(y)]).CompareTo(x.EvaluateFitness(population[individuals.IndexOf(x)])));
    //    individuals.RemoveRange(populationSize, individuals.Count - populationSize);
    //}
}
