using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;
    public SpeedScroller theRS;

    public static GameManager instance;

    public int currentScore=0;
    public int perfectScore = 100;
    public int goodScore = 50;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreText.text = "Score: " + currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
                startPlaying = true;
                theRS.hasStarted = true;
                theMusic.Play();
        }
    }

    public void NoteHit()
    {
        scoreText.text = "Score: "+currentScore;
    }

    public void GoodHit()
    {
        Debug.Log("Good");
        currentScore += goodScore;
        NoteHit();
    }
    public void PerfectHit()
    {
        Debug.Log("Perfect");
        currentScore += perfectScore;
        NoteHit();
    }
    public void NoteMiss()
    {
        Debug.Log("Missed");
    }
}
