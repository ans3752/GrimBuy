using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge
{
    private static Fridge Instance;

    public int Money = 1000;
    public List<string> Inside = new List<string>();

    public static Fridge GetInstance()
    {
        if (Instance == null)
            Instance = new Fridge();
        return Instance;
    }

    public void Buy(string foodName)
	{
        Inside.Add(foodName);
	}
}
