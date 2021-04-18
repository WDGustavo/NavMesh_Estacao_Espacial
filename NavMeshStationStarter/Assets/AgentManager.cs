using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    //cria a lista
    GameObject[] agents;
    // Start is called before the first frame update
    void Start()
    {
        //acha o gameobject atraves da tag dele
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {
        //faz a ação quando apertar o botão do mouse
        if (Input.GetMouseButtonDown(0)) 
        {
            //cria o raycast
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                //seta o destino do ogjeto quando clicar com o mouse
                foreach (GameObject a in agents)
                    a.GetComponent<AIControler>().agent.SetDestination(hit.point);
            }
        }

    }
}
