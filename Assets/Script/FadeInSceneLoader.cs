using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image fadeImage;
    public float fadeInTime = 2.0f;

    void Start()
    {
        fadeImage.canvasRenderer.SetAlpha(1.0f);
        FadeInAnimation();
    }

    void FadeInAnimation()
    {
        fadeImage.CrossFadeAlpha(0.0f, fadeInTime, false);
    }
}