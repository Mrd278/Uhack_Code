using UnityEngine;
using UnityEngine.SceneManagement;


public class Sizecontroller : MonoBehaviour
{
    public void Small()
    {
        PlayerPrefs.SetFloat("height", 1.5f);
        PlayerPrefs.SetFloat("width", 2f);
        SceneManager.LoadScene(6);
    }

    public void Medium()
    {
        PlayerPrefs.SetFloat("height", 2f);
        PlayerPrefs.SetFloat("width", 2f);
        SceneManager.LoadScene(6);
    }

    public void Large()
    {
        PlayerPrefs.SetFloat("height", 2.5f);
        PlayerPrefs.SetFloat("width", 2f);
        SceneManager.LoadScene(6);
    }

    public void xtraLarge()
    {
        PlayerPrefs.SetFloat("height", 3f);
        PlayerPrefs.SetFloat("width", 3f);
        SceneManager.LoadScene(6);
    }
}
