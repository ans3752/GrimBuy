using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FridgeController : MonoBehaviour
{
    public Text Food;

    void Update()
    {
        Food.text = "";
        for (int i=0;i<Fridge.GetInstance().Inside.Count;++i)
		{
            Food.text += Fridge.GetInstance().Inside[i].ToString() + "\n";
		}
        if (Input.GetKeyUp(KeyCode.Space))
            SceneManager.LoadScene("BasicStore");
    }
}
