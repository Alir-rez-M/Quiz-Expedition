// This script is for the buttons the answers will go on

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AnswerButton : MonoBehaviour
{
    private bool isCorrect;
    [SerializeField] private TextMeshProUGUI answerText;

    // To make it ask a new question after the first question
    [SerializeField] private QuestionSetup questionSetup;
    public event EventHandler OnAnswer; 

    public void SetAnswerText(string newText)
    {
        answerText.text = newText;
    }

    public void SetIsCorrect(bool newBool)
    {
        isCorrect = newBool;
    }
    private void Update()
    {

    }

    public void OnClick()
    {
        if (isCorrect)
        {
            OnAnswer?.Invoke(this, EventArgs.Empty);
            Debug.Log(OnAnswer);

            
        }
        else
        {
            
        }

        // Get the next question if there are more in the list
        
    }
}
