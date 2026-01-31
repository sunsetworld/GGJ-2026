using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public float deathPosY = -10f;
    GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= deathPosY)
        {
            StartCoroutine(gm.Respawn());
        }
    }
}
