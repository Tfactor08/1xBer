using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ui_Manager2 : MonoBehaviour
{
    public Text amount;
    public static decimal _amount;
    public Text amount_info;

    void Start()
    {
        amount_info.text = Ui_Manager.account.Amount.ToString();
    }

    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(amount.text))
        {
            if (Ui_Manager.account.Amount >= decimal.Parse(amount.text) &&
                decimal.Parse(amount.text) <=  ButtonManager.MAX &&
                decimal.Parse(amount.text) >= ButtonManager.MIN)
            {
                _amount = decimal.Parse(amount.text);
                Ui_Manager.account.Amount -= decimal.Parse(amount.text);
                SceneManager.LoadScene(3);
            }
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMoreLessGameScene()
    {
        if (!string.IsNullOrEmpty(amount.text))
        {
            if (Ui_Manager.account.Amount >= decimal.Parse(amount.text) &&
                decimal.Parse(amount.text) <= ButtonManager.MAX &&
                decimal.Parse(amount.text) >= ButtonManager.MIN)
            {
                _amount = decimal.Parse(amount.text);
                Ui_Manager.account.Amount -= decimal.Parse(amount.text);
                SceneManager.LoadScene(7);
            }
        }
    }
}