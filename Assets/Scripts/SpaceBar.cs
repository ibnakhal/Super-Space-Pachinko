using UnityEngine;
using System.Collections;

public class SpaceBar : MonoBehaviour {
    [SerializeField]
    private int counter;
    [SerializeField]
    private int threshold;
    [SerializeField]
    private Transform[] meteorSpawn;
    [SerializeField]
    private GameObject meteor;
    [SerializeField]
    private Manager management;
	public void OnTriggerEnter(Collider Other)
    {
        Destroy(Other.gameObject, 1);
        counter++;
        if(counter == threshold)
        {
            management = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
            for(int x = 0; x < management.bonusLimit; management.bonusLimit--)
            {
               // Instantiate
            }
        }
    }
}
