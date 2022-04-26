using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMovement : MonoBehaviour
{
    public GameController GameController;
    public float speed;
    public float forceInY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0f, -forceInY, 0f);
        transform.position += movement * speed * Time.deltaTime;
    }
}
