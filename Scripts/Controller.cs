using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public void Furniture()
    {
        PlayerPrefs.SetString("Clothes", "Furniture");
        SceneManager.LoadScene(2);
    }

    public void Clothes()
    {
        SceneManager.LoadScene(3);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
