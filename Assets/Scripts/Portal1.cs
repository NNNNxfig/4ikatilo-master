using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalLevel2 : MonoBehaviour
{
    public int requiredCoins = 15; // сколько нужно монет для входа

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Coin.coinCount >= requiredCoins)
            {
                SceneManager.LoadScene(3); // Загружаем третий уровень (индекс 2)
            }
            else
            {
                Debug.Log($"Нужно собрать как минимум {requiredCoins} монет! Сейчас: {Coin.coinCount}");
                // Можно добавить UI-сообщение игроку здесь
            }
        }
    }
}
