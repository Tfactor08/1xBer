using UnityEngine;
using UnityEngine.UI;

public class Loaded : MonoBehaviour
{
    public Text amount;
    
    void Start()
    {
        amount.text = Ui_Manager.account.Amount.ToString();
    }
}
