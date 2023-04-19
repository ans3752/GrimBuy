using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float Speed = 2.0f;

	private void Awake()
	{
        DontDestroyOnLoad(gameObject);	
	}

	void Update()
    {
        TestMove();
        if (Input.GetKeyUp(KeyCode.Space))
            SceneManager.LoadScene("Fridge");
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
