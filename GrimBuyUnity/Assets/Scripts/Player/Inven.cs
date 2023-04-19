using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inven
{
    private static Inven Instance;

    public int Money = 1000;

    public static Inven GetInstance()
	{
        if (Instance == null)
            Instance = new Inven();
        return Instance;
	}
}
