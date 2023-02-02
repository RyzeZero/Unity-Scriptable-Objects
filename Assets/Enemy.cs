using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "enemySettings", menuName = "Enemy/New Enemy")]
public class Enemy : ScriptableObject
{
    public string name;
    public float heatlh;
    public float speed;
    public float attack;

    public RuntimeAnimatorController animController;
}
