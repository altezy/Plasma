using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class VFXController : MonoBehaviour
{
    [SerializeField]
    private VisualEffect visualEffect;

    [SerializeField]
    private Slider PressureSlider;

    [SerializeField]
    private Slider EnergySlider;

    public void OnPressureChanged()
    {
        visualEffect.SetFloat("Pressure", PressureSlider.value * 2.5f);
    }
    public void OnEnergyChanged()
    {
        visualEffect.SetInt("Energy", (int)(EnergySlider.value * 30));
    }
}
