using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxScript : MonoBehaviour
{

    private float _health = 100f;

    public void GetDamage(float damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Debug.Log("Enemy is dead!");
            Destroy(gameObject);
        }
        
        Debug.Log($"Player Health = {_health}");
    }
}
