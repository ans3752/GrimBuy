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
			Message.text = "����� ���� ������ ��Ҵ�. ���� ���� ���̴�.";
		else
			Message.text = "�� ���� ������ get!";
	}
}
