using System.Collections.Generic;
using HikariWatch;
using UnityEngine;
using DeviceType = HikariWatch.DeviceType;

public class Startup : MonoBehaviour
{
    [SerializeField]
    private SettingsManager settingsManager;
    [SerializeField]
    private DiscordManager discordManager;
    [SerializeField]
    private APIManager apiManager;
    [SerializeField]
    private AniListManager aniListManager;
    [SerializeField]
    private SourcesManager sourcesManager;
    [SerializeField]
    private DeviceManager deviceManager;
    
    void Start()
    {
        // Load the Settings.
        settingsManager.LoadSettings();
        var settings = SettingsManager.Instance.Settings;
        // Detect the Device Type
        deviceManager.DetectDevice();
        // If DB Empty switch to PC Setup Screen
        if (!settings.IsSetup)
        {
            if (settings.DeviceType == DeviceType.PC)
            {
            
            }
            else
            {
                
            }
        }
        // If Android check what mode is Set up & Switch to Remote mode if needed.
        if (settings.DeviceType == DeviceType.Mobile)
        {
            if (settings.MobileDeviceSettings.DeviceMode == DeviceMode.Remote)
            {
                
            }
        }
        // Load the available Sources from DB or from Website.
        sourcesManager.LoadSources();
        // Now load the rest of the stuff.
        apiManager.ConnectAPI();
        aniListManager.LoadAniList();
        discordManager.ConnectDiscord();
        // Lastly move to the correct Scene based on Device.
        
    }
}
