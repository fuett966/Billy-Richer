using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSingltone
{
    private static GameManagerSingltone instance;

    private GameManagerSingltone() { }

    public static GameManagerSingltone getInstance()
    {
        if (instance == null)
        {
            instance = new GameManagerSingltone();
        }
        return instance;
    }
}
