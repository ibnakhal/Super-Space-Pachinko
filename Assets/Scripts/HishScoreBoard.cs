using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HishScoreBoard : MonoBehaviour {
    public List<Text> scoreTexts;
    public List<Text> levelTexts;

    private PlayerPref pPref;

	// Use this for initialization
	void Start () {

    }
    public void OnEnable()
    {
        if (pPref == null)
        {
            pPref = GameObject.FindGameObjectWithTag("Background").GetComponent<PlayerPref>();
        }
        for (int x =0; x<scoreTexts.Count;x++)
        {
            scoreTexts[x].text = pPref._hScoreInt[x].ToString();
            levelTexts[x].text = pPref._levelName[x];
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
