using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts
{
    public class IndicatorShuriken : MonoBehaviour
    {
        [SerializeField] private Image _imageIndicator;
    
        [SerializeField] private Color FillIndicatorColor;
        [SerializeField] private Color EmptyIndicatorColor;

        public void SetColor(bool isEmptyIndicator)
        {
            _imageIndicator.color = isEmptyIndicator ? EmptyIndicatorColor : FillIndicatorColor;
        }
    }
}
