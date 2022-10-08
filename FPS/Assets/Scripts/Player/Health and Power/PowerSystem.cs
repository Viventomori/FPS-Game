using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSystem : MonoBehaviour
{
    [SerializeField] public int power;
    private GameObject[] enemy;

    public IPowerBar powerBar;
    public EnemyManager target;

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
            enemy = GameObject.FindGameObjectsWithTag("Enemy");//був плеер
            target = FindObjectOfType<EnemyManager>();
            power = 0;
            target.AllKill();
        }
        powerBar.SetPower(power);
    }
}
