using UnityEngine;
using System.Collections;

public class FlickBall_InitBall : MonoBehaviour {

    public AudioManager CurrentAudioManager;
	// Use this for initialization

    private FlickBall_FlickScreen _flickScreen;
	void Start () {
        _flickScreen = GetComponent<FlickBall_FlickScreen>();
        CurrentAudioManager.PlayBackgroundSound();
        InitBall();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private GameObject currentBall;
    public void InitBall()
    {
        currentBall =(GameObject)Instantiate(Resources.Load("Ball/Socker"));
        currentBall.name = "currentBall";
        float position_X = Random.Range(90.0f, 100.0f);
        float position_Z = Random.Range(-20.0f, 20.0f);
        currentBall.transform.position = new Vector3(position_X, currentBall.transform.position.y, position_Z);
        if (GetComponent<FlickBall_FlickScreen>())
        {
            _flickScreen.CurrentBall = currentBall;
            _flickScreen.CurrentAudioManager = CurrentAudioManager;

        }
    }
}
