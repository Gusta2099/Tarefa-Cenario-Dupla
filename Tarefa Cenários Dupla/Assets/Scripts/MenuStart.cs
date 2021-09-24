using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour
{
    public void CarregarJogo(){
        SceneManager.LoadScene("Jogo");
    }

    public void Sair(){
        Application.Quit();
    }
}
