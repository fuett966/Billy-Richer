
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text TextGameObject;
    public int ArtCount = 0;
    public void Start()
    {
        GameEvents.current.onTargetIsCollected += OnTargetWasCollected;
    }
    public void OnTargetWasCollected(){
        ArtCount += 1;
        TextGameObject.text = "Найдите все артефакты: " + Convert.ToInt32(ArtCount)+ " из 5 ";
    }
    public void OnAllTargetsCollected(){
        ArtCount = 0;
    }
}
