using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public RectTransform panelTranform;

    public float moveright = 10000f;

    public float moveleft = -30000f;

    public float MovePanelleft; 

    public float MovePanelright;

    void Start()
    {
        Button LeftButton = GameObject.Find("LeftButton").GetComponent<Button>();

        LeftButton.onClick.AddListener(MovePanelLeft);

        Button RightButton = GameObject.Find("RightButton").GetComponent<Button>();

        RightButton.onClick.AddListener(MovePanelRight);


    }

    public void MovePanelLeft()
    {
        panelTranform.Translate(Vector3.left * moveleft * Time.deltaTime);
    }

    public void MovePanelRight()
    {
        panelTranform.Translate(Vector3.left * moveright * Time.deltaTime);

    }

    public void MyFunction()
    {
        Debug.Log("Button clicked!");
    }









}
