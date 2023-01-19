using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Cooldown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timeStart;
    float duration;
    bool started = false;

    public UnityEvent onCoolDown;

    public void ExecuteCoolDown(float duration) {

        this.duration = duration;
        this.timeStart = Time.time;
        this.started = true;
    } 


    // Update is called once per frame
    void Update()
    {
        
        if (started && Time.time > this.timeStart + this.duration) {
            started = false;
            onCoolDown.Invoke();
        }

    }
}