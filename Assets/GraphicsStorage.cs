using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GraphicsStorage : MonoBehaviour
{
    public Sprite[] graphics;
    public Sprite selected;
    public int id;
    public playerBehavior manager;
    public GameObject tm;
    public GameObject filter;

    public void Start()
    {
        manager = tm.GetComponent<playerBehavior>();
    }

    public void Update()
    {
        GetComponent<Image>().sprite = selected;
        if(SceneManager.GetActiveScene().name == "VScene")
        {
            
            switch(manager.txtlines)
            {
                case 3:
                    selected = graphics[0];
                    filter.gameObject.SetActive(true);
                    break;
                case 7:
                    selected = graphics[1];
                    break;
                case 12:
                    selected = graphics[2];
                    break;
                case 22:
                    selected = graphics[3];
                    break;
                case 33:
                    selected = graphics[4];
                    break;
                case 36:
                    selected = graphics[5];
                    break;
                case 42:
                    selected = graphics[6];
                    break;
                case 54:
                    selected = graphics[7];
                    break;

            }
        }

        if (SceneManager.GetActiveScene().name == "AScene")
        {
            switch (manager.txtlines)
            {
                case 61:
                    selected = graphics[0];
                    filter.gameObject.SetActive(true);
                    break;
                case 66:
                    selected = graphics[1];
                    break;
                case 70:
                    selected = graphics[2];
                    break;
                case 76:
                    selected = graphics[3];
                    break;
                case 97:
                    selected = graphics[4];
                    break;
            }
        }

        if (SceneManager.GetActiveScene().name == "CBScene")
        {
            switch(manager.txtlines)
            {
                case 118:
                    selected = graphics[0];
                    filter.gameObject.SetActive(true);
                    break;
                case 121:
                    selected = graphics[1];
                    break;
                case 133:
                    selected = graphics[2];
                    break;
                case 142:
                    selected = graphics[3];
                    break;
                case 149:
                    selected = graphics[4];
                    break;
                case 151:
                    selected = graphics[5];
                    break;
                case 161:
                    selected = graphics[6];
                    break;
            }
        }
    }
}
