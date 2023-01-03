using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCal : MonoBehaviour
{
    private static int totalScore;
    [SerializeField]
    private GameObject controller;
    public void AddScore(int score)
    {
        totalScore += score;
        controller.GetComponent<ScoreController>().ShowScore();
    }


    // total ���� ������
    public int GetScore()
    {
        return totalScore;
    }

}
