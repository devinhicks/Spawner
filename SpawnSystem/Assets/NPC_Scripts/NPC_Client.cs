using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NPC_Client : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
        }
    }
}
