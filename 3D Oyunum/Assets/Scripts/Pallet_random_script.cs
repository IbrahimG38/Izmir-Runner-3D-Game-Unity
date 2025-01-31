using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pallet_random_script : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] difficults;
    public bool isDefault;
    
    void Start()
    {
        if (!isDefault)
        {
            int random_value = Random.Range(0, difficults.Length);

            difficults[random_value].gameObject.SetActive(true);
        }
      
    }
}
