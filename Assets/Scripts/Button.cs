using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    [SerializeField]
    private int levelToLoad;
    [SerializeField]
    private GameObject wakeUp;
    [SerializeField]
    private GameObject goSleep;
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private Vector3 Look;
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
    public void HS()
    {
        wakeUp.SetActive(true);
        goSleep.SetActive(false);
        cam.gameObject.transform.Rotate(Look);
    }

}
