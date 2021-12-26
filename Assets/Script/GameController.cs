
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int ArtOnLevelCount= 0;
    public string nextLevelName;
    public string thisLevelName;
    public Text TextGameObject;
    [HideInInspector]public int ArtCount = 0;
    public void Start()
    {
        GameEvents.current.onTargetIsCollected += OnTargetWasCollected;
        GameEvents.current.onAllTargetIsCollected += OnAllTargetsCollected;
        GameEvents.current.onHeroDie += OnHeroDied;
        TextGameObject.text = "Найдите все артефакты: " + ArtCount+ " из " + ArtOnLevelCount;
    }
    public void OnTargetWasCollected(){
        ArtCount += 1;
        TextGameObject.text = "Найдите все артефакты: " + ArtCount+ " из " + ArtOnLevelCount;
    }
    public void OnAllTargetsCollected(){
        SceneManager.LoadScene(nextLevelName);
        ArtCount = 0;
    }
    public void OnHeroDied(){
        SceneManager.LoadScene(thisLevelName);
        ArtCount = 0;
    }
}
