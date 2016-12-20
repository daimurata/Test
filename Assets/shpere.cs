using UnityEngine;
using System.Collections;

public class shpere : MonoBehaviour {
    Vector3 pos;
	// Use this for initialization
	void Start () {
        Vector3 pos = new Vector3(0.0f, 0.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetButtonDown("Fire1"))
        {
            //Fire1（左クリックまたは左Ctrlキー）が押されたときの処理.
            pos.z = 1.0f;
        }
        transform.position += pos;
        
    }
}
