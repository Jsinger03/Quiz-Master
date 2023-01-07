using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float timerValue;

    [SerializeField] float timeToAnswer = 20f;
    [SerializeField] float timeToSeeCorrect = 5f;

    public bool isAnsweringQuestion;
    public float fillFraction;
    public bool loadNextQuestion;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToAnswer;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToSeeCorrect;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToSeeCorrect;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToAnswer;
                loadNextQuestion = true;
            }
        }


        //if (timerValue <= 0 && !isAnsweringQuestion)
        //{
        //    timerValue = timeToAnswer;
        //    isAnsweringQuestion = true;
        //}
        //else if (timerValue <= 0 && isAnsweringQuestion)
        //{
        //    timerValue = timeToSeeCorrect;
        //    isAnsweringQuestion = false;
        //}
        //Debug.Log(isAnsweringQuestion + ": " + timerValue + " = " + fillFraction);
    }
}
