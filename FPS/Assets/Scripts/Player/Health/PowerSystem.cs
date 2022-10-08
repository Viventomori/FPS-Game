using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSystem : MonoBehaviour
{
    [SerializeField] public int power;
    private GameObject enemy;

    public IPowerBar powerBar;

    private void Awake()
    {
        enemy = GameObject.FindWithTag("Enemy");//був плеер
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
         
        }
    }
}
