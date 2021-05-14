using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public InputField inputField;
    public Button button;

    protected internal static readonly decimal MAX = 10000;
    protected internal static readonly decimal MIN = 5;

    public void Change()
    {

        switch (button.tag)
        {
            case "MinButton":
                inputField.text = MIN.ToString();
                break;
            case "MaxButton":
                inputField.text = MAX.ToString();
                break;
            case "X2Button":
                if (int.Parse(inputField.text) <= 50)
                    inputField.text = (int.Parse(inputField.text) * 2).ToString();
                break;
            case @"X\2Button":
                if (int.Parse(inputField.text) >= 10)
                    inputField.text = (int.Parse(inputField.text) / 2).ToString();
                break;
        }
    }
}
