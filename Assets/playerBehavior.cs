using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class playerBehavior : MonoBehaviour
{
    public TextBehavior script;
    public GameObject txtStore;
    public DialogueStorage ds;
    public GameObject txt, txtbox, SceneTrans;
    public int mode, txtlines, startAt, endAt, pictureID;
    public bool nextText, display;
    public Image CloseUp;
    public Sprite[] pictures;

    // Start is called before the first frame update
    void Start()
    {
        ds = txtStore.GetComponent<DialogueStorage>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(display)
        {
            Debug.Log("displayed");
            DisplayFunction();
            txt.GetComponent<TextMeshProUGUI>().text = ds.arr[txtlines];
            nextText = txt.GetComponent<TextBehavior>().ready;
        }

    }

    public void DisplayFunction()
    {
        if (mode == 0)
        {
            if(SceneManager.GetActiveScene().name == "BedroomScene")
            {
                if (pictureID == 1 || pictureID == 2 || pictureID == 3 || pictureID == 4 ||
                    pictureID == 5 || pictureID == 6 || pictureID == 7)
                {
                    CloseUp.gameObject.SetActive(true);
                    CloseUp.GetComponent<Image>().sprite = pictures[pictureID];
                }
            }
            txtbox.gameObject.SetActive(true);
            txtlines = startAt;
            mode += 1;
        }
        
        if(mode == 1)
        {
            if (txtlines != endAt && Input.GetMouseButtonDown(0))
            {
                
                if (txtlines < endAt && nextText == false)
                {
                    Debug.Log("mouse detected");
                    txtlines += 1;
                    txt.GetComponent<TextBehavior>().ready = true;
                }
            }
            else if(txtlines == endAt && Input.GetMouseButtonDown(0))
            {
                if(pictureID == 1 || pictureID == 2 || pictureID == 3 || pictureID == 4)
                {
                    SceneTrans.gameObject.SetActive(true);
                    switch(pictureID)
                    {
                        case 1:
                            SceneTrans.GetComponent<SceneTransition>().nextScene = "VScene";
                            break;
                        case 2:
                            SceneTrans.GetComponent<SceneTransition>().nextScene = "AScene";
                            break;
                        case 3:
                            SceneTrans.GetComponent<SceneTransition>().nextScene = "IScene";
                            break;
                        case 4:
                            SceneTrans.GetComponent<SceneTransition>().nextScene = "CBScene";
                            break;
                    }
                }
                else
                {
                    if(SceneManager.GetActiveScene().name == "BedroomScene")
                    {
                        CloseUp.gameObject.SetActive(false);
                    }
                    else
                    {
                        SceneManager.LoadScene("BedroomScene");
                    }
                    
                    pictureID = 0;
                    Debug.Log("end of line");
                    txtbox.GetComponent<TextBehavior>().end = true;
                    mode = 0;
                    display = false;
                }
                
            }
        }
        
    }
}
