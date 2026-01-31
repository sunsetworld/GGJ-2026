using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisappearedPlatform : MonoBehaviour
{
   private SpriteRenderer _spriteRenderer;

   private void Awake()
   {
       _spriteRenderer = GetComponent<SpriteRenderer>();    
   }

   void Update()
   {
       if (MaskVision.maskOn == true)
       {
           _spriteRenderer.enabled = true;
       }

       if (MaskVision.maskOn == false)
       {
           _spriteRenderer.enabled = false;
       }
   }
}
