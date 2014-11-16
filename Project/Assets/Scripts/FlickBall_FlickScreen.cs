using UnityEngine;
using System.Collections;

public class FlickBall_FlickScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    private Vector3 startPosition;
    private Vector3 endPosition;
    private bool couldSwip = false;
    private float startTime = 0;
    private float endTime = 0;

    [HideInInspector]
    public GameObject CurrentBall;
    [HideInInspector]
    public AudioManager CurrentAudioManager;
	// Update is called once per frame
	void Update () {

        //Debug.Log("Time.timeSinceLevelLoad:  " + Time.timeSinceLevelLoad);
        //Debug.Log("Time.time:  " + Time.time);
        //Debug.Log("Time.deltaTime： " + Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
            startTime = Time.timeSinceLevelLoad;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 touchPosition = Input.mousePosition;
            Vector3 deltaPosition = touchPosition - startPosition;

            if (deltaPosition != Vector3.zero)
            {
                if (Mathf.Abs(touchPosition.y - startPosition.y) < 1||GlobalStatus.CurrentBallStatus!=GlobalStatus.BallStatus.BallStatus_WaitShoot)
                {
                    couldSwip = false;
                    Debug.Log(couldSwip);
                }
                else 
                {
                    Debug.Log(couldSwip);
                    couldSwip = true;
                }
            }
            else
            {
                    couldSwip = false;
                    Debug.Log(couldSwip);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (couldSwip)
            {
                endPosition = Input.mousePosition;
                endTime = Time.timeSinceLevelLoad;
                Swip();
            }
        }
	
	}

    void Swip()
    {
        float totalTime = endTime - startTime;
        if (CurrentBall)
        {
            CurrentBall.GetComponent<FlickBall_FlickBall>().FlickBall(startPosition, endPosition, totalTime);
            CurrentAudioManager.PlayShootSound();
            GlobalStatus.CurrentBallStatus = GlobalStatus.BallStatus.BallStatus_Rolling;
        }
    }
}
