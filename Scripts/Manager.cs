using UnityEngine;

public class Manager : MonoBehaviour
{
    private string result;
    public GameObject[] Clothes_list;

    public void Start()
    {
        result = PlayerPrefs.GetString("Clothes");

        if (result == "Shirt")
        {
            for (int j = 0; j < Clothes_list.Length; j++)
            {
                if (Clothes_list[j].gameObject.activeSelf)
                {
                    Clothes_list[j].SetActive(false);
                }
                Clothes_list[0].SetActive(true);
            }
        }
        else if (result == "Pant")
        {
            for (int j = 0; j < Clothes_list.Length; j++)
            {
                if (Clothes_list[j].gameObject.activeSelf)
                {
                    Clothes_list[j].SetActive(false);
                }
                Clothes_list[1].SetActive(true);
            }
        }
        else if (result == "Formal")
        {
            for (int j = 0; j < Clothes_list.Length; j++)
            {
                if (Clothes_list[j].gameObject.activeSelf)
                {
                    Clothes_list[j].SetActive(false);
                }
                Clothes_list[2].SetActive(true);
            }
        }
        else
        {
            for (int j = 0; j < Clothes_list.Length; j++)
            {
                if (Clothes_list[j].gameObject.activeSelf)
                {
                    Clothes_list[j].SetActive(false);
                }
                Clothes_list[3].SetActive(true);
            }
        }
    }
}
