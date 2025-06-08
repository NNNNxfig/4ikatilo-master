using UnityEngine;


public class Uzi : MonoBehaviour
{
    public Vector3 offset = new Vector3(1, 0, 0);
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer parentSpriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (transform.parent != null)
        {
            parentSpriteRenderer = transform.parent.GetComponent<SpriteRenderer>();
        }
    }

    private void Update()
    {
        if (parentSpriteRenderer != null)
        {
            spriteRenderer.flipX = !parentSpriteRenderer.flipX;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            transform.SetParent(other.transform);
            transform.localPosition = offset;

            
            parentSpriteRenderer = other.GetComponent<SpriteRenderer>();
        }
    }
}
