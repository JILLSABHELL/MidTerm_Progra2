using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public Transform prefab;
    public Transform spawnPoint;    

    public float velocidad;
    private float cont = 0;
    public float cooldown;

    void Update()
    {
        cont -= Time.deltaTime;

        if(Input.GetMouseButtonDown(1) && cont <= 0)
        {
            Disparar();
        }
    }    

    void Disparar()
    {
        Transform clon = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        clon.GetComponent<Rigidbody>().AddForce(transform.forward * velocidad);
        Destroy(clon.gameObject, 3);
        cont = cooldown;
    }
}
