using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigos : MonoBehaviour
{
    public int vida;

    public ParticleSystem particulas;

    public void Danio(int golpe)
    {
        vida -= golpe;
        if(vida <= 0)
        {
            //particulas.Play();
            Destroy(gameObject);           
        }
    }
}
