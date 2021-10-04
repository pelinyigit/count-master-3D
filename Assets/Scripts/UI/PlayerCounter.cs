using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCounter : MonoBehaviour
{
    //public GameObject enemyParent1;
    //public GameObject enemyParent2;

    //public Text enemyCount1;
    //public Text enemyCount2;
    public Text playerCount;

    //private int currentEnemyCount1 = 10;
    //private int currentEnemyCount2 = 40;

    //private int maxEnemyCount1;
    //private int maxEnemyCount2;

    private int currentPlayerCount = 1;
    private int maxPlayerCount;

    private void Start()
    {
        //currentEnemyCount1 = maxEnemyCount1;
        //currentEnemyCount2 = maxEnemyCount2;

        //enemyCount1.text = enemyCount1.ToString();
        //enemyCount2.text = enemyCount2.ToString();

        currentPlayerCount = maxPlayerCount;
        playerCount.text = maxPlayerCount.ToString();

    }

    void Update()
    {
       // CountEnemies();
        CountPlayers();
    }

    //void CountEnemies()
    //{
    //    maxEnemyCount1 = enemyParent1.transform.childCount -1;
    //    maxEnemyCount2 = enemyParent2.transform.childCount -1;

    //    enemyCount1.text = maxEnemyCount1.ToString();
    //    enemyCount2.text = maxEnemyCount2.ToString();
    //}

    void CountPlayers()
    {
        maxPlayerCount = GameObject.FindGameObjectsWithTag("Player").Length;
        playerCount.text = maxPlayerCount.ToString();
    }
}
