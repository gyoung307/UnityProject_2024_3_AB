using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExEnemy : MonoBehaviour
{
    public ExPlayer targetPlayer;

    //적이 플레이어에게 주는 피해량
    private int damage = 20;

    public void AttackPlayer(ExPlayer player)
    {
        player.TakeDamage(damage);
    }

    private void Update()
    {
        if(targetPlayer != null)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("공격");
                AttackPlayer(targetPlayer);
            }
        }
    }
}
