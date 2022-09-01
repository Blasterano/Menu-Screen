using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchButton : MonoBehaviour
{
    //RectTransform rectTransform;

    [SerializeField] private RectTransform button;

    //private float width;

    // Start is called before the first frame update
    void Start()
    {
        //rectTransform = GetComponent<RectTransform>();
        //width = stretchPoint.rect.width;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeOut()
    {
        button.gameObject.SetActive(false);
    }
    public void FadeIn()
    {
        button.gameObject.SetActive(true);
    }
    
    /*public void Stretch(float value)
    {
        float width = stretchPoint.rect.width - value;
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
    }
    public IEnumerator Strech(float value)
    {
        yield return new WaitForSeconds(0.1f);
        width -= value;
        float currentWidth=rectTransform.rect.width;
        Debug.Log("q");
        if (rectTransform.rect.width >= width)
        {
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
            currentWidth = rectTransform.rect.width;
            Debug.Log("if");
            yield return null;
        }
        while(rectTransform.rect.width <= width)
        {
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, currentWidth);
            currentWidth *= Time.deltaTime * 50;
            Debug.Log(currentWidth);
            yield return new WaitForSeconds(0.1f);
        }
    }
    public void Normal(float value)
    {
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, value);
    }*/
}
