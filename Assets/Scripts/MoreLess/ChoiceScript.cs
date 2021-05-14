using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChoiceScript : MonoBehaviour
{
    private float curr_time;
    private float repeat_time = 20;
    private bool isButtonClick = false;

    public Button button;
    public Text number_text;
    public GameObject back;
    public Button[] buttons;

    void Start()
    {
        curr_time = repeat_time * 100f;
    }

    public void OnButtonClick(Button button)
    {
        isButtonClick = true;

        foreach (var _button in buttons)
        {
            _button.enabled = false;
        }
    }

    void Update()
    {
        if (isButtonClick)
        {
            if (repeat_time > 0)
            {
                curr_time -= Time.deltaTime;
                number_text.text = UnityEngine.Random.Range(0, 100).ToString();
                Thread.Sleep(75);
                repeat_time--;
            }
            else
            {
                isButtonClick = false;
                CheckWin();
            }
        }
    }

    void CheckWin()
    {
        int firts_number = StartScript.number;
        int second_number = int.Parse(number_text.text);

        switch (button.tag)
        {
            case "MoreButton":
                if (second_number > firts_number)
                {
                    AddAmount(StartScript.c_more);
                    GameOver(true);
                }
                else
                    GameOver(false);
                break;
            case "LessButton":
                if (second_number < firts_number)
                {
                    AddAmount(StartScript.c_less);
                    GameOver(true);
                }
                else
                    GameOver(false);
                break;

            case "EqualButton":
                if (second_number == firts_number)
                {
                    AddAmount(StartScript.c_equal);
                    GameOver(true);
                }
                else
                    GameOver(false);
                break;
            case "EvenButton":
                if (second_number % 2 == 0)
                {
                    AddAmount(StartScript.c_even);
                    GameOver(true);
                }
                else
                    GameOver(false);
                break;
            case "OddButton":
                if (second_number % 2 != 0)
                {
                    AddAmount(StartScript.c_odd);
                    GameOver(true);
                }
                else
                    GameOver(false);
                break;
        }
        StartCoroutine(LoadRateScene());
        Math.Round(Ui_Manager.account.Amount);
    }

    void AddAmount(double c)
    {
        Ui_Manager.account.Amount += Math.Round(
                        Convert.ToDecimal(c) * Convert.ToDecimal(Ui_Manager2._amount), 2);
    }

    void GameOver(bool win)
    {
        if (win)
            back.GetComponent<Renderer>().material.color = Color.green;
        else
            back.GetComponent<Renderer>().material.color = Color.red;
    }

    IEnumerator LoadRateScene()
    {
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(6);
    }

    public void SetEnable(bool enable)
    {
        if (enable)
        {
            foreach (var button in buttons)
            {
                button.enabled = true;
            }
        }
        else
        {
            foreach (var button in buttons)
            {
                print(2);
                button.enabled = false;
            }
        }
    }
}
