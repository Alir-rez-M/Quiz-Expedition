using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] private AnswerButton[]  answerButton;

    private void Awake()
    {


        foreach (var answer in answerButton)
        {
            answer.OnAnswer += Answer_OnAnswer;
        }
        
    }

    private void Answer_OnAnswer(object sender, System.EventArgs e)
    {
        Debug.Log("HEYYYY");
    }

    private void Button_OnAnswer(object sender, System.EventArgs e)
    {
        Debug.Log("HEYYYY");
    }
}
