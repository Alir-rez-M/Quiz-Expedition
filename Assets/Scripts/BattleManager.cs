using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] private AnswerButton[]  answerButton;
    [SerializeField] private QuestionSetup questionSetup;
    public event EventHandler<OnStateEventArgs> OnState;
    float time;
    public class OnStateEventArgs : EventArgs
    {
        public BattleState state;
    }
    public BattleState state;
    public enum BattleState
    {
        idle,
        Quiz,
        Attack,
        BackToPostion
    }

    private void Start()
    {


        foreach (var answer in answerButton)
        {
            answer.OnAnswer += Answer_OnAnswer;
        }
        
    }
    private void Update()
    {
        switch (state)
        {
            case BattleState.idle:
                break;
            case BattleState.Quiz:
                questionSetup.Start();
                break;
            case BattleState.Attack:
                time += Time.deltaTime;
                OnState?.Invoke(this , new OnStateEventArgs()
                {
                    state = state,
                });
                
                if (time > 7)
                {
                    state = BattleState.Quiz;
                }
                Debug.Log(time);
                
                break;
            case BattleState.BackToPostion:
                
                break;

        }
    }

    private void Answer_OnAnswer(object sender, System.EventArgs e)
    {
       state = BattleState.Attack;
    }
}
