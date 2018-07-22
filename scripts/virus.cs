using UnityEngine;
using System.Collections;

public class virus : MonoBehaviour
{
    float forwardspeed, lateralSpeed, time;
    public int score,life;
    //bool stopProg;
    // Use this for initialization

    public void reduceSpeed()
    {
        if (forwardspeed > 0) forwardspeed -= 1;
        if (lateralSpeed > 0) lateralSpeed -= 1;
        if (forwardspeed < 0) forwardspeed += 1;
        if (lateralSpeed < 0) lateralSpeed += 1;
    }

    public void stop(float paroistime)
    {
        time = paroistime;
    }

    void Start()
    {
        forwardspeed = 1.0f;
        lateralSpeed = 0.0f;
        score = 0;
		life = 10;
        //stopProg = false;
    }

   
	void OnTriggerEnter(Collider other) {
		if (other.name.Equals ("GlobR_3"))life -= 1;
		//if(life ==0) 
	}

	// Update is called once per frame
    void Update()
    {

        if (Input.GetKey("up"))
        {
            if (forwardspeed <= 6)
                forwardspeed += 2.0f;
        }
        if (Input.GetKey("down"))
        {
            if (forwardspeed >= -4)
                forwardspeed -= 2.0f;
        }
        if (Input.GetKey("left"))
        {
            if (lateralSpeed <= 4)
                lateralSpeed += 4.0f;
        }
        if (Input.GetKey("right"))
        {
            if (lateralSpeed >= -4)
                lateralSpeed -= 4.0f;
        }
        if (forwardspeed > 0) forwardspeed -= 0.050f;
        if (lateralSpeed > 0) lateralSpeed -= 0.050f;
        if (forwardspeed < 0) forwardspeed += 0.050f;
        if (lateralSpeed < 0) lateralSpeed += 0.050f;
        if (Time.time > time) transform.Translate(new Vector3(forwardspeed, 0, lateralSpeed) * Time.deltaTime);
    }
}
