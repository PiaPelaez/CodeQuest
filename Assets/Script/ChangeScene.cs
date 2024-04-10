using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void GoToUserName()
    {

        SceneManager.LoadScene("UserName");
    }

    public void GoToMainPage()
    {

        SceneManager.LoadScene("MainPage");
    }
    public void GoToPlayer()
    {

        SceneManager.LoadScene("Player");
    }
    public void GoToLandingPage()
    {

        SceneManager.LoadScene("LandingPage");
    }
    public void GoToWelcome()
    {

        SceneManager.LoadScene("Welcome");
    }
    public void GoToSettings()
    {

        SceneManager.LoadScene("Settings");
    }


}
