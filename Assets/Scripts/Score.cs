using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform Player;
    public TMP_Text ScoreText;
    void Update()
    {
        ScoreText.text=Player.position.z.ToString("0");
    }
}
