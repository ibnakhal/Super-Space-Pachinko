using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    [SerializeField]
    private int levelToLoad;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Load()
    {
        Application.LoadLevel(levelToLoad);

    }
    public void Quit()
    {
        Application.Quit();
    }

}
