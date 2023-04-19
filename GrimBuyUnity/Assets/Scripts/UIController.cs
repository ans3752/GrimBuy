using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text MoneyText;

    void Update()
    {
        MoneyText.text = Inven.GetInstance().Money.ToString() + " won";
    }
}
