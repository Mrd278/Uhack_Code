using UnityEngine;
using UnityEngine.SceneManagement;

public class Furniture_Manager : MonoBehaviour
{
    public void Centre_Table()
    {
        PlayerPrefs.SetInt("Clothe_selected", 2);
        SceneManager.LoadScene(6);
    }

    public void Sofa()
    {
        PlayerPrefs.SetInt("Clothe_selected", 1);
        SceneManager.LoadScene(6);
    }

    public void Back()
    {
        SceneManager.LoadScene(1);
    }
}
