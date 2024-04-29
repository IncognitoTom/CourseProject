using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RivenCollection : MonoBehaviour
{


    private int Riven = 0;


    public TextMeshProUGUI NumRiven;


    private void OnTriggerEnter(Collider other)
    {

        if(other.transform.tag == "Riven")
        {
            Riven++;
            NumRiven.text = "Riven plushies: " + Riven.ToString();
            Debug.Log(Riven);
            Destroy(other.gameObject);
        }
    }


}
