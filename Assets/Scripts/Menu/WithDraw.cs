using UnityEngine;
using UnityEngine.UI;

public class WithDraw : MonoBehaviour
{
    private bool isTaken;

    public Text amount;
    public Text info;
    public Text current_amount;
    public Text buttonText;

    void Start()
    {
        isTaken = false;
        current_amount.text = Ui_Manager.account.Amount.ToString();
    }

    public void Take()
    {
        if (!isTaken)
        {
            if (!string.IsNullOrEmpty(amount.text))
            {
                decimal _amount = decimal.Parse(amount.text);

                if (_amount >= 30)
                {
                    if (Ui_Manager.account.Amount >= _amount)
                    {
                        Account_DisplayInfo($"Ожидайте перевода {_amount} рублей");
                        Ui_Manager.account.Take(_amount);
                        current_amount.text = Ui_Manager.account.Amount.ToString();
                        buttonText.text = "Получил";
                        isTaken = true;
                    }
                    else
                        Account_DisplayInfo("На аккаунте недостаточно средств");
                }
                else
                    Account_DisplayInfo("Сумма должна быть больше 30");
            }
            else
                Account_DisplayInfo("Введите сумму");
        }
        else
        {
            buttonText.text = "Вывести";
            isTaken = false;
            info.text = string.Empty;
        }
    }

    private void Account_DisplayInfo(string message)
    {
        info.text = message;
    }
}
