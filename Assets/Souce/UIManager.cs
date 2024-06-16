using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject addMenuPanel;
    public GameObject removeMenuPanel;

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        addMenuPanel.SetActive(false);
        removeMenuPanel.SetActive(false);
    }

    public void ShowAddMenu()
    {
        mainMenuPanel.SetActive(false);
        addMenuPanel.SetActive(true);
        removeMenuPanel.SetActive(false);
    }

    public void ShowRemoveMenu()
    {
        mainMenuPanel.SetActive(false);
        addMenuPanel.SetActive(false);
        removeMenuPanel.SetActive(true);
    }
}
