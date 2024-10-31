using System.Collections.Generic;
using UnityEngine;
using HikariWatch;

public class SourcesManager : MonoBehaviour
{
    public static SourcesManager Instance;
    
    public List<AnimeSource> Sources { get; private set; }

    public void LoadSources()
    {
        
    }
}
