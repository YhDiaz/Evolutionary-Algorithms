using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Individual
{
    public int speed;

    public Individual(int speed)
    {
        this.speed = speed;
    }























    //public float speed;
    //public float turnSpeed;
    //public float detectionRange;
    //public float fitnessScore; // Puntaje de aptitud para evaluar qu� tan bien se desempe�a el agente
    //public Agent agentInstance; // Instancia del agente en la escena

    //public Individual(float speed, float turnSpeed, float detectionRange)
    //{
    //    this.speed = speed;
    //    this.turnSpeed = turnSpeed;
    //    this.detectionRange = detectionRange;
    //    this.fitnessScore = 0f; // Inicialmente, no tiene puntaje de aptitud
    //}

    //// M�todo para asignar las caracter�sticas del Individual al agente
    //public void ApplyParametersToAgent()
    //{
    //    if (agentInstance != null)
    //    {
    //        agentInstance.speed = this.speed;
    //        agentInstance.turnSpeed = this.turnSpeed;
    //        agentInstance.detectionRange = this.detectionRange;
    //    }
    //}

    //// M�todo para mutar los par�metros de este Individual
    //public void Mutate(float mutationFactor)
    //{
    //    speed += Random.Range(-mutationFactor, mutationFactor);
    //    turnSpeed += Random.Range(-mutationFactor, mutationFactor);
    //    detectionRange += Random.Range(-mutationFactor, mutationFactor);
    //}


































    //public float speed;
    //public float rotationSpeed;
    //public float reactionTime;

    //public Individual(float speed, float rotationSpeed, float reactionTime)
    //{
    //    this.speed = speed;
    //    this.rotationSpeed = rotationSpeed;
    //    this.reactionTime = reactionTime;
    //}

    //public Individual Clone()
    //{
    //    return new Individual(speed, rotationSpeed, reactionTime);
    //}

    //// Funci�n para evaluar el desempe�o del agente
    //public float EvaluateFitness(Agent agent)
    //{
    //    // Distancia al objetivo B
    //    float distanceToGoal = Vector3.Distance(agent.transform.position, agent.goalPosition.position);

    //    // Penalizaci�n por chocar con un obst�culo
    //    float penalty = 0f;
    //    if (agent.HasCollidedWithObstacle())
    //    {
    //        penalty = 100f;  // Penalizaci�n alta por colisi�n
    //    }

    //    // Fitness es la proximidad al objetivo (distancia) menos la penalizaci�n por colisi�n
    //    float fitness = distanceToGoal - penalty;
    //    return fitness;
    //}
}
