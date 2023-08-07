using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D temasedilen)
    {
        if (temasedilen.gameObject.tag=="sabit")
        {
            Destroy(temasedilen.gameObject,0);
        }
    }
}
