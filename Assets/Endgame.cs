﻿using UnityEngine;
using System.Collections;
    public enum EndGameType 
    {
        Bonus,
        BallAdder,
        PointAdder,
        None
    }  
public class Endgame : MonoBehaviour {
    [SerializeField]
    private int pointValue;
    [SerializeField]
    private Manager keep;
    [SerializeField]
    private GameObject Manager;
    public EndGameType eGType;
	// Use this for initialization
	void Start () {
        Manager = GameObject.FindGameObjectWithTag("Manager");

            keep = Manager.GetComponent<Manager>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter()
    {
        switch (eGType)
        {
            case EndGameType.PointAdder:
                keep.Intake(pointValue);
                break;
            case EndGameType.Bonus:
                keep = Manager.GetComponent<Manager>();
                break;
            case EndGameType.BallAdder:
                keep = Manager.GetComponent<Manager>();
                break;


        }

    }
}
