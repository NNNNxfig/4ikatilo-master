using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int coinCount = 0;

    private ParticleSystem coinEffect;

    private void Start()
    {

        coinEffect = GetComponentInChildren<ParticleSystem>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            coinCount++;


            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;


            if (coinEffect != null)
            {
                coinEffect.Play();
            }


            Destroy(gameObject, coinEffect.main.duration);
        }
    }
}
