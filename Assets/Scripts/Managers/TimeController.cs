using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TimeSpeed
{
    Pause,Normal, Fast,Fastest
}

public class TimeController : MonoBehaviour {

    private static TimeController _instance;
    public static TimeController Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }


    TimeSpeed timeSpeed = TimeSpeed.Pause;
    public TimeSpeed TimeSpeed
    {
        get { return timeSpeed; }
        set
        {
            timeSpeed = value;
            if (timeSpeed == TimeSpeed.Pause) currentSpeed = 0;
            else if (timeSpeed == TimeSpeed.Normal) currentSpeed = NORMAL_SPEED;
            else if (timeSpeed == TimeSpeed.Fast) currentSpeed = FAST_SPEED;
            else if (timeSpeed == TimeSpeed.Fastest) currentSpeed = FASTEST_SPEED;
        }
    }
    readonly int NORMAL_SPEED = 1;
    readonly int FAST_SPEED = 5;
    readonly int FASTEST_SPEED = 10;
   // readonly float SPEEDMOD = 7; //this is so seconds change very fast, giving off a dynamic vibe [mostly used in missions]
    int currentSpeed = 0;

    //Add start TimeDate variables, needed for save game probably
    int ticks = 0; 
    int days = 1;
    int dayOfWeek = 1;
    int months = 1;
    int years = 2200;
    readonly int MAX_TICKS = 30;

    public int Ticks { get { return ticks; } }
    public int Days { get { return days; } }
    public int Months { get { return months; } }
    public int Years { get { return years; } }
	
	// Update is called once per frame
	void Update ()
    {
        TimeStep();
	}

    private void TimeStep()
    {
        //Debug.Log((int)(currentSpeed * SPEEDMOD * Time.deltaTime * 9));
        ticks += currentSpeed;
        TickSignal();

        if (ticks > MAX_TICKS)
        {
            days++;
            DailySignal();
            dayOfWeek++;
            if (dayOfWeek % 7 == 0)
            {
                dayOfWeek = 1;
                WeeklySignal();
            }

            ticks = 0;

            if (days >= 31)
            {
                months++;
                MonthlySignal();
                days = 1;

                if (months >= 13)
                {
                    months = 1;
                    YearlySignal();
                    years++;

                }
            }
        }
    }

    private void TickSignal()
    {
        //Debug.Log("A tick has passed");
    }
    private void DailySignal()
    {
        // Debug.Log("A day has passed");
        //Canvas.ForceUpdateCanvases();
    }

    private void WeeklySignal()
    {

        // Debug.Log("A week has passed");
        //OrgController.Instance.WeeklyUpdate();

    }
    private void MonthlySignal()
    {
        //StarManager.Instance.MonthlyUpdate();
        //Galaxy.Instance.MonthlyUpdate(); //this doesn't actually do nothing for now
        //EmpireManager.Instance.MonthlyUpdate();
       // UIManager.Instance.MonthlyUpdate();//Always last
        // Debug.Log("A month has passed");
    }
    private void YearlySignal()
    {
       // Debug.Log("A year has passed");
    }
}
