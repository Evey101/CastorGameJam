using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBehavior : MonoBehaviour
{
    public Vector3 startPos, endPos, currentPos;
    public Color startCol, endCol, currentColor;
    public float moveSpeed, colorSpeed;
    public bool ready, end;
    public int mode;
    public GameObject manager;

    public void Start()
    {
        
    }
    public void Update()
    {
        if (gameObject.name == "DialogueTMP")
        {
            GetComponent<TextMeshProUGUI>().color = currentColor;
        }
        else
        {
            GetComponent<Image>().color = currentColor;

        }
        GetComponent<RectTransform>().anchoredPosition = currentPos;

        if (ready)
        {
            FadeInFunction();
        }
        if(end)
        {
            FadeOut();
        }
    }
    public void FadeInFunction()
    {
        if (mode == 0)
        {
            Debug.Log("mode is 0");
            currentPos = startPos;
            currentColor = startCol;
            mode += 1;
        }
        else if( mode == 1)
        {
            Debug.Log("lerping");
            currentPos = Vector3.Lerp(currentPos, endPos, moveSpeed);
            currentColor = Color.Lerp(currentColor, endCol, colorSpeed);
            if(currentColor.a >= .9f)
            {
                Debug.Log("reset");
                ready = false;
                mode = 0;
            }
        }
    }

    public void FadeOut()
    {
        Debug.Log("Fade Out");
        currentPos = Vector3.Lerp(currentPos, startPos, .75f);
        if (gameObject.name == "TextBoxImage" && currentPos.y == -308)
        {
            mode = 0;
            ready = true;
            end = false;
            gameObject.SetActive(false);
        }
    }
}
