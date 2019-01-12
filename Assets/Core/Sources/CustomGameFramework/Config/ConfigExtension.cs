using GameFramework;
using UnityGameFramework.Runtime;

public static class ConfigExtension
{
    public static void LoadConfig(this ConfigComponent configComponent, string configName, object userData = null)
    {
        if (string.IsNullOrEmpty(configName))
        {
            Log.Warning("Config name is invalid.");
            return;
        }

        // TODO LoadType改成通用，而不是写死
        configComponent.LoadConfig(configName, AssetUtility.GetConfigAsset(configName), LoadType.Bytes, Constant.AssetPriority.ConfigAsset, userData);
    }
}