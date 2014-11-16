using UnityEngine;
using System.Collections;

public class FlickBall_FlickBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void FlickBall(Vector3 startPosition,Vector3 endPositon,float time)
    {
        //完成 通过参数计算 并使 足球飞出去

        //球的方向
        Vector3 ballDirection = endPositon - startPosition;
        ballDirection.Normalize();
        float angle = Mathf.Atan2(ballDirection.x, ballDirection.y) * Mathf.Rad2Deg;
        ballDirection = endPositon - startPosition;


        float power = ballDirection.magnitude / time;

        Vector3 force = transform.rotation * Quaternion.AngleAxis(angle, Vector3.up) * (new Vector3(0, 0, power));


        rigidbody.constraints = RigidbodyConstraints.None;

        rigidbody.AddForce(force/20, ForceMode.Impulse);

    }
}
