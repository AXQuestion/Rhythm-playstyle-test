using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedScroller : MonoBehaviour
{
    public float beat_tempo;
    public bool hasStarted;


    // Start is called before the first frame update
    void Start()
    {
        beat_tempo = beat_tempo / 60f; //note ²¾°Ê³t«× bpm/60
        hasStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, beat_tempo * Time.deltaTime, 0f);
    }
}
