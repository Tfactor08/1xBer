using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddAmount : MonoBehaviour
{
    private const string _password = "151899";

    public Text amount;
    public Text password;
    public Text info;

   public void Add()
   {
        Ui_Manager.account.Added += Display;
        Ui_Manager.account.DisplayInfo += Display;

        if (!string.IsNullOrEmpty(amount.text) &&
            !string.IsNullOrEmpty(password.text))
        {
            if (password.text == _password)
            {
                info.color = Color.green;
                Ui_Manager.account.Add(int.Parse(amount.text));
                SceneManager.LoadScene(1);
            }
            else
                Display("Пароль введен неверно");
        }
        else
            Display("Введите все данные");
   }

    private void Display(string message)
    {
        info.text = message;
    }
}
