using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score_text;
    [SerializeField] private GameObject head_pointCal;


    public void ShowScore()
    {
        score_text.text = $"Score : {head_pointCal.GetComponent<PointCal>().GetScore()}";
    }
}
