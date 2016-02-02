using UnityEngine;
using System.Collections;

public class Endgame : MonoBehaviour {
    [SerializeField]
    private int pointValue;
    [SerializeField]
    private Score keep;
    [SerializeField]
    private GameObject Manager;
	// Use this for initialization
	void Start () {
        Manager = GameObject.FindGameObjectWithTag("Manager");
        keep = Manager.GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter()
    {
        keep.Intake(pointValue);
    }
}
