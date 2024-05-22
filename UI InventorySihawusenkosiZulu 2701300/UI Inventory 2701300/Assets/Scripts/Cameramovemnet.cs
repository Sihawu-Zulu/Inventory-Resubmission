using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovemnet : MonoBehaviour
{
    // Start is called before the first frame update
   public void LeftArrow()
    {
        transform.position = new Vector3(0,0,0);
    }
    public void RightArrow() 
    {
        transform.position = new Vector3(11.85f,0,0);
    }
}
