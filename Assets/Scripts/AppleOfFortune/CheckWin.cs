using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Collections;

public class CheckWin : MonoBehaviour
{
    public Button[] buttons = new Button[32];
    public GameObject[] arrows = new GameObject[5];
    public GameObject wholeApple;
    public GameObject eatenApple;
    public Text current_gain;

    private int index1;
    private int index2;
    private int index3;
    private int index4;
    public static int level = 0;

    void Start()
    {
        for (int i = 19; i > 4; i--)
        {
            buttons[i].enabled = false;
        }

        foreach (var arrow in arrows)
        {
            arrow.SetActive(true);
        }

        level = 0;
        current_gain.text = "0";
    }

    public void ButtonClicked(Button button)
    {
        index1 = Random.Range(0, 5);
        index2 = Random.Range(0, 5);
        while (index1 == index2) index2 = Random.Range(0, 5);
        index3 = Random.Range(0, 5);
        while (index3 == index1 || index3 == index2) index3 = Random.Range(0, 5);
        index4 = Random.Range(0, 5);
        while (index4 == index1 || index4 == index2 || index4 == index3) index4 = Random.Range(0, 5);


        if (level == 0)
        {
            if (button.tag != index1.ToString())
            {
                MoveArrows();
                level++;
                current_gain.text = $"{(Ui_Manager2._amount * 1.24m) - Ui_Manager2._amount}";
                CreateApple(wholeApple, button);
                SetUnEnabled();
                SetEnabled(level);
            }
            else
            {                
                CreateApple(eatenApple, button);
                StartCoroutine(GameOver());
            }
        }

        else if (level == 1)
        {
            if (button.tag != index1.ToString())
            {
                MoveArrows();
                level++;
                current_gain.text = $"{(Ui_Manager2._amount * 1.24m) - Ui_Manager2._amount}";
                CreateApple(wholeApple, button);
                SetUnEnabled();
                SetEnabled(level);
            }
            else
            {
                CreateApple(eatenApple, button);
                StartCoroutine(GameOver());
            }
        }

        else if (level == 2)
        {
            if (button.tag != index1.ToString() &&
                button.tag != index2.ToString())
            {
                MoveArrows();
                level++;
                current_gain.text = $"{(Ui_Manager2._amount * 1.24m) - Ui_Manager2._amount}";                
                CreateApple(wholeApple, button);
                SetUnEnabled();
                SetEnabled(level);
            }
            else
            {
                CreateApple(eatenApple, button);
                StartCoroutine(GameOver());
            }
        }

        else if (level == 3)
        {
            if (button.tag != index1.ToString() &&
                button.tag != index2.ToString())
            {
                MoveArrows();
                level++;
                current_gain.text = $"{(Ui_Manager2._amount * 1.24m) - Ui_Manager2._amount}";
                CreateApple(wholeApple, button);
                SetUnEnabled();
                SetEnabled(level);
            }
            else
            {
                CreateApple(eatenApple, button);
                StartCoroutine(GameOver());
            }
        }

        else if (level == 4)
        {
            if (button.tag != index1.ToString() &&
                button.tag != index2.ToString() &&
                button.tag != index3.ToString())
            {
                MoveArrows();
                level++;
                current_gain.text = $"{(Ui_Manager2._amount * 1.24m) - Ui_Manager2._amount}";
                CreateApple(wholeApple, button);
                SetUnEnabled();
                SetEnabled(level);
            }
            else
            {
                CreateApple(eatenApple, button);
                StartCoroutine(GameOver());
            }
        }

        else if (level == 5)
        {
            if (button.tag != index1.ToString() &&
                button.tag != index2.ToString() &&
                button.tag != index3.ToString())
            {
                MoveArrows();
                level++;
                current_gain.text = $"{(Ui_Manager2._amount * 1.24m) - Ui_Manager2._amount}";
                CreateApple(wholeApple, button);
                SetUnEnabled();
                SetEnabled(level);
            }
            else
            {
                CreateApple(eatenApple, button);
                StartCoroutine(GameOver());
            }
        }

        else if (level == 6)
        {
            if (button.tag != index1.ToString() &&
                button.tag != index2.ToString() &&
                button.tag != index3.ToString() &&
                button.tag != index4.ToString())
            {
                foreach (var arrow in arrows)
                {
                    arrow.SetActive(false);
                }
                current_gain.text = $"{(Ui_Manager2._amount * 1.24m) - Ui_Manager2._amount}";
                CreateApple(wholeApple, button);
                Ui_Manager.account.Amount += Ui_Manager2._amount * 11.19m;
                StartCoroutine(GameOver());
            }
            else
            {
                CreateApple(eatenApple, button);
                StartCoroutine(GameOver());
            }
        }
    }

    void MoveArrows()
    {
        foreach (var arrow in arrows)
        {
            arrow.transform.position = new Vector2(arrow.transform.position.x,
                arrow.transform.position.y + 0.84f);
        }
    }

    void CreateApple(GameObject apple, Button button)
    {
        if (apple.tag == "WholeApple")
        {
            Instantiate(wholeApple, new Vector2(button.transform.position.x,
                    button.transform.position.y), Quaternion.identity);
        }
        else if (apple.tag == "EatenApple")
        {
            Instantiate(eatenApple, new Vector2(button.transform.position.x,
                    button.transform.position.y), Quaternion.identity);
        }
    }

    void SetEnabled(int level)
    {
        if (level == 1)
        {
            for (int i = 5; i < 10; i++)
            {
                buttons[i].enabled = true;
            }
        }
        else if (level == 2)
        {
            for (int i = 10; i < 15; i++)
            {
                buttons[i].enabled = true;
            }
        }
        else if (level == 3)
        {
            for (int i = 15; i < 20; i++)
            {
                buttons[i].enabled = true;
            }
        }
    }

    void SetUnEnabled()
    {
        foreach (var button in buttons)
        {
            button.enabled = false;
        }
    }

    void LoadRateScene()
    {
        //EditorUtility.DisplayDialog("Поражение", "Попробуйте еще раз!", "OK");
        SceneManager.LoadScene(2);
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.6f);
        LoadRateScene();
    }
}
