using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CuboBueno : MonoBehaviour
{
    public int vida;   
    
    public void Danio(int golpe)
    {
        vida -= golpe;
        if (vida <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
