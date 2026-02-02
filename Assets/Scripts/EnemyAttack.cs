using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public AudioClip enemyHit;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        var pd = other.gameObject.GetComponent<PlayerDeath>();
        if (pd == null) return;
        AudioSource.PlayClipAtPoint(enemyHit, transform.position);
        pd.playerLives--;
        Debug.Log("Player lost a life.");
        Destroy(gameObject);
    }
}
