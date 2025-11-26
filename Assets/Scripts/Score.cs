using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform Player;
    public TMP_Text ScoreText;


    private void Awake()
    {
        Player = FindObjectOfType<PlayerControl>().transform;
    }

    void Update()
    {
        ScoreText.text=Player.position.z.ToString("0");
    }
}
