using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SizeChanger : MonoBehaviour
{
    public GameObject[] Tshirt;

    // Start is called before the first frame update
    void Start()
    {
        float height = PlayerPrefs.GetFloat("height");
        float width = PlayerPrefs.GetFloat("width");
        Debug.Log("height: " + height + " width: " + width);
        for(int i = 0; i< Tshirt.Length; i++)
        {
            Tshirt[i].transform.localScale = new Vector3(width, height, 1f);
        }
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
