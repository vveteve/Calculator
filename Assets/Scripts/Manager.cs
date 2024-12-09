using UnityEngine;

public class Manager : MonoBehaviour
{

    public void CloseProgram() 
    {
        Debug.Log("Application.Quit was called");
        Application.Quit();
    }
}
