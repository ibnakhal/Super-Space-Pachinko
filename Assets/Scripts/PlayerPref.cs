using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref : MonoBehaviour {
    [Header("Data Saving")]
    public List<int> _hScoreInt;
    public List<string> _levelNameKey;
    public List<string> _levelName;
    public List<string> _hScoreIntKey;
    [Header("Data Updates")]
    public int _newScore;
    public string _newLevel;
    public int _oldScore;
    public string _oldLevel;

    // Use this for initialization
    void Start()
    {
        LeaderBoardLoad();
        DontDestroyOnLoad(this.gameObject);

    }

    // Update is called once per frame
    void Update() {

    }
    public void LeaderBoardLoad()
    {
        for (int x = 0; x < _hScoreInt.Count; x++)
        {
            _hScoreInt[x] = PlayerPrefs.GetInt(_hScoreIntKey[x]);
            _levelName[x] = PlayerPrefs.GetString(_levelNameKey[x]);

        }
    }
    public void LeaderBoardSave()
    {
        for (int x = 0; x < _hScoreInt.Count; x++)
        {
            PlayerPrefs.SetInt(_hScoreIntKey[x], _hScoreInt[x]);
            PlayerPrefs.SetString(_levelNameKey[x], _levelName[x]);

        }
    }
    public void LeaderBoardUpdate(int newInt, string newString)
    {
        for(int x=0; x< _hScoreInt.Count; x++)
        {
            if (newInt >= _hScoreInt[x])
            {
                Debug.Log("new int is " + newInt + " and is more than " + _hScoreInt[x]);
                _hScoreInt.Insert(x, newInt);
                _hScoreInt.RemoveAt(9);
                _levelName.Insert(x, newString);
                return;
                
            }
        }

    }
}