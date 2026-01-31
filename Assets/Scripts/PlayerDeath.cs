using System;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public int playerLives = 3;
    private GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (playerLives <= 0)
        {
            gm.playerDied = true;
        }
    }
}
