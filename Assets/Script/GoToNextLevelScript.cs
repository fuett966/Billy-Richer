using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToNextLevelScript : MonoBehaviour
{ 
    private Color tmp; 
    public Text TextGameObject;
    Color InitialColor;
    private bool isTriggered = false;
    public GameController gameController;
    void Start()
    {
        InitialColor = TextGameObject.GetComponent<Text>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTriggered && Input.GetKeyDown(KeyCode.E) && gameController.ArtCount == gameController.ArtOnLevelCount){
            GameEvents.current.AllTargetIsCollected();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        isTriggered = true;
        // GameEvents.current.TargetIsCollected();
        tmp.a = 255;
        TextGameObject.GetComponent<Text>().color +=  tmp;
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        tmp.a = 255;
        // GameEvents.current.TargetIsCollected();
        TextGameObject.GetComponent<Text>().color -=  tmp;
        isTriggered = false;
    }
}
