using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {

    [SerializeField]
    private float waitTime, aStart, aEnd, lerpValue, timer, duration;
    [SerializeField]
    private bool isFading = false, lastPiece = false;
    [SerializeField]
    private int levelLoad;

    private CanvasGroup g;
	void Start () {
       g = this.GetComponent<CanvasGroup>();
       StartCoroutine(Starter());
	}

    public void Update()
    {
        g.alpha = Mathf.Lerp(aStart, aEnd, lerpValue);

        if (isFading)
        {
        timer += Time.deltaTime;
        lerpValue = (timer / duration);
        }
		if (lerpValue >= 1) {
			//			this.gameObject.SetActive(false);
            if(lastPiece)
            {
                Application.LoadLevel(levelLoad);
            }
            Destroy(this.gameObject);
				}

    }


    public IEnumerator Starter()
    {
        yield return new WaitForSeconds(waitTime);
       
        isFading = true;

    }

}