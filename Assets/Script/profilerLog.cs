using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class profilerLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Profiler.logFile = "mylog.txt"; //Also supports passing "myLog.raw"
        Profiler.enableBinaryLog = true;
        Profiler.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
