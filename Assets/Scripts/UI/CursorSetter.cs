using UnityEngine;
using System.Collections;

public class CursorSetter : MonoBehaviour {

	[SerializeField]
	private CursorLockMode permastate;
	[SerializeField]
	public bool visibility = false;
	[SerializeField] 
	private float time; 
	 /// <summary>
	/// Locks the curson in the center of the screen and makes it invidisble to
	/// stop the annoying out of window cursor that can mess up the game
	/// </summary>
	public void Start()
	{
		Cursor.lockState = permastate;
        Cursor.visible = false;
		StartCoroutine(CursorUp());
	}



	public IEnumerator CursorUp()
	{
        
		yield return new WaitForSeconds(time);
        Debug.Log(Cursor.visible);
			Cursor.visible = visibility;
	}
}
