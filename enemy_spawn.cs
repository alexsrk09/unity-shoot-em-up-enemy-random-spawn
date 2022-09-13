using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawn : MonoBehaviour
{
    public GameObject enemies;
    public float TiempoCreacion = 2f;
    public float RangoCreacion = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("Crear",0.0f,TiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Crear(){
        Vector2 SpawnPos = new Vector2 (0,0);
        SpawnPos = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPos = new Vector2 (SpawnPos.x,SpawnPos.y);
        
        GameObject enemy = Instantiate (enemies, SpawnPos, Quaternion.identity);
    }
}
