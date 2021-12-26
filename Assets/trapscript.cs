using UnityEngine;

public class trapscript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {  
        GameEvents.current.HeroDie();
    }
}
