using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ModelGifController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator rotation;

    void Start()
    {
        rotation = this.gameObject.GetComponent<Animator>();
        rotation.speed = 0;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        rotation.speed = 1;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rotation.speed = 0;
    }
}
