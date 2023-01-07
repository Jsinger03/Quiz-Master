using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]//so we can make objects of type quiz question named new question from create menu
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]//adjusts size of question box in Inspector to be 2-6 lines
    [SerializeField] string question = "Enter new question text here";

    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correct_answer_index;
    public string GetQuestion()
    {
        
        return question;
    }
    public int GetCorrectAnswerIndex()
    {
        return correct_answer_index;
    }
    public string GetAnswer(int index)
    {
        return answers[index];
    }
}

//just to test, since I can have multiple classes in one file
public class Test
{
    QuestionSO questionSO;
    void test()
    {
        string question_text = questionSO.GetQuestion();
    }
}