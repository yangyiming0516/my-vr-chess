using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour {

    public Material selected_material;
    public Material nextmove_material;
    private Material original_material;
    private string piece_type;
    private int who;
    public GameObject P;
    public GameObject temp_piece = null;
    public board B;
    private bool occupied;
    public AudioSource selected;

	// Use this for initialization
	void Start () {
        original_material = GetComponent<Renderer>().material;
        temp_piece = P;
        occupied = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pointed()
    {
        if (B.status == 0)
        {
            if (temp_piece != null && ((piece)temp_piece.GetComponent(typeof(piece))).side == B.next)
            {
                selected.Play();
                GetComponent<Renderer>().material = selected_material;
            }
        }
        else
        {
            if (temp_piece == null || ((piece)temp_piece.GetComponent(typeof(piece))).side != B.next)
            {
                selected.Play();
                GetComponent<Renderer>().material = nextmove_material;
            }
        }
        
    }

    public void notpointed()
    {
        if (occupied==false)
            GetComponent<Renderer>().material = original_material;
    }

    public void clickon()
    {
        if (B.status==0)
        {
            if (temp_piece != null && ((piece)temp_piece.GetComponent(typeof(piece))).side == B.next)
            {
                occupied = true;
                B.occupied_grid = this;
                B.status = 1;
                ((piece)temp_piece.GetComponent(typeof(piece))).goup();
            }
        }
        else
        {
            if (B.occupied_grid == this)
            {
                occupied = false;
                B.occupied_grid = null;
                B.status = 0;
                ((piece)temp_piece.GetComponent(typeof(piece))).godown();
            }
            if (temp_piece == null || ((piece)temp_piece.GetComponent(typeof(piece))).side != B.next)
            {
                B.next_grid = this;
                B.occupied_grid.moveto(this);
                B.occupied_grid.occupied = false;
                occupied = false;
                B.occupied_grid = null;
                B.status = 0;
            }
        }
    }

    public void moveto(grid target)
    {
        ((piece)temp_piece.GetComponent(typeof(piece))).moveto(target.transform.position);
        occupied = false;
        GetComponent<Renderer>().material = original_material;
        B.next = 1 - B.next;
        temp_piece = null;
    }
}
