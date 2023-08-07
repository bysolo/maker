using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {
    public float sayi;
    public Text sayiyazi;
    public GameObject bar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (sayi <100)
        {
            sayi += Time.deltaTime * 10;
        }
        if (sayi >=100)
        {
            sayi = 100;
            SceneManager.LoadScene("Maker");
        }
        sayiyazi.text = "" + (int)sayi + "%";
        
        bar.transform.localScale = new Vector3(sayi/100, 1, 1);
	}
}
