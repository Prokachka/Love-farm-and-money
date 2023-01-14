using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScripts : MonoBehaviour
{
    /*
     0 - морковка

    */
    public GameObject[] plants;
    public GameObject buttons;

  public void PlantCarrot()
    {
        plants[0].SetActive(true);
        buttons.SetActive(false);
    }
}
