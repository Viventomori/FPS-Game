using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSystem : MonoBehaviour
{
    public int power;
    public IPowerBar powerBar;
    public EnemyManager target;
    private GameObject[] enemy;

    private void Awake()
    {
        powerBar.SetPower(power);
    }

    public void MinusPower(int amount)
    {
        power -= amount;
        if(power < 0 )
        {
            power = 0;
        }

        powerBar.SetPower(power);
    }

    public void AddPower(int amount)
    {
        power += amount;
        if(power >= 100 )
        {
            power = 100;
        }
        powerBar.SetPower(power);
    }

    public void UseUlty()
    {
        if(power >= 100)
        {
            enemy = GameObject.FindGameObjectsWithTag("Enemy");
            target = FindObjectOfType<EnemyManager>();
            power = 0;
            target.AllKill();
        }
        powerBar.SetPower(power);
    }
}
