using BurningKnight.PanelManager;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPanel : PanelBase
{
    [SerializeField] private Button _buttonPrivacyPolicy;
    [SerializeField] private Button _buttonTermsOfUse;
    [SerializeField] private ToggleSettings _toggleSound;
    [SerializeField] private ToggleSettings _toggleSFX;
    
    public override void Init()
    {
        _toggleSound.Init(true, OnSound, OffSound);
        _toggleSFX.Init(true, OnSFX, OffSFX);
    }

    protected override void OnOpened()
    {
        _buttonPrivacyPolicy.onClick.AddListener(ShowPrivacyPolicy);
        _buttonTermsOfUse.onClick.AddListener(ShowTermsOfUse);
    }

    protected override void OnClosed()
    {
        _buttonPrivacyPolicy.onClick.RemoveListener(ShowPrivacyPolicy);
        _buttonTermsOfUse.onClick.RemoveListener(ShowTermsOfUse);
    }

    private void OnSound() { }
    private void OffSound() { }
    private void OnSFX() { }
    private void OffSFX() { }

    private void ShowPrivacyPolicy()
    {
        Application.OpenURL("");
    }
    
    private void ShowTermsOfUse()
    {
        Application.OpenURL("");
    }
}
