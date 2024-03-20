using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExPlayer : MonoBehaviour
{
    private int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("플레이어 체력 : " + health);

        if(health <= 0)
        {
            Die();
        }

    }

    private void Die()
    {
        Debug.Log("플레이어 사망");
    }
}
