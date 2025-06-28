using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;       // Префаб пули
    public Transform firePointLeft;       // Левая точка выстрела
    public Transform firePointRight;      // Правая точка выстрела
    public float bulletSpeed = 10f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
            Debug.LogError("SpriteRenderer не найден на игроке!");
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        float direction = spriteRenderer.flipX ? 1f : -1f;

        FireBullet(firePointLeft, direction);
        FireBullet(firePointRight, direction);
    }

    void FireBullet(Transform firePoint, float direction)
    {
        Quaternion rotation = Quaternion.Euler(0, 0, direction < 0 ? 180f : 0f);

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.velocity = Vector2.right * direction * bulletSpeed;
        }
    }
}
