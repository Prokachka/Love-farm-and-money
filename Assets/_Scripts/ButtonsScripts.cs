using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScripts : MonoBehaviour
{
    /*
     0 - ��������

    */
    public GameObject[] plants;

  public void PlantCarrot()
    {
        plants[0].SetActive(true);
    }
}
