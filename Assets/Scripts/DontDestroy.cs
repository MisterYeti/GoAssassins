using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

	// Use this for initialization
	void Awake () {

        if (FindObjectsOfType(typeof(GameManager)).Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(transform.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
