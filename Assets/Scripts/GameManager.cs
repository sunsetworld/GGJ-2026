using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector2 checkpoint;
    public GameObject player;
    public float deathPosY = -10f;
    public bool playerDied;
    PlayerDeath playerDeath;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint = player.transform.position;
        playerDeath = player.GetComponent<PlayerDeath>();
    }

    private void Update()
    {
        if (player.transform.position.y <= deathPosY || playerDied)
        {
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        player.gameObject.SetActive(false);
        playerDied = false;
        yield return new WaitForSeconds(3f);
        player.gameObject.SetActive(true);
        playerDeath.ResetPlayerLives();
        player.transform.position = checkpoint;
    }

    public void UpdateCheckPoint(Vector2 newCheckpoint)
    {
        checkpoint = newCheckpoint;
    }
}
