using System;
using UnityEngine;
using UnityEngine.UI;

public class Comparator : MonoBehaviour
{
    [SerializeField] InputField firstNumInput;
    [SerializeField] InputField secondNumInput;
    [SerializeField] Text resultOutput;

    private string resultDefaultText;
    private double firstNum;
    private double secondNum;

    private void Start()
    {
        resultDefaultText = resultOutput.text;
    }


    private bool ConvertInputs()
    {
        try
        {
            firstNum = Convert.ToDouble(firstNumInput.text);
            secondNum = Convert.ToDouble(secondNumInput.text);
            return true;
        }
        catch {
            Debug.Log("Not a number on inputs. Result text was changed to default.");
            resultOutput.text = resultDefaultText;
            return false;
        }

    }

    public void Compare()
    {
        if (!ConvertInputs())
            return;

        if (firstNum == secondNum)
            resultOutput.text = "=";

        else if (firstNum < secondNum)
            resultOutput.text = "<";

        else if (firstNum > secondNum)
            resultOutput.text = ">";

        else
            resultOutput.text = "huh ?";
    }
}
