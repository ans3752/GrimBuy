using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreController : MonoBehaviour
{
    // ** �߿ܿ��� �÷��̾�� ������ StoreName ���� �ε�.
    public string StoreName = "BasicStore";

    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
        print(other.name);
        SceneManager.LoadScene("BasicStore");
	}
}
