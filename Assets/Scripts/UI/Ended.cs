using UnityEngine;
using System.Collections;

public class Ended : MonoBehaviour {

    CursorLockMode mode;

        public void Start()
    {
        mode = CursorLockMode.Confined;
        Cursor.lockState = mode;
        Cursor.visible = true;
    }

}
