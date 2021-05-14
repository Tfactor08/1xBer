using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;

public class StartScript : MonoBehaviour
{
    #region Start
    private float curr_time;
    private bool isEnd = true;

    public Text number_text;
    public float repeat_time = 20;
    public static int number;
    public Button[] buttons;

    void Start()
    {
        SetEnable(false);

        equal_text.text += $" ({c_equal})";
        even_text.text += $" ({c_even})";
        odd_text.text += $" ({c_odd})";

        curr_time = repeat_time * 100f;
    }
    void Update()
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
            ArrangeС();
            isEnd = false;
            SetEnable(true);
        }
    }
    #endregion

    #region Сoefficients
    public static float c_equal = 90f;
    public static float c_even = 1.94f;
    public static float c_odd = 1.94f;
    public static double c_more;
    public static double c_less;
    #endregion

    #region ButtonTexts

    public Text more_text;
    public Text less_text;
    public Text equal_text;
    public Text even_text;
    public Text odd_text;

    #endregion

    public void ArrangeС()
    {
        if (isEnd)
        {
            number = int.Parse(number_text.text);

            c_more = 100 / (100 - Convert.ToDouble(number));
            c_less = 100 / Convert.ToDouble(number);

            more_text.text += $" ({Math.Round(c_more, 2)})";
            less_text.text += $" ({Math.Round(c_less, 2)})";
        }
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
                button.enabled = false;
            }
        }
    }
}
