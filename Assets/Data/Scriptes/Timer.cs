using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float temps = 60;
    public Text timerText;
    public int tempsInt;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tempsInt = Mathf.RoundToInt(temps);
        timerText.text = "il vous reste: " + tempsInt + " secondes";
        if (temps >= 0)
        {
            temps -= Time.deltaTime;
        }
    }
}