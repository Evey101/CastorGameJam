using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    public Vector3 objectPos, mousePos, target;
    public Vector3 top, bottom, left, right;

    public float speed;

    public int mode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        objectPos = gameObject.GetComponent<RectTransform>().anchoredPosition;
   

        gameObject.GetComponent<RectTransform>().anchoredPosition = 
            Vector3.Lerp(objectPos, target, speed);

        switch (mode)
        {
            case 0:
                //center
                target = Vector3.zero;
                break;
            case 1:
                //up
                target = top;
                break;
            case 2:
                //down
                target = bottom;
                break;
            case 3:
                //right
                target = right;
                break;
            case 4:
                //left
                target = left;
                break;
               
        }

        //mouse detection
        if (mousePos.x >= 3)
        {
            mode = 3;
                //right
        }
        else if (mousePos.x <= -3)
        {
            mode = 4;
            //pans left
        }

        else if(mousePos.y >= 3)
        {
            mode = 1;
            //pans up
        }
        else if(mousePos.y <= -3)
        {
            mode = 2;
            //pans down
        }
        else
        {
            mode = 0;
            //stays center
        }
    }
}
