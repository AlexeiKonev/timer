using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
       public int inputTime;
       public int estimaitedTime;
       public Text inputText;
       public Text showTime;
       public AudioSource source;
    bool activeTimer = false;

        
    

    void Start()
    {
        source.Stop();

    }
    public void setTimer ()
    {
        var x = inputText.text;
        
        inputTime = int.Parse(x);
        activeTimer = true;


    }
    void timer()
    {
        inputTime--;
        showTime.text = inputTime.ToString();
        if (inputTime == 0)
            source.Play();
    }
    public void resetTimer()
    {
        source.Stop();
        setTimer();
        activeTimer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inputTime != 0 && activeTimer)
        {
            timer();
        }
    }
}
