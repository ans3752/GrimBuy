using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Speed = 1.5f;

	private void Awake()
	{
        DontDestroyOnLoad(gameObject);	
	}

	void Update()
    {
        TestMove();
    }

    private void TestMove()
	{
        Vector3 movement = new Vector3(
            Input.GetAxis("Horizontal"),
            0.0f,
            Input.GetAxis("Vertical")
            );

        transform.position += movement * Speed * Time.deltaTime;
	}
}
