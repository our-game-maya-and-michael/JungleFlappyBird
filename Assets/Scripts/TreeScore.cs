using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScore : MonoBehaviour
{
    public float triggerCooldown = 1f; // Cooldown period in seconds

    private bool isTriggerActive = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird") && isTriggerActive)
        {
            ScoreManager.instance.AddPoint();
            StartCoroutine(TriggerCooldown());
        }
    }

    IEnumerator TriggerCooldown()
    {
        isTriggerActive = false;
        yield return new WaitForSeconds(triggerCooldown);
        isTriggerActive = true;
    }
}
