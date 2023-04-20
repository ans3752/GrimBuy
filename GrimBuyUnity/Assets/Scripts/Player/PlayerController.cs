using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float Speed = 2.0f;

	private void Awake()
	{
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName=="OutDoor")
		{
            transform.position = PlayerRecord.GetInstance().OutDoorPosition;
        }
        else
		{
            transform.position = PlayerRecord.GetInstance().InStorePosition;
        }
	}

	void Update()
    {
        print(PlayerRecord.GetInstance().OutDoorPosition);
        Move();
        string sceneName = SceneManager.GetActiveScene().name;
        if (Input.GetKeyUp(KeyCode.Space) && sceneName == "BasicStore")
            SceneManager.LoadScene("Fridge");
    }

    private void Move()
	{
        Vector3 movement = new Vector3(
            Input.GetAxis("Horizontal"),
            0.0f,
            Input.GetAxis("Vertical")
            );

        transform.position += movement * Speed * Time.deltaTime;
	}

    private void OnTriggerEnter(Collider other)
    {
        print(other.transform.tag);
        if (other.transform.tag == "Store")
        {
            Vector3 offset = new Vector3(0, 0, -1);
            PlayerRecord.GetInstance().OutDoorPosition = transform.position + offset;
        }
    }
}
