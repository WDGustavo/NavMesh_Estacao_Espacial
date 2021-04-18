using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControler : MonoBehaviour
{
    //pede para colcoar o Navmesh para pegar seu conteudo
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        //pega o conteudo do navmeshagent do objeto
        agent = this.GetComponent<NavMeshAgent>();
    }
 
    
}
