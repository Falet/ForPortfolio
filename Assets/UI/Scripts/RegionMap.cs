using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegionMap : MonoBehaviour
{
    [SerializeField] private Color _currentColorRegion;
    [SerializeField] private Color _completedColorRegion;
    [SerializeField] private Color _lockedColorRegion;
    [SerializeField] private Image _imageGangRegion;
    [SerializeField] private Sprite _iconGangRegion;
    [SerializeField] private Sprite _completedIconGangRegion;
}
