using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreController : MonoBehaviour
{
    // ** �߿ܿ��� �÷��̾�� ������ StoreName ���� �ε�.
    public string StoreName = "BasicStore";

	private void OnTriggerEnter(Collider other)
	{
        if (other.tag == "Player")
		{
		    SceneManager.LoadScene("BasicStore");
		}
	}
}
