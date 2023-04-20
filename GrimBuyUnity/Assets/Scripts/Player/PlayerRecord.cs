using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRecord
{
    private static PlayerRecord Instance = null;

    public Vector3 OutDoorPosition = new Vector3(0, 1, -5.32f);

    public Vector3 InStorePosition;


    public static PlayerRecord GetInstance()
    {
        if (Instance == null)
        {
            Instance = new PlayerRecord();
        }
        return Instance;
    }
}
