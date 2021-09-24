using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Crono : MonoBehaviour
{
    public Text CronometroText;
    private float tempoAgora;

    void Start(){
        tempoAgora = 0;
    }

    void Update(){
        tempoAgora += Time.deltaTime;
        CronometroText.text = tempoAgora.ToString("F2");
        if(tempoAgora > 60.0){
            SceneManager.LoadScene ("Victory");
        }
    }
}
