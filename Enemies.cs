using System.Collections;
using System.Collections.Generic;

public class Enemies
{
    public string _enemyName {get; set;}
    public float _health {get; set;} 
    public float _armourHealth {get; set;} 
    public float _damage {get; set;}
    public DamageTypes _damageType {get; set;} // WIP: Type of damage, adds modifier based on target health and armour
    public float _range; // Determines how far enemy can shoot, 0 means it cannot use ranged attacks


    public float _takeDamageAmount; // Amount of damage taken
    public bool _isTakingDamage; // Is enemy taking damage?
    public bool _enemyDead; // If health reaches 0, enemy is dead

    /*public void Start()
    {
        Enemy = new Enemy("Hostile", 100.0, 15.0, 30.0f);
    }*/
    
    public void Enemy(string enemyName, float enemyHealth, float armourHealth, float enemyDamage, DamageTypes damageType, float range)
    {
        enemyName = _enemyName;
        enemyHealth = _health;
        armourHealth = _armourHealth;
        enemyDamage = _damage;
        damageType = _damageType;
        range = _range;
    }

    public void Update()
    {
        if (_isTakingDamage == true)
        {
            _health -= _takeDamageAmount;
        }
        else if (_health <= 0)
        {
            _enemyDead = true;
        }
        else
        {
            _isTakingDamage = false;
        }
    }
}