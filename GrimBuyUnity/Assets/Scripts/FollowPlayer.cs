using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject Player;
    private Vector3 Offset = new Vector3(0, 7.9f, -10) - new Vector3(0, 1, -5.3f);
	private void Start()
	{
		Player = GameObject.Find("Player");
	}

	void Update()
    {
        transform.position = Player.transform.position + Offset;
    }
}
