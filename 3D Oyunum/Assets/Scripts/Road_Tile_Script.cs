using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_Tile_Script : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.z > transform.position.z + 420f) //karakter yeni par�adayken 405 konuma geldi�inde bir �nceki par�ay� yok eder
        {
            Road_Spawner_Script.instance.Spawn_Road();
            Destroy(this.gameObject); //ge�ilen yolu yok eden kod
        }
    }
}
