using System.Collections;
using System.Collections.Generic;

public class Enemies
{
    public string _enemyName {get; set;}
    public float _health {get; set;}
    private float _damage {get; set;}
    public float _takeDamage;
    public bool _isTakingDamage;
    public bool _enemyDead;

    public void Start()
    {
        Enemy = new Enemy("Hostile", 100.0, 15.0);
        _health = 100.0f;
        _damage = 10.0f;
    }

    public void Enemy(string enemyName, float enemyHealth, float enemyDamage)
    {
        enemyName = _enemyName;
        enemyHealth = _health;
        enemyDamage = _damage;
    }

    public void Update()
    {
        if (_isTakingDamage == true)
        {
            _health -= _takeDamage;
        }
        else if (_health <= 0)
        {
            _enemyDead = true;
        }
    }
}