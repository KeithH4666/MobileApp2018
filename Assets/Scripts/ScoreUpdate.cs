﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour {

    public static int scoreValue = 0;
    public static int health = 100;
    
    Text score;

	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
        
    }
	
	// Update is called once per frame
	void Update () {

        score.text = "Players current score = " + DBManager.score;
	}
}
