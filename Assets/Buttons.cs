using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour {

    public void onStartButton()
    {
        SceneManager.LoadScene("Main");
    }

    public void onQuitButton()
    {
        Application.Quit();
    }

    public void clickWinRound()
    {
        SceneManager.LoadScene("WinRound");
    }

    public void clickBack()
    {
        SceneManager.LoadScene("Interface");
    }
    
    public void clickToggle()
    {

    }
}
