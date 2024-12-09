using UnityEngine;

public class ChangePanels : MonoBehaviour
{
    [SerializeField] private GameObject calculator;
    [SerializeField] private GameObject comparator;

    private GameObject currentPanel;

    public void Start()
    {
        if (calculator.activeSelf && comparator.activeSelf) 
        {
            comparator.SetActive(false);
            currentPanel = calculator;
            Debug.Log("Both panels was active. Setted comparator to inactive.");
            return;
        }

        if (calculator.activeSelf)
            currentPanel = calculator;

        else if (comparator.activeSelf)
            currentPanel = comparator;
    }

    public void ChangePanel(GameObject panel) 
    {

        if (panel == currentPanel) 
        {
            Debug.Log("Tried to change panel to current panel. Nothing was changed.");
            return;
        }

        currentPanel.SetActive(false);
        panel.SetActive(true);
        currentPanel = panel;

    }
}
