using UnityEngine;

public class EnemyMask : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (MaskVision.maskOn)
        {
            case true:
                _spriteRenderer.enabled = false;
                break;
            case false:
                _spriteRenderer.enabled = true;
                break;
        }
    }
}
