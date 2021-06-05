using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string nextScene;
    public Color currentCol, startCol, endCol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().color = currentCol;
        currentCol = Color.Lerp(currentCol, endCol, .25f);

        if(currentCol == endCol)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
