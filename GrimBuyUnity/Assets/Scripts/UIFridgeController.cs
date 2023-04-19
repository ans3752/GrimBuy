using UnityEngine;
using UnityEngine.UI;

public class UIFridgeController : MonoBehaviour
{
    public Text Food;

    void Update()
    {
        Food.text = "";
        for (int i=0;i<Fridge.GetInstance().Inside.Count;++i)
		{
            Food.text += Fridge.GetInstance().Inside[i].ToString() + "\n";
		}
    }
}
