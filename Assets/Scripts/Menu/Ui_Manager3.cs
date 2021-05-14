using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ui_Manager3 : MonoBehaviour
{
    public Text amount;

    void Start()
    {
        amount.text = Ui_Manager.account.Amount.ToString();
    }

    public void LoadAppleOfFortune()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadAddScene()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadWithdrawScene()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadMoreLessScene()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadLuckyCardScene()
    {
        SceneManager.LoadScene(8);
    }
}
