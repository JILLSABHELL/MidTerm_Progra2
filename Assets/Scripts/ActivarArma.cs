using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarArma : MonoBehaviour
{
    public RecogerArma recogerArma;
    public int numeroArma;

    private void Start()
    {
        recogerArma = GameObject.FindGameObjectWithTag("Player").GetComponent<RecogerArma>();
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            recogerArma.ActivarArmas(numeroArma);
            Destroy(gameObject);
        }
    }
}
