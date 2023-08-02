using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using Unity.VisualScripting;

public class SanityBehavior : MonoBehaviour
{
    public LayerMask sanityReach;
    public PostProcessProfile profile;
    Vignette vignette;
    Slider sanitySlider;
    public int fullSanity;
    public float difficulty;
    float percent;

    // Start is called before the first frame update
    void Start()
    {
        profile.TryGetSettings(out vignette);
        sanitySlider = GetComponent<Slider>();
        sanitySlider.maxValue = fullSanity;
        sanitySlider.value = fullSanity;
        vignette.intensity.value = 0;

        StartCoroutine(LoseSanity());
    }

    IEnumerator LoseSanity()
    {
        while (sanitySlider.value > 0)
        {
            sanitySlider.value -= 0.5f * difficulty;
            float newValue = (sanitySlider.value - sanitySlider.maxValue) * -1;
            percent = newValue / sanitySlider.maxValue;
            vignette.intensity.value = percent;

            yield return null;
        }
        Debug.Log("Blacked out!");
    }
}
