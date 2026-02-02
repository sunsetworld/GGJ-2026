using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    PlayerDeath player;

    public TMP_Text healthTxt;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerDeath>();
    }

    // Update is called once per frame
    void Update()
    {
        healthTxt.text = "Lives: " + player.playerLives;
    }

    public void UpdatePlayerForUI(GameObject newPlayer)
    {
        player = newPlayer.GetComponent<PlayerDeath>();
    }
}
