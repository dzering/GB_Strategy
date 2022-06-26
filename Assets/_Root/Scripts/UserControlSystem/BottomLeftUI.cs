using InputSystem;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Abstacts;

namespace UI
{
    public class BottomLeftUI : MonoBehaviour
    {
        [SerializeField] private SelectableValue selectableValue;

        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private Image selectedImage;
        [SerializeField] private Slider healthSlider;
        [SerializeField] private Image sliderBackground;
        [SerializeField] private Image sliderFillImage;

        private void Start()
        {
            selectableValue.OnSelected += onSelected;
            onSelected(selectableValue.CurrentSelection);
        }

        private void onSelected(ISelectable selected)
        {
            selectedImage.enabled = selected != null;
            healthSlider.gameObject.SetActive(selected != null);
            text.enabled = selected != null;

            if(selected != null)
            {
                selectedImage.sprite = selected.Icon;
                text.text = $"{selected.MaxHealth}/{selected.Health}";
                healthSlider.minValue = 0;
                healthSlider.maxValue = selected.MaxHealth;
                healthSlider.value = selected.Health; ;

                Color color = Color.Lerp(Color.red, Color.green, selected.Health / (float)selected.MaxHealth);

                sliderBackground.color = color * 0.5f;
                sliderFillImage.color = color;  
            }

        }

    }
}