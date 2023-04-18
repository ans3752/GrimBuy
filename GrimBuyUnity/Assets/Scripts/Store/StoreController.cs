using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreController : MonoBehaviour
{
    // ** 야외에서 플레이어와 닿으면 StoreName 씬을 로드.
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
