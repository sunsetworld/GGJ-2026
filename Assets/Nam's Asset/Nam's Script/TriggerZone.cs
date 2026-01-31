using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
   public bool oneshot = false;
   private bool alreadyEntered = false;
   private bool alreadyExited = false;

   public string collisionTag;
   
   public UnityEvent onTriggerEnter;
   public UnityEvent onTriggerExit;

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (alreadyEntered)
      {
         return;
      }

      if (!string.IsNullOrEmpty(collisionTag) && !other.CompareTag(collisionTag))
      {
         return;
      }
      onTriggerEnter?.Invoke();
      if (oneshot)
      {
         alreadyEntered = true;
      }
   }

   private void OnTriggerExit2D(Collider2D other)
   {
      if (alreadyExited)
      {
         return;
      }
      onTriggerExit?.Invoke();
      if (!string.IsNullOrEmpty(collisionTag) && !other.CompareTag(collisionTag))
      {
         return;
      }
      if (oneshot)
      {
         alreadyExited = true;
      }
   }

}
