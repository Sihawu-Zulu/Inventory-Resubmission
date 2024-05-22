using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Storagebutton : MonoBehaviour
{
    public GameObject objectToDestroy;

    public GameObject Gate1;
    public float Gate1price = 70;
    public Buybutton MoneyScript;

    public void DestroyObjectOnClick()
    {
        
        if (objectToDestroy != null)
        {
            MoneyScript.Money -= Gate1price;
            Destroy(Gate1);
            MoneyScript.UpdateMoney();
        }
    }

    private Storagebutton button;

    void Start() 
    {
       
    }

    void Update()
    {
        
    }



}
