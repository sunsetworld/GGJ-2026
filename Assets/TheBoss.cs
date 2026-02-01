using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBoss : MonoBehaviour
{
    public int bossHealth = 3;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        bossHealth--;
        Debug.Log("Boss Health: " + bossHealth);
        if (bossHealth > 0) return;
        gameManager.hasFinishedGame = true;
        Destroy(gameObject);
    }
}
