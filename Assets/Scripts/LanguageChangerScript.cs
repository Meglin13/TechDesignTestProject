using UnityEngine;
using UnityEngine.Localization.Settings;

public class LanguageChangerScript : MonoBehaviour
{
    public void ChangeLanguage(int id) => LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[id];
}
