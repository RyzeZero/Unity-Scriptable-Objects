using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtt : MonoBehaviour
{
    public Enemy enemySettings;

    public string name;
    public float heatlh;
    public float speed;
    public float attack;

    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();

        anim.runtimeAnimatorController = enemySettings.animController;

        name = enemySettings.name;
        heatlh = enemySettings.heatlh;
        speed = enemySettings.speed;
        attack = enemySettings.attack;
    }
}
