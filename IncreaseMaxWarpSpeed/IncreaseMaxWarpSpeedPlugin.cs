using System;
using System.Security;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

[module: UnverifiableCode]

namespace Etherios.DSP.IncreaseMaxWarpSpeed
{

    [BepInPlugin("Etherios.DSP.IncreaseMaxWarpSpeed", "IncreaseMaxWarpSpeed", "1.0.0")]
    [BepInProcess("DSPGAME.exe")]
    public class IncreaseMaxWarpSpeedPlugin : BaseUnityPlugin
    {
        private static readonly float DEFAULT_SPEED = 1000000f;

        // ReSharper disable once MemberCanBePrivate.Global
        public new static ManualLogSource Logger;

        void Start()
        {
            Logger = base.Logger;
            PluginConfig.Init(Config);

            var harmony = new Harmony("Etherios.DSP.IncreaseMaxWarpSpeed");
            harmony.PatchAll(typeof(WarpSpeedPatch));

            Logger.LogInfo($"IncreaseMaxWarpSpeed loaded with speed updated to {PluginConfig.WarpSpeed.Value} {PluginConfig.SpeedType.Value}");
        }

        [HarmonyPatch(typeof(PlayerMove_Sail))]
        public class WarpSpeedPatch
        {
            /*
             * Method to dyanmically calculate the new warp speed based on config options.
             **/
            internal static float getNewWarpSpeed()
            {
                var warpSpeed = PluginConfig.WarpSpeed.Value;


                switch (PluginConfig.SpeedType.Value)
                {
                    case PluginConfig.ESpeed.AU:
                        return (float)Utils.AU(warpSpeed);

                    case PluginConfig.ESpeed.LY:
                        return (float)Utils.LY(warpSpeed);

                    default:
                        return DEFAULT_SPEED;
                }

            }


            [HarmonyPrefix]
            [HarmonyPatch("GameTick")]
            public static bool ChangeWarpSpeed(PlayerMove_Sail __instance, long timei)
            {
                Console.WriteLine($"Warp speed is: {__instance.player.mecha.maxWarpSpeed}");

                __instance.player.mecha.maxWarpSpeed = getNewWarpSpeed();

                Console.WriteLine($"New warp speed is: {__instance.player.mecha.maxWarpSpeed}");

                return true;
            }
        }
    }
}
