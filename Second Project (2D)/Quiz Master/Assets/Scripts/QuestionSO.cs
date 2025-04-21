using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question here";
    [SerializeField] string[] answers = new string[4];

    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswer()
    {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        if (index >= 0 && index < answers.Length)
        {
            return answers[index];
        }
        else
        {
            Debug.LogError("Answer index out of range");
            return null;
        }
    }
}

