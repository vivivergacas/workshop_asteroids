using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esquerda : MonoBehaviour
{
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           transform.position += new Vector3(velocidade * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
