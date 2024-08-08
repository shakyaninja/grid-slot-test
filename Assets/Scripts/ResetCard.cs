using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCard : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<SlotItem>() != null)
        {
            collision.GetComponent<SlotItem>().ResetCard();
        }        
    }

}
