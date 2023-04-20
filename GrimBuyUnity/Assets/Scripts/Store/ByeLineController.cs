using UnityEngine;
using UnityEngine.SceneManagement;

public class ByeLineController : MonoBehaviour
{
	private GameObject Player;

	private void Awake()
	{
		Player = GameObject.Find("Player");
	}

	private void OnTriggerEnter(Collider collision)
	{
		if (collision.transform.name == "Player")
			SceneManager.LoadScene("OutDoor");
		
	}
}
