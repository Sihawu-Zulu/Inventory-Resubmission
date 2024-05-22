using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Buybutton : MonoBehaviour
{
    public List<GameObject> itemList = new List<GameObject>();

    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5;
    public GameObject Item6;
    public GameObject Item7;
    public GameObject Item8;
    public GameObject Item9;    
    public GameObject Item10;

    public Transform targetPosition;
    public Transform targetPosition2;
    public Transform targetPosition3;
    public Transform targetPosition4;
    public Transform targetPosition5;
    public Transform targetPosition6;
    public Transform targetPosition7;
    public Transform targetPosition8;
    public Transform targetPosition9;
    public Transform targetPosition10;


    
    public Transform newPosition;
    public Transform newPosition2;
    public Transform newPosition3;
    public Transform newPosition4;
    public Transform newPosition5;
    public Transform newPosition6;
    public Transform newPosition7;
    public Transform newPosition8;
    public Transform newPosition9;
    public Transform newPosition10;


    private Vector3 size = new Vector3(0.35f, 0.35f, 0);

    


    public float movespeed = 20f;

    public TextMeshProUGUI moneyText;

    private float Itemprice;

    public float Item1price = -10;
    public float Item2price = 20;
    public float Item3price = 30;
    public float Item4price = 5;
    public float Item5price = 15;
    public float Item6price = 20;
    public float Item7price = 10;
    public float Item8price = 50;
    public float Item9price = 40;
    public float Item10price = 25;
    
    

    public float Money = 100;


    

    public void MoveObjectToNewPosition()
    {
        Debug.Log("KaChing");
        if (Money >= Item1price)
        {
           

            GameObject Item1Clone = Instantiate(Item1, newPosition.position, Quaternion.identity, newPosition);

            Item1Clone.transform.localScale = size;
            Money -= Item1price;
            UpdateMoney();

        }
        
        
    }

    public void MoveObjectToNewPosition2()
    {

        Debug.Log("KaChing");
        if (Money >= Item2price)
        {
            Money -= Item2price;
            UpdateMoney();

            GameObject Item2Clone = Instantiate(Item2, newPosition2.position, Quaternion.identity, newPosition2);

            Item2Clone.transform.localScale = size;
        }
    }

    public void MoveObjectToNewPosition3()
    {
        Debug.Log("KaChing");
        if (Money >= Item3price)
        {
            Money -= Item3price;
            UpdateMoney();

            GameObject Item3clone = Instantiate(Item3, newPosition3.position, Quaternion.identity, newPosition3);

            Item3clone.transform.localScale = size;
        }
    }

    public void MoveObjectToNewPosition4()
    {
        Debug.Log("KaChing");
        if (Money >= Item4price)
        {
            Money -= Item4price;
            UpdateMoney();

            GameObject Item4clone = Instantiate(Item4, newPosition4.position, Quaternion.identity, newPosition4);

            Item4clone.transform.localScale = size;
        }
    }

    public void MoveObjectToNewPosition5()
    {
        Debug.Log("KaChing");
        if (Money >= Item5price)
        {
            Money -= Item5price;
            UpdateMoney();

            GameObject Item5clone = Instantiate(Item5,newPosition5.position, Quaternion.identity, newPosition5);

            Item5clone.transform.localScale = size;
        }
    }

    public void MoveObjectToNewPosition6()
    {
        Debug.Log("KaChing");
        if (Money >= Item6price)
        {
            Money -= Item6price;
            UpdateMoney();

            GameObject Item6clone = Instantiate(Item6,newPosition6.position, Quaternion.identity, newPosition6);

            Item6clone.transform.localScale = size;
        }
    }

    public void MoveObjectToNewPosition7()
    {
        if (Money >= Item7price)
        {
            Debug.Log("KaChing");
            Money -= Item7price;
            UpdateMoney();

            GameObject Item7clone = Instantiate(Item7,newPosition7.position, Quaternion.identity, newPosition7);

            Item7clone.transform.localScale = size;
        }
    }

    public void MoveObjectToNewPosition8()
    {
        Debug.Log("KaChing");
        if (Money >= Item8price)
        {
            Money -= Item8price;
            UpdateMoney();

            GameObject Item8clone = Instantiate(Item8,newPosition8.position, Quaternion.identity, newPosition8);

            Item8clone.transform.localScale = size;
        }
    }

    public void MoveObjectToNewPosition9()
    {
        Debug.Log("KaChing");
        if (Money >= Item9price)
        {
            Money -= Item9price;
            UpdateMoney();

            GameObject Item9clone = Instantiate(Item9,newPosition9.position, Quaternion.identity, newPosition9);

            Item9clone.transform.localScale = size;
        }
    }

    public void MoveObjectToNewPosition10()
    {
        Debug.Log("KaChing");
        if (Money >= Item10price)
        {
            Money -= Item10price;
            UpdateMoney();

            GameObject Item10clone = Instantiate(Item10, newPosition10.position, Quaternion.identity, newPosition10);

            Item10clone.transform.localScale = size;
        }
    }

    public void BuyOnClick()
    {
        /*bool itemPurchased = false;

        if (Money >= Itemprice)
        {
            Money -= Item1price;
            itemPurchased = true;
            
        }
        if (Money >= Itemprice)
        {
            Money -= Item2price;
            itemPurchased = true;
            
        }
        if (Money >= Itemprice)
        {
            Money -= Item3price;
            itemPurchased = true;
            
        }
        if (Money >= Itemprice)
        {
            Money -= Item4price;
            itemPurchased = true;
            
        }
        if (Money >= Itemprice)
        {
            Money -= Item5price;
            itemPurchased = true;
           
        }
        if (Money >= Itemprice)
        {
            Money -= Item6price;
            itemPurchased = true;
           
        }
        if (Money >= Itemprice)
        {
            Money -= Item7price;
            itemPurchased = true;
            
        }
        if (Money >= Itemprice)
        {
            Money -= Item8price;
            itemPurchased = true;
           
        }
        if (Money >= Itemprice)
        {
            Money -= Item9price;
            itemPurchased = true;
            
        }
        if (Money >= Itemprice)
        {
            Money -= Item10price;
            itemPurchased = true;
        }

        UpdateMoney();

        
        */




    }

    public void UpdateMoney()
    {
        moneyText.text = "R" + Money;
    }

    // Start is called before the first frame update
    void Start()
    {
        itemList.Add(Item1);
        itemList.Add(Item2);
        itemList.Add(Item3);
        itemList.Add(Item4);
        itemList.Add(Item5);
        itemList.Add(Item6);
        itemList.Add(Item7);
        itemList.Add(Item8);
        itemList.Add(Item9);
        itemList.Add(Item10);
        UpdateMoney();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
