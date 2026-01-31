using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class MaskVision : MonoBehaviour
{
    //[SerializeField] private Cooldown cooldown;
    public static bool maskOn;
    [SerializeField] private float CD;
    [SerializeField] private float cooldownTime;
    [SerializeField] private float maxCD;
    [SerializeField] private bool onCooldown = false;
    [SerializeField] private Slider slider;
    private bool ok = true;

    // Update is called once per frame
    void Update()
    {
        if (maskOn)
        {
            // Mask on Action
            if (CD > 0) CD -= Time.deltaTime;
        }
        else
        {
            // Mask off Action
        }
        if (Input.GetKeyDown(KeyCode.Q) && !onCooldown) maskOn = true;
        slider.value = CD/maxCD;
        if (CD <= 0 && ok) StartCoroutine(MaskCoolDown());
    }
    IEnumerator MaskCoolDown()
    {
        ok = false;
        maskOn = false;
        onCooldown = true;
        yield return new WaitForSeconds(cooldownTime);
        CD = maxCD;
        maskOn = false;
        onCooldown = false;
        ok = true;
    }
}
