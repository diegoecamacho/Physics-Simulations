using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Generic Slider Movement
/// Slider Controller Use Slider Min and Max Values to Control Range
/// </summary>
[RequireComponent(typeof(Slider))]
public class SliderController : MonoBehaviour
{
    public float SliderSpeed;

    private Slider slider;

    [SerializeField] private bool sliderActive;
    private float angle;


    // Use this for initialization
    private void Start()
    {
        slider = GetComponent<Slider>();
        if (!slider)
        {
            Debug.LogError("Slider Missing");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (!sliderActive) return;

        angle += SliderSpeed;
        slider.value = RemapMath(Mathf.Sin(angle), -1, 1, slider.minValue, slider.maxValue);
    }

    private void EnableSlider()
    {
        Debug.Log("Slider Enable");
        slider.gameObject.SetActive(true);
        sliderActive = true;
    }

    private void DisableSlider()
    {
        slider.gameObject.SetActive(false);
        sliderActive = false;

    }

    /// <summary>
    /// Returns the Current Slider value and disables the slider.
    /// </summary>
    /// <returns>Slider Value</returns>
    public float ReturnSliderValue()
    {
        var sliderValue = slider.value;
        DisableSlider();
        return sliderValue;
    }

  

  
    /// <summary>
    /// Checks if the slider is already active, if not enables it;
    /// </summary>
    /// <returns>is Slider Active</returns>
    public bool ActivateSlider()
    {
        if (sliderActive)
        {
            return true;
        }
        else
        {
            EnableSlider();
            return false;
        }
    }

    private static float RemapMath(float value, float low1, float high1, float low2, float high2)
    {
        return low2 + (value - low1) * (high2 - low2) / (high1 - low1);
    }
}