using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui_Manager : MonoBehaviour
{
    public static Account account;

    void Start()
    {
        account = new Account();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
