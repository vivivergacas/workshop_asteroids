using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaCima : MonoBehaviour
{
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
           transform.position += new Vector3(0.0f, velocidade * Time.deltaTime, 0.0f);
        }
    }
}
