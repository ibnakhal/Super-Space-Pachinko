using UnityEngine;
using System.Collections;

public class Blinker : MonoBehaviour {

    [SerializeField]
    private float interval;
    [SerializeField]
    private GameObject light;

	void Start () {
        StartCoroutine(Work());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public IEnumerator Work()
    {
        while(isActiveAndEnabled)
        {
            light.SetActive(true);
            yield return new WaitForSeconds(interval);


            light.SetActive(false);
            yield return new WaitForSeconds(interval);
        }
    }
}
