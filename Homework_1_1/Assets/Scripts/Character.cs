using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]

    public float HP = 100;
    private bool isDead = false;
    

    void Update()
    {
        GetDamage(10 * Time.deltaTime);
    }

    void GetDamage(float damage)
    {
        if (isDead) return;
        HP -= damage;
            if (HP <= 0)
        {
            HP = 0;
            Debug.Log("Character is dead");
            Destroy(gameObject);
        }
    }
}
