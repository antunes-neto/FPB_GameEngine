using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInstance : MonoBehaviour
{
    public GameObject[] RespawnScene;
    public float RespawnTime;
    public float RespawnDelay;
    public int random;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RespawnRandom", RespawnTime, RespawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void RespawnRandom()
    {
        random = Random.Range(0, RespawnScene.Length);
        Instantiate(RespawnScene[random], transform.position, transform.rotation);
    }
}
