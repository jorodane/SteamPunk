using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour {

    public float speed = 0.5f;
    public float jump = 5.0f;
    private bool isJump = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void setIsJump(bool isJump)
    {
        this.isJump = isJump;
    }

    bool getIsJump()
    {
        return this.isJump;
    }
}
