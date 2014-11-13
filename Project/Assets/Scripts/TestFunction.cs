using UnityEngine;
using System.Collections;

public class TestFunction : MonoBehaviour
{
        void Start() {

        GameObject Socker = Instantiate(Resources.Load("Socker", typeof(GameObject))) as GameObject;
        Socker.name = "CurrentSocker";
        Socker.transform.position = Vector3.zero;
    }
}
