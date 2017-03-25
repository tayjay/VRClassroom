using UnityEngine;
using System.Collections;

public class ClickButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


    // Update is called once per frame
    void Update () {
        
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            print(this.gameObject);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                print(hit.transform.name);

                if(hit.transform.name.Equals("Cube (1)"))
                {
                    this.enabled = !this.enabled;
                }
                // the object identified by hit.transform was clicked
                // do whatever you want
            }
        }
    }
}
