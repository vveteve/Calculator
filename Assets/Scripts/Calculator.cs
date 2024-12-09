using System;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
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
        catch
        {
            Debug.Log("Not a number on inputs. Result text was changed to default.");
            resultOutput.text = resultDefaultText;
            return false;
        }

    }

    public void Summate() 
    {
        if (!ConvertInputs()) 
            return;

        var result = firstNum + secondNum;
        resultOutput.text = Convert.ToString(result);
    }

    public void Subtract()
    {
        if (!ConvertInputs())
            return;

        var result = firstNum - secondNum;
        resultOutput.text = Convert.ToString(result);
    }

    public void Divide()
    {
        if (!ConvertInputs())
            return;

        var result = firstNum / secondNum;
        resultOutput.text = Convert.ToString(result);
    }

    public void Multiply()
    {
        if (!ConvertInputs())
            return;

        var result = firstNum * secondNum;
        resultOutput.text = Convert.ToString(result);
    }

}
