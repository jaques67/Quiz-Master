using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool isAnsweringQuestion = false;

    float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (timerValue <= 0)
        {
            isAnsweringQuestion = !isAnsweringQuestion;
            if (isAnsweringQuestion )
            {
                timerValue = timeToCompleteQuestion;
            }
            else
            {
                timerValue = timeToShowCorrectAnswer;
            }
            
        }

        Debug.Log(timerValue);
    }
}
