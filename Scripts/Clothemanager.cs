using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clothemanager : MonoBehaviour
{
    public void Shirt()
    {
        SceneManager.LoadScene(4);
        PlayerPrefs.SetString("Clothes", "Shirt");
    }

    public void Pant()
    {
        SceneManager.LoadScene(4);
        PlayerPrefs.SetString("Clothes", "Pant");
    }

    public void Formal()
    {
        SceneManager.LoadScene(4);
        PlayerPrefs.SetString("Clothes", "Formal");
    }

    public void Dresses()
    {
        SceneManager.LoadScene(4);
        PlayerPrefs.SetString("Clothes", "Dress");
    }
}
