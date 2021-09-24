using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personas : MonoBehaviour
{
    public int vida = 100;
    public string Die;

    void Awake()
    {
        transform.tag = "Player";
    }

    void Update()
    {
      if (vida <= 0){
          vida = 0;
          Morte();
      }  
    }
    void Morte(){
        SceneManager.LoadScene("Die");
    }
}
