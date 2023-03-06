using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayGun : MonoBehaviour
{
    public Transform shootPoint;
    public int damage;
    public int force;    

    private RaycastHit hit;
    public float rango;


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(shootPoint.position,shootPoint.forward, out hit, rango))
            {
                if(hit.transform.tag == "Enemy")
                {                    
                    hit.transform.GetComponent<VidaEnemigos>().Danio(damage);
                }

                if(hit.transform.tag == "Buenos")
                {
                    hit.transform.GetComponent<CuboBueno>().Danio(damage);
                }
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * force);
            }
        }
    }
}
