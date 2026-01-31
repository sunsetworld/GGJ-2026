using UnityEngine;

public class BlackPlatform : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _blackColor;
    [SerializeField] private Color _brightColor;

    [SerializeField] private float changeTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MaskVision.maskOn == true)
        {
            _spriteRenderer.color = Color.Lerp(_spriteRenderer.color, _brightColor, Time.deltaTime * changeTime);
        }
        else
        {
            _spriteRenderer.color = Color.Lerp(_spriteRenderer.color, _blackColor, Time.deltaTime * changeTime);
        }
    }
}
