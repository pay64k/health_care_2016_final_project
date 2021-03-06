﻿using UnityEngine;
using System.Collections;

public class GameConfig : MonoBehaviour
{

    public bool handMouseControl;
    
    public float shootThreshold;
    public float shootIntervalTimer;

    public float projectileSpawnSpread;
    public float projectileTravelSpeed;

    public float targetHealth;

    public float indicatorsActiveTimeSec;
    public float indicatorSpinSpeed;

    public bool easyMode;

    public float gameTime;

    public float ShootThreshold
    {
        get
        {
            return shootThreshold;
        }

        set
        {
            shootThreshold = value;
        }
    }

    public float GameTime
    {
        get
        {
            return gameTime;
        }

        set
        {
            gameTime = value;
        }
    }

    public float IndicatorsActiveTimeSec
    {
        get
        {
            return indicatorsActiveTimeSec;
        }

        set
        {
            indicatorsActiveTimeSec = value;
        }
    }

    public bool HandMouseControl
    {
        get
        {
            return handMouseControl;
        }

        set
        {
            handMouseControl = value;
        }
    }

    public float ShootIntervalTimer
    {
        get
        {
            return shootIntervalTimer;
        }

        set
        {
            shootIntervalTimer = value;
        }
    }

    public float ProjectileSpawnSpread
    {
        get
        {
            return projectileSpawnSpread;
        }

        set
        {
            projectileSpawnSpread = value;
        }
    }

    public float ProjectileTravelSpeed
    {
        get
        {
            return projectileTravelSpeed;
        }

        set
        {
            projectileTravelSpeed = value;
        }
    }
}


