using System;
using System.Collections;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Vector2 checkpoint;
    public GameObject player;
    public GameObject playerToSpawn;
    public float deathPosY = -10f;
    public bool playerDied;
    PlayerDeath playerDeath;
    CinemachineVirtualCamera vcam;
    HUD hud;

    public bool hasFinishedGame;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint = player.transform.position;
        playerDeath = player.GetComponent<PlayerDeath>();
        vcam = FindObjectOfType<CinemachineVirtualCamera>();
        hud = FindObjectOfType<HUD>();
    }

    private void Update()
    {
        if (hasFinishedGame) StartCoroutine(GameOver());
        if (player == null) return;
        if (player.transform.position.y <= deathPosY || playerDied)  
            StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {
        Destroy(player);
        playerDied = false;
        yield return new WaitForSeconds(3f);
        player = Instantiate(playerToSpawn, checkpoint, Quaternion.identity);
        vcam.Follow = player.transform;
        hud.UpdatePlayerForUI(player);
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }

    public void UpdateCheckPoint(Vector2 newCheckpoint)
    {
        checkpoint = newCheckpoint;
    }
}
