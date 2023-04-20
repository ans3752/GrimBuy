using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Text Message;

	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	private void Update()
	{
		bool condition = Fridge.GetInstance().Inside.Count > 5;
		if (condition)
			Message.text = "충분히 많은 음식을 모았다. 이제 게임 끝이다.";
		else
			Message.text = "더 많은 음식을 get!";
	}
}
