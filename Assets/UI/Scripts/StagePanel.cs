using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts
{
    public class StagePanel : MonoBehaviour
    {
        [SerializeField] private Image _imageStage;
        [SerializeField] private TMP_Text _textStage;

        public Color LockedStageColor;
        public Color CurrentStageColor;
        public Color CompletedStageColor;

        public void InitWithText(int numberStage, Color colorStage)
        {
            _textStage.text = $"{numberStage}";
            SetColor(colorStage);
        }

        public void InitWithoutText(Color colorStage)
        {
            _textStage.gameObject.SetActive(false);
            SetColor(colorStage);
        }
        
        public void CompleteStage()
        {
            SetColor(CompletedStageColor);
        }

        private void SetColor(Color color)
        {
            _imageStage.color = color;
        }
        
        
    }
}