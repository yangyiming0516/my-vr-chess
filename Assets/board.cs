using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board : MonoBehaviour {
    public int next;  //0 white 1 black
    public grid occupied_grid;
    public grid next_grid;
    public int status; //0 for not occupied, 1 for occupied

    // Use this for initialization
    void Start () {
        next = 0;
        status = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void remove_piece()
    {
        if (next_grid.temp_piece != null)
            Destroy(next_grid.temp_piece.gameObject);
    }

}
