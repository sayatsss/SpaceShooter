using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyShip;
    [SerializeField] private int numberOfEnemyShip;

    private void Start()
    {
        for(int i=0;i<numberOfEnemyShip;i++)
        {
            Instantiate(enemyShip);
        }
    }

}
