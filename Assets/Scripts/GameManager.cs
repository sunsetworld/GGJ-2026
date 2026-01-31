using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector2 checkpoint;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        checkpoint = player.transform.position;
    }

    public IEnumerator Respawn()
    {
        player.gameObject.SetActive(false);
        yield return new WaitForSeconds(3f);
        ResetPlayerToCheckpoint();
    }
    
    void ResetPlayerToCheckpoint()
    {
        player.transform.position = checkpoint;
        player.gameObject.SetActive(true);
    }

    public void UpdateCheckPoint(Vector2 newCheckpoint)
    {
        checkpoint = newCheckpoint;
    }
}
