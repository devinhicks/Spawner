using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Drone m_Drone;
    public Sniper m_Sniper;
    public Bully m_Bully;
    public EnemySpawner m_Spawner;

    private Enemy m_Spawn;
    private int m_IncrementorDrone = 0;
    private int m_IncrementorSniper = 0;
    private int m_IncrementorBully = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Drone);

            m_Spawn.name = "Drone_Clone_" + ++m_IncrementorDrone;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorDrone * 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Sniper);

            m_Spawn.name = "Sniper_Clone_" + ++m_IncrementorSniper;
            m_Spawn.transform.Translate(new Vector3(1,0,1) * m_IncrementorSniper * 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Bully);

            m_Spawn.name = "Bully_Clone_" + ++m_IncrementorBully;
            m_Spawn.transform.Translate(new Vector3(-1,0,1) * m_IncrementorBully * 1.5f);
        }
    }
}
