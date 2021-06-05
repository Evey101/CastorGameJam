using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public playerBehavior script;
    public GameObject textManager;

    public void Start()
    {
        script = textManager.GetComponent<playerBehavior>();
    }
    public void VFunction()
    {
        script.pictureID = 1;
        script.display = true;
        script.startAt = 0;
        script.endAt = 1;
    }

    public void AFunction()
    {
        script.pictureID = 2;
        script.display = true;
        script.startAt = 58;
        script.endAt = 59;
    }

    public void IFunction()
    {
        script.pictureID = 3;
        script.display = true;
        script.startAt = 175;
        script.endAt = 178;
    }

    public void CBFunction()
    {
        script.pictureID = 4;
        script.display = true;
        script.startAt = 116;
        script.endAt = 116;
    }
    public void CatKnifeFunction()
    {
        script.pictureID = 5;
        script.display = true;
        script.startAt = 174;
        script.endAt = 174;
    }
    public void CatCryFunction()
    {
        script.pictureID = 6;
        script.display = true;
        script.startAt = 173;
        script.endAt = 173;
    }
    public void MagazineFunction()
    {
        script.pictureID = 7;
        script.display = true;
        script.startAt = 172;
        script.endAt = 172;
    }
}
