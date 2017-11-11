using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour {
    private Renderer rend;
    public Texture2D happy;
    public Texture2D normal;
    public Texture2D sad;
    public Texture2D angry;

    // Use this for initialization
    void Start () {
        rend = gameObject.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeHappy()
    {
        rend.material.mainTexture = happy;
    }

    public void changeNormal()
    {
        rend.material.mainTexture = normal;
    }

    public void changeSad()
    {
        rend.material.mainTexture = sad;
    }

    public void changeAngry()
    {
        rend.material.mainTexture = angry;
    }
}
