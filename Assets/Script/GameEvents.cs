using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    private void Awake()
    {
        current = this;
    }

    public event Action onTargetIsCollected;
    public event Action onAllTargetIsCollected;
    public event Action onHeroDie;
    public void TargetIsCollected(){
        if (onTargetIsCollected != null){
            onTargetIsCollected();
        }
    }
    public void AllTargetIsCollected(){
        if (onAllTargetIsCollected != null){
            onAllTargetIsCollected();
        }
    }
    public void HeroDie(){
        if (onHeroDie != null){
            onHeroDie();
        }
    }
}
