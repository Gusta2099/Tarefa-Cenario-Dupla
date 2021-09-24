using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Gigante : MonoBehaviour
{

    public Transform player;
    public NavMeshAgent navMeshAgent;

    void Start (){
        navMeshAgent = GetComponent<NavMeshAgent> ();
    }

    void Update (){

        navMeshAgent.SetDestination(player.position);
        
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.collider.name == "Player"){
            SceneManager.LoadScene ("Die");
        }
    }
}
