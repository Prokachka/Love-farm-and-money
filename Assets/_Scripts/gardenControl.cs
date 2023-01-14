using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class gardenControl : MonoBehaviour
{
    public GameObject glow;
    public GameObject text;
    public GameObject buttons;
   private bool _isPlanted = false;
    

   
    private void OnMouseEnter()
    {
        glow.SetActive(true);
        text.SetActive(true);
    }

    private void OnMouseExit()
    {
        glow.SetActive(false);
        text.SetActive(false);
    }

    private void OnMouseDown()
    {
        if(!_isPlanted)
        {
            buttons.SetActive(true);
        }
    }

   public void Planted()
    {
        if (_isPlanted)
        {
            _isPlanted= false;
        }
        _isPlanted= true;
    }
}
