using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FrameRate : MonoBehaviour
{
    public TextMeshProUGUI frameRate;
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        frameRate.text = $"[FPS : {(int)(1.0f / Time.smoothDeltaTime)}]";
    }
}
