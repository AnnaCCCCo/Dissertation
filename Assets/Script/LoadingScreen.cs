using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public Text progressNum;
    public Slider progressSlider;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadAsyn(2));
    }

    IEnumerator LoadAsyn(int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);

        while (!operation.isDone)
        {
            //Debug.Log(operation.progress);

            progressNum.text = $"{(operation.progress / 0.9f) * 100}%";
            progressSlider.value = operation.progress / 0.9f;

            yield return null;
        }
    }
}
