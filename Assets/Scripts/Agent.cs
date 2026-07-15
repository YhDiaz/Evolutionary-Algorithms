using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    //public Transform goalPosition; // Punto B
    //public float speed = 5f;
    //public float turnSpeed = 180f;
    //public float detectionRange = 10f;

    //void Update()
    //{
    //    MoveToGoal();
    //}

    //// Método de movimiento con evasión de obstáculos
    //public void MoveToGoal()
    //{
    //    if (goalPosition == null) return;

    //    // Dirección hacia el objetivo
    //    Vector3 direction = (goalPosition.position - transform.position).normalized;

    //    // Raycast para detectar obstáculos al frente
    //    RaycastHit hit;
    //    bool isObstacleAhead = Physics.Raycast(transform.position, direction, out hit, detectionRange);

    //    // Raycast a los lados
    //    bool isObstacleLeft = Physics.Raycast(transform.position, -transform.right, out hit, detectionRange);
    //    bool isObstacleRight = Physics.Raycast(transform.position, transform.right, out hit, detectionRange);

    //    // Si hay un obstáculo adelante, evitarlo
    //    if (isObstacleAhead)
    //    {
    //        if (isObstacleLeft && !isObstacleRight)
    //            direction = transform.right;  // Girar a la derecha
    //        else if (isObstacleRight && !isObstacleLeft)
    //            direction = -transform.right; // Girar a la izquierda
    //        else
    //            direction = Vector3.Cross(direction, Vector3.up); // Evitar a ambos lados con un giro
    //    }

    //    // Movimiento
    //    transform.position += direction * speed * Time.deltaTime;

    //    // Rotación hacia la dirección de movimiento
    //    Quaternion targetRotation = Quaternion.LookRotation(direction);
    //    transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    //}






























    //public Transform goalPosition;  // Objetivo (punto B)
    //public float speed = 5.0f;
    //public float rotationSpeed = 3.0f;
    //public float reactionTime = 1.0f;

    //private float timer;

    //private void Start()
    //{
    //    goalPosition = EvolutionaryAlgorithm.goalPosition;
    //}

    //// Método para asignar los parámetros evolucionados al agente
    //public void SetParameters(float speed, float rotationSpeed, float reactionTime)
    //{
    //    this.speed = speed;
    //    this.rotationSpeed = rotationSpeed;
    //    this.reactionTime = reactionTime;
    //}

    //void Update()
    //{
    //    // Mover el agente hacia el objetivo
    //    MoveTowardsGoal();

    //    // Verificar si el agente ha chocado con un obstáculo
    //    if (HasCollidedWithObstacle())
    //    {
    //        // Esto puede desencadenar una penalización en el fitness
    //    }
    //}

    //void MoveTowardsGoal()
    //{
    //    // Calcular dirección hacia el objetivo
    //    Vector3 direction = (goalPosition.position - transform.position).normalized;

    //    // Mover al agente
    //    transform.Translate(direction * speed * Time.deltaTime, Space.World);

    //    // Girar para mirar hacia el objetivo
    //    Quaternion targetRotation = Quaternion.LookRotation(direction);
    //    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    //}

    //// Método para verificar colisiones con obstáculos
    //public bool HasCollidedWithObstacle()
    //{
    //    // Usamos un Raycast para detectar colisiones
    //    RaycastHit hit;
    //    if (Physics.Raycast(transform.position, transform.forward, out hit, 1f))
    //    {
    //        if (hit.collider.CompareTag("Obstacle"))
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}
}
