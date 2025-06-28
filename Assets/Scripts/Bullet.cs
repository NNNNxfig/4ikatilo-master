using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Здесь можно добавить урон, эффекты и т.д.
        Destroy(gameObject);
    }
}
