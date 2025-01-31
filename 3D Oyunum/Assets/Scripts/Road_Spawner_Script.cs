using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_Spawner_Script : MonoBehaviour
{

    public static Road_Spawner_Script instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    [SerializeField] GameObject Road_Tile;
    [SerializeField] Transform spawn_pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Spawn_Road()
    {
        Instantiate(Road_Tile, spawn_pos.position, Quaternion.identity);
        spawn_pos.position = new Vector3(spawn_pos.transform.position.x, spawn_pos.transform.position.y, spawn_pos.transform.position.z + 648.87f); //2.par�a 58 konum sonras� ba�lad��� i�in her par�aya +58 ilave ederek yol ekler (par�alar aras� de�erim 648.87)
    }

    private void onDestroy()
    {
        Destroy(instance);
    }
  
}
