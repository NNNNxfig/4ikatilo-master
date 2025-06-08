using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public Transform pointA;       // Первая точка патруля
    public Transform pointB;       // Вторая точка патруля
    public float speed = 2f;       // Скорость движения

    

    [SerializeField] private int damage = 1; // Урон, который наносит враг

    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = pointB.position; // Начинаем движение к точке B
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (targetPosition == pointB.position)
                targetPosition = pointA.position;
            else
                targetPosition = pointB.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.Damage(damage);
            }
        }
    }
}
