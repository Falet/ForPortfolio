using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BurningKnight.PanelManager
{
    [CreateAssetMenu(fileName = "PanelManagerSettings", menuName = "BurningKnight/PanelManagerSettings")]
    public class PanelManagerSettings : ScriptableObject
    {
        public PanelBase[] PanelPrefabs;
    }
}