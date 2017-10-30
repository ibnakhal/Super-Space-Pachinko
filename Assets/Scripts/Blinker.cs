using UnityEngine;
using System.Collections;

public class Blinker : MonoBehaviour {

    [SerializeField]
    private float interval;
    [SerializeField]
    private GameObject light;
    [SerializeField]
    private GameObject bulb;
    [SerializeField]
    private Renderer bulbRend;
    [SerializeField]
    private Color onColor;
    [SerializeField]
    private Color offColor;
    void Start () {
        StartCoroutine(Work());
         bulbRend = bulb.GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update () {
	
	}

    public IEnumerator Work()
    {
        while(isActiveAndEnabled)
        {
            light.SetActive(true);
            bulbRend.material.SetColor("_EmissionColor", onColor);
            bulbRend.material.color = onColor;
            yield return new WaitForSeconds(interval);

            light.SetActive(false);
            bulbRend.material.SetColor("_EmissionColor", offColor);
            bulbRend.material.color = offColor;
            yield return new WaitForSeconds(interval);


        }
    }
}
