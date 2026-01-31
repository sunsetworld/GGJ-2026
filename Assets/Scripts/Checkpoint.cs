using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    GameManager gm;
    bool checkpointUsable = true;
    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player") || !checkpointUsable) return;
        checkpointUsable = false;
        gm.UpdateCheckPoint(transform.position);
        Debug.Log("Checkpoint has been updated to " + gm.checkpoint);
    }
}
