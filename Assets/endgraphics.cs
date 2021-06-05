using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class endgraphics : MonoBehaviour
{
    public Sprite[] graphics;
    public Sprite selected;
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().sprite = selected;
        selected = graphics[id];
        if(id != 2 && Input.GetMouseButtonDown(0))
        {
            id += 1;
        }
        if(id == 2 && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("BedroomScene");
        }
    }
}
