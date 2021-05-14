using UnityEngine;
using UnityEngine.SceneManagement;

public class Take : MonoBehaviour
{
    public void TakeGain()
    {
        switch (CheckWin.level)
        {
            case 1:
                Ui_Manager.account.Amount += Ui_Manager2._amount * 1.24m;
                break;
            case 2:
                Ui_Manager.account.Amount += Ui_Manager2._amount * 1.55m;
                break;
            case 3:
                Ui_Manager.account.Amount += Ui_Manager2._amount * 1.93m;
                break;
            case 4:
                Ui_Manager.account.Amount += Ui_Manager2._amount * 2.42m;
                break;
            case 5:
                Ui_Manager.account.Amount += Ui_Manager2._amount * 4.03m;
                break;
            case 6:
                Ui_Manager.account.Amount += Ui_Manager2._amount * 6.71m;
                break;
            case 7:
                Ui_Manager.account.Amount += Ui_Manager2._amount * 11.19m;
                break;
        }

        SceneManager.LoadScene(2);
    }
}
