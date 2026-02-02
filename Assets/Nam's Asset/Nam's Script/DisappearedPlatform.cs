using UnityEngine;

public class DisappearedPlatform : MonoBehaviour
{
   private SpriteRenderer _spriteRenderer;
   [Header("Debug")]
   public bool disableMaskVision;

   private void Awake()
   {
       _spriteRenderer = GetComponent<SpriteRenderer>();    
   }

   void Update()
   {
       if (disableMaskVision) return;
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
