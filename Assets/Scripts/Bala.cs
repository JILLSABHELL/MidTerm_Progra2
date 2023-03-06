using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody body;
    public float velocidad;
    public int da�oBala;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddForce(transform.forward * velocidad);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<VidaEnemigos>().Danio(da�oBala);
            Destroy(this.gameObject);
        }
        
    }
}
