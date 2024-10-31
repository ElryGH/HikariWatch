using System.Collections.Generic;
using UnityEngine;
using HikariWatch;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager Instance;
    
    public Settings Settings { get; private set; }

    public void LoadSettings()
    {
        Settings = LoadSettingsFromDB();
    }

    Settings LoadSettingsFromDB()
    {
        Settings tempSettings = new Settings();
        
        
        
        return tempSettings;
    }
    
    
}
