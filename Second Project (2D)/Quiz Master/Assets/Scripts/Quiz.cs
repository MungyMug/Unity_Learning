using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Quiz : MonoBehaviour
{
    [Header ("Question")]
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;

    [Header("Answer")]
    [SerializeField] GameObject[] answerButtons;

    int correctAnswerIndex;

    [Header ("Button Colours")]
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;

    [Header ("Timer")]
    [SerializeField] Image fillImage;
    [SerializeField] Timer timer;

    void Start()
    {
        timer = FindAnyObjectByType<Timer>();
        GetNextQuestion();
        DisplayQuestion();
        OnButton();
    }

    public void OnAnswerSelected(int index)
    {
        if (index == correctAnswerIndex)
        {
            questionText.text = "Correct!";
            Image buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
        else
        {

            questionText.text = question.GetAnswer(question.GetCorrectAnswer());
            // Show the correct answer
            Image correctButtonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
            correctButtonImage.sprite = correctAnswerSprite;
        }

        timer.Cancelimer();
        OffButton();
    }

    public void DisplayQuestion()
    {
        questionText.text = question.GetQuestion();

        correctAnswerIndex = question.GetCorrectAnswer();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonTexts = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonTexts.text = question.GetAnswer(i);
        }
    }

    public void OnButton()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponent<Button>().interactable = true;
        }
    }
    
    public void GetNextQuestion()
    {
        OnButton();
    }

    public void OffButton()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponent<Button>().interactable = false;
        }
    }

    public void ResetButtonSprite()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            Image buttonImage = answerButtons[i].GetComponent<Image>();
            buttonImage.sprite = defaultAnswerSprite;
        }
    }

    void Update()
    {
        fillImage.fillAmount = timer.fillfraction;
        if (timer.loadnextQuestion)
        {
            GetNextQuestion();
            DisplayQuestion();
            ResetButtonSprite();
            timer.loadnextQuestion = false;
        }
    }
}
