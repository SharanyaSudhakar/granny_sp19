using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Fish_Gameobject_Behaviour : MonoBehaviour {


    readonly int dropfish = Animator.StringToHash("dropFish");
    Animator aniamtor;
    bool movedown = false, ismoveforward = false;
    public Transform pos; //pos2 ued by salmon 2&3
    public float distance;
    [SerializeField] Transform Camera;
    Quaternion rot;
    Vector3 pos2;

    // Use this for initialization
    void Start () {
        aniamtor = GetComponent<Animator>();
        rot = new Quaternion(0,1.2f, 0, 0);
        pos2 = Camera.position;

    }
	
	// Update is called once per frame
	void Update () {
        if (movedown)
        {
            transform.position = Vector3.Lerp(transform.position, pos.position, Time.deltaTime * 0.4f);
            transform.rotation = Quaternion.Lerp(transform.rotation, rot, 0.4f * Time.deltaTime);
            if (Vector3.Distance(transform.position, pos.position) < .04f)
            {
                movedown = false;
                moveforward();
                Debug.Log(pos2);
            }
        }
        if (ismoveforward)
        {
            transform.position = Vector3.Lerp(transform.position,pos2, Time.deltaTime*0.85f);
            if (Vector3.Distance(transform.position, pos2) < distance)
                ismoveforward = false;
        }
            
	}
    public void show()
    {
        gameObject.SetActive(true);
    }

    public void unbend()
    {
        gameObject.GetComponent<ParentConstraint>().constraintActive = false;
        aniamtor.SetTrigger(dropfish);
        movedown = true;
    }

    public void moveforward()
    {
        ismoveforward = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
    }
}
