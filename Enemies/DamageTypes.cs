using System.Collections;
using System.Collections.Generic;

public class DamageTypes // WIP
{
    public DamageTypes _slash {get; set;}
    public DamageTypes _pierce {get; set;}

    public void DamageModifiers()
    {
        _slash = Enemies._damage * 1.5f;
    }
}