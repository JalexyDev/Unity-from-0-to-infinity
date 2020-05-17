using UnityEngine;
using UnityEngine.UI;

public class StatusInterface : MonoBehaviour
{
    [SerializeField] Text moneyText;

    public void ShowMoneyCount(int count)
    {
        moneyText.text = count.ToString();
    }
}
