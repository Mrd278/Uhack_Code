using UnityEngine;
using UnityEngine.SceneManagement;

public class Clothe_Manager : MonoBehaviour
{
    public void One()
    {
        PlayerPrefs.SetInt("Clothe_selected", 1);
        SceneManager.LoadScene(5);
    }

    public void Two()
    {
        PlayerPrefs.SetInt("Clothe_selected", 2);
        SceneManager.LoadScene(5);
    }

    public void Three()
    {
        PlayerPrefs.SetInt("Clothe_selected", 3);
        SceneManager.LoadScene(5);
    }

    public void Four()
    {
        PlayerPrefs.SetInt("Clothe_selected", 4);
        SceneManager.LoadScene(5);
    }

    public void back()
    {
        SceneManager.LoadScene(3);
    }
}
