using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteMovimento : MonoBehaviour
{
    public float direita = 10.0f;
    public float esquerda = 10.0f;
    public float cima = 10.0f;
    public float baixo = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
           transform.position += new Vector3(direita * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           transform.position += new Vector3(esquerda * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
           transform.position += new Vector3(0.0f, cima * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           transform.position += new Vector3(0.0f, baixo * Time.deltaTime, 0.0f);
        }
    }
}
