using UnityEngine;

public class Uzi : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
            Debug.LogError("SpriteRenderer не найден на объекте Uzi!");
    }

    void Update()
    {
        if (transform.parent != null && spriteRenderer != null)
        {
            // Если родитель смотрит влево (scale.x < 0), флипнуть спрайт пушки
            spriteRenderer.flipX = transform.parent.localScale.x < 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Uzi"))
        {
            other.transform.SetParent(transform);
            other.transform.localPosition = new Vector3(1, 0, 0);
        }
    }
}
