using System.Collections;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI text;
    public int sceneIndex;

    private RectTransform rectTransform;
    private float maxWidth;

    private StringBuilder strBuilder = new StringBuilder(4);

    void Start()
    {
        rectTransform = image.GetComponent<RectTransform>();//The pos of progress bar
        var size = rectTransform.sizeDelta;
        maxWidth = size.x; //The right position of progress bar

        var newSize = size;
        newSize.x = 0; //Start from 0
        size = newSize;
        rectTransform.sizeDelta = size;

        StartCoroutine(StartLoading_1(sceneIndex));
    }

    private IEnumerator StartLoading_1(int sceneIndex)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneIndex);
        while (op.isDone == false)
        {
            float percent = op.progress / 0.9f;
            Debug.Log(percent);
            var width = Mathf.Lerp(0, maxWidth, percent);
            var newSize = rectTransform.sizeDelta;
            newSize.x = width;
            rectTransform.sizeDelta = newSize;

            strBuilder.Clear();
            text.text = strBuilder.Append(percent).Append("%").ToString();

            yield return null;
        }

    }

    public void LoadGame(int sceneIndex)
    {
        StartCoroutine(StartLoading_1(sceneIndex));
    }


}
