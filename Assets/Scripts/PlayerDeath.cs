using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public int playerLives = 3;
    private GameManager gm;
    private int originalLives;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        originalLives = playerLives;
    }

    private void Update()
    {
        if (playerLives <= 0) gm.playerDied = true;
    }

    public void ResetPlayerLives()
    {
        playerLives = originalLives;
    }
}
