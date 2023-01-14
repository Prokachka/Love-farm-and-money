using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Plants : MonoBehaviour
{
    [SerializeField] protected float _growthTime;
    [SerializeField] protected float _sellPrise;
    [SerializeField] protected float _buyPrise;
    [SerializeField] protected GameObject[] _growthFase;
    [SerializeField] protected gardenControl gardenControl;

    protected void Start()
    {
        gardenControl.Planted();
        _growthFase[0].SetActive(true);
        StartCoroutine("Growth");
    }
    

    private IEnumerator Growth()
    {
        yield return new WaitForSeconds(_growthTime / 3);
        _growthFase[0].SetActive(false);
        _growthFase[1].SetActive(true);
       yield return  new WaitForSeconds(_growthTime / 3);
        _growthFase[1].SetActive(false);
        _growthFase[2].SetActive(true);
        yield return null;
    }
}
