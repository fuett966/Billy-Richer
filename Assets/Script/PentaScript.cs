using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentaScript : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameEvents.current.TargetIsCollected();
        Destroy(gameObject);
    }
}
