using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterController : MonoBehaviour
{
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.transform.name == "Player")
		{
			Inven.GetInstance().Money -= 100;
			Fridge.GetInstance().Buy("Burger");
		}
	}
}
