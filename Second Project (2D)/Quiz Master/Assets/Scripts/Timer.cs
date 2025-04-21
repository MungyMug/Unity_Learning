using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToDisplatAnswer = 10f;

    public float fillfraction;

    public bool isAnsweringQuestion = false;
    public bool loadnextQuestion = false;

    float timervalue;

    void Start()
    {
        
    }

    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        timervalue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if(timervalue > 0)
            {
                fillfraction = timervalue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timervalue = timeToDisplatAnswer;
            }
        }
        else
        {
            if (timervalue > 0)
            {
                fillfraction = timervalue / timeToCompleteQuestion;
                loadnextQuestion = true;

            }
            else
            {
                isAnsweringQuestion = true;
                timervalue = timeToCompleteQuestion;
            }
        }
    }

    public void Cancelimer()
    {
        timervalue = 0;
    }
}
