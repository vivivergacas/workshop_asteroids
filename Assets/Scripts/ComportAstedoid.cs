using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportAstedoid : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float velocidadeMaxima = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidbody.velocity = direcao;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
        Destroy(outro.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
