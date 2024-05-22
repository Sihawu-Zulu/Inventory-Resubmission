using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SELLMECHANIC : MonoBehaviour
{
    public float Offset = 3;
    public LayerMask Layer;

    public Buybutton MoneyScript;

    // Start is called before the first frame update
    public void SELL()

    {
        RaycastHit2D did = Physics2D.Raycast(transform.position, Vector2.up, Offset, Layer);
        
        if (did.collider != null)
        {
            GameObject SellItem = did.collider.gameObject;
            Destroy(SellItem);

            if (SellItem.name == "Item1(Clone)")
            {
                MoneyScript.Money += MoneyScript.Item1price;
                MoneyScript.UpdateMoney();
            }

            if (SellItem.name == "Item2(Clone)")
            {
                MoneyScript.Money += MoneyScript.Item2price;
                MoneyScript.UpdateMoney();
            }

            if (SellItem.name == "Item3(Clone)")
            {
                MoneyScript.Money += MoneyScript.Item3price;
                MoneyScript.UpdateMoney();
            }

            if (SellItem.name == "Item4(Clone)")
            {
                MoneyScript.Money += MoneyScript.Item4price;
                MoneyScript.UpdateMoney();
            }

            if (SellItem.name == "Item5(Clone)")
            {
                MoneyScript.Money += MoneyScript.Item5price;
                MoneyScript.UpdateMoney();
            }

            if (SellItem.name == "Item6(Clone)")
            {
                MoneyScript.Money += MoneyScript.Item6price;
                MoneyScript.UpdateMoney();
            }

            if (SellItem.name == "Item7(Clone)")
            {
                MoneyScript.Money += MoneyScript.Item7price;
                MoneyScript.UpdateMoney();
            }
        }
   else {
            Debug.Log("njhjkyg");

        }
    }
}

