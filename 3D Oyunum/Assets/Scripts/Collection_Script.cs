using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Collection_Script : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("total_collections", PlayerPrefs.GetInt("total_collections", 0) + 1);
            Destroy(this.gameObject);
        }
    }
}
