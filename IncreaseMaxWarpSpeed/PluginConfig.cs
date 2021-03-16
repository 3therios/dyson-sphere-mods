using BepInEx.Configuration;

namespace Etherios.DSP.IncreaseMaxWarpSpeed
{
    public static class PluginConfig
    {
        // Config sections
        private static readonly string GENERAL_SECTION = "General";

        // Config types
        public enum ESpeed
        {
            LY,
            AU
        }

        // Config values
        public static ConfigEntry<double> WarpSpeed;
        public static ConfigEntry<ESpeed> SpeedType;

        // Method to initialise config with defaults or read from file.
        internal static void Init(ConfigFile config)
        {
            WarpSpeed = config.Bind(GENERAL_SECTION, "WarpSpeed", 1.0, "Maximum warp speed for the mecha in AUs or LYs based on config. Default is 1 LY");
            SpeedType = config.Bind(GENERAL_SECTION, "SpeedType", ESpeed.LY, "Speed measurement to use for max warp speed. Default is LY.");
        }
    }
}