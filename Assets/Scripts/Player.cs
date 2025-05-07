using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private BattleManager battleManager;
    [SerializeField] private Transform goPoint;
    [SerializeField] private Transform firstPosition;
    [SerializeField] private float speed;



    private void Start()
    {
        battleManager.OnState += BattleManager_OnState;
    }

    private void BattleManager_OnState(object sender, BattleManager.OnStateEventArgs e)
    {
        
        if (e.state == BattleManager.BattleState.Attack)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(goPoint.position.x , transform.position.y), speed * Time.deltaTime);
        }
        
    }
    private void Update()
    {
    }
}
