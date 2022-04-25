using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemento_Jogador : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float velocidadeHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float velocidadeX = (horizontal * this.velocidadeHorizontal);
         this.rigidbody.velocity = new Vector2(velocidadeX,0);
    }
}
