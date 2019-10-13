using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Manager : MonoBehaviour
{
    private string result;
    private int shirt_number;
    public GameObject[] obj;

    void Start()
    {
        result = PlayerPrefs.GetString("Clothes");
        shirt_number = PlayerPrefs.GetInt("Clothe_selected");

        Debug.Log("Clothes: " + result + " Clothe Selected: " + shirt_number);
        
        if(result == "Shirt" && shirt_number == 1)
        {
            for(int i = 0; i<obj.Length; i++)
            {
                if(obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[0].SetActive(true);
            }
        }

        if (result == "Shirt" && shirt_number == 2)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[1].SetActive(true);
            }
        }

        if (result == "Shirt" && shirt_number == 3)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[2].SetActive(true);
            }
        }

        if (result == "Shirt" && shirt_number == 4)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[3].SetActive(true);
            }
        }

        if (result == "Pant" && shirt_number == 1)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[4].SetActive(true);
            }
        }

        if (result == "Pant" && shirt_number == 2)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[5].SetActive(true);
            }
        }

        if (result == "Pant" && shirt_number == 3)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[6].SetActive(true);
            }
        }

        if (result == "Pant" && shirt_number == 4)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[7].SetActive(true);
            }
        }

        if (result == "Formal" && shirt_number == 1)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[8].SetActive(true);
            }
        }

        if (result == "Formal" && shirt_number == 2)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[9].SetActive(true);
            }
        }

        if (result == "Formal" && shirt_number == 3)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[10].SetActive(true);
            }
        }

        if (result == "Formal" && shirt_number == 4)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[11].SetActive(true);
            }
        }

        if (result == "Dress" && shirt_number == 1)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[12].SetActive(true);
            }
        }

        if (result == "Dress" && shirt_number == 2)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[13].SetActive(true);
            }
        }

        if (result == "Dress" && shirt_number == 3)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[14].SetActive(true);
            }
        }

        if (result == "Dress" && shirt_number == 4)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[15].SetActive(true);
            }
        }

        if (result == "Furniture" && shirt_number == 1)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[16].SetActive(true);
            }
        }

        if (result == "Furniture" && shirt_number == 2)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].gameObject.activeSelf)
                {
                    obj[i].SetActive(false);
                }
                obj[17].SetActive(true);
            }
        }
    }
}
