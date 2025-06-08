using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;            
    public Text healthText;            

    void Start()
    {
        UpdateHealthText();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health = Mathf.Max(health - 1, 0); 
            UpdateHealthText();

            if (health <= 0)
            {
                
                Debug.Log("Игрок погиб...");
            }
        }
    }

    void UpdateHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }
}
