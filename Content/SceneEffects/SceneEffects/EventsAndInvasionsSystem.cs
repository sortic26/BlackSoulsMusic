using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlackSoulsMusic.Common.Systems
{
    public class EventsAndInvasionsSystem : ModSystem
    {
        private static int bloodMoonSlot = -1;
        private static int eclipseSlot = -1;
        private static int meteorSlot = -1;
        private static int oldOneArmySlot = -1;
        private static int goblinSlot = -1;
        private static int pirateSlot = -1;
        private static int martianSlot = -1;
        private static int pumpkinMoonSlot = -1;
        private static int frostMoonSlot = -1;
        private static int pillarsSlot = -1;

        public override void Load()
        {
            Terraria.Audio.On_LegacyAudioSystem.Update += HookEvents;
        }

        public override void Unload()
        {
            Terraria.Audio.On_LegacyAudioSystem.Update -= HookEvents;
        }

        private void HookEvents(Terraria.Audio.On_LegacyAudioSystem.orig_Update orig, Terraria.Audio.LegacyAudioSystem self)
        {
            if (Main.gameMenu)
            {
                orig(self);
                return;
            }

            if (bloodMoonSlot == -1)
            {
                bloodMoonSlot = MusicLoader.GetMusicSlot(Mod, "Content/Music/BloodMoonTheme");
                eclipseSlot = MusicLoader.GetMusicSlot(Mod, "Content/Music/SolarEclipse");
                meteorSlot = MusicLoader.GetMusicSlot(Mod, "Content/Music/MeteorZone");
                oldOneArmySlot = MusicLoader.GetMusicSlot(Mod, "Content/Music/OldOneArmy");
                goblinSlot = MusicLoader.GetMusicSlot(Mod, "Content/Music/GoblinInvasion");
                pirateSlot = MusicLoader.GetMusicSlot(Mod, "Content/Music/PirateInvasion");
                martianSlot = MusicLoader.GetMusicSlot(Mod, "Content/Music/MartianMadness");
                pumpkinMoonSlot = MusicLoader.GetMusicSlot(Mod, "Content/Music/PumpkinMoonTheme");
                frostMoonSlot = MusicLoader.GetMusicSlot(Mod, "Content/Music/FrostMoonTheme");
                pillarsSlot = MusicLoader.GetMusicSlot(Mod, "Content/Music/LunarPillars");
            }
            if (Main.LocalPlayer.active && MusicConfig.Instance != null)
            {
                if (Main.LocalPlayer.ZoneOldOneArmy && oldOneArmySlot != -1 && MusicConfig.Instance.OldOneArmyMusic)
                {
                    Main.newMusic = oldOneArmySlot;
                    orig(self);
                    return;
                }

                if (Main.pumpkinMoon && pumpkinMoonSlot != -1 && MusicConfig.Instance.PumpkinMoonMusic)
                {
                    Main.newMusic = pumpkinMoonSlot;
                    orig(self);
                    return;
                }

                if (Main.snowMoon && frostMoonSlot != -1 && MusicConfig.Instance.FrostMoonMusic)
                {
                    Main.newMusic = frostMoonSlot;
                    orig(self);
                    return;
                }

                bool nearAnyPillar = Main.npc.Any(n => n != null && n.active && 
                    (n.type == NPCID.LunarTowerSolar || n.type == NPCID.LunarTowerVortex || 
                     n.type == NPCID.LunarTowerNebula || n.type == NPCID.LunarTowerStardust) &&
                    Main.LocalPlayer.Distance(n.Center) < 8000f);

                if (nearAnyPillar && !Main.LocalPlayer.ZoneRockLayerHeight && !Main.LocalPlayer.ZoneUnderworldHeight && pillarsSlot != -1 && MusicConfig.Instance.LunarPillarsMusic)
                {
                    Main.newMusic = pillarsSlot;
                    orig(self);
                    return;
                }

                if (Main.eclipse && eclipseSlot != -1 && MusicConfig.Instance.SolarEclipseMusic)
                {
                    Main.newMusic = eclipseSlot;
                    orig(self);
                    return;
                }

                if (Main.bloodMoon && bloodMoonSlot != -1 && MusicConfig.Instance.BloodMoonMusic)
                {
                    Main.newMusic = bloodMoonSlot;
                    orig(self);
                    return;
                }

                if (Main.invasionType == InvasionID.GoblinArmy && Main.invasionProgressNearInvasion && goblinSlot != -1 && MusicConfig.Instance.GoblinInvasionMusic)
                {
                    Main.newMusic = goblinSlot;
                    orig(self);
                    return;
                }

                if (Main.invasionType == InvasionID.PirateInvasion && Main.invasionProgressNearInvasion && pirateSlot != -1 && MusicConfig.Instance.PirateInvasionMusic)
                {
                    Main.newMusic = pirateSlot;
                    orig(self);
                    return;
                }

                if (Main.invasionType == InvasionID.MartianMadness && Main.invasionProgressNearInvasion && martianSlot != -1 && MusicConfig.Instance.MartianMadnessMusic)
                {
                    Main.newMusic = martianSlot;
                    orig(self);
                    return;
                }

                if (Main.LocalPlayer.ZoneMeteor && meteorSlot != -1 && MusicConfig.Instance.MeteorZoneMusic)
                {
                    Main.newMusic = meteorSlot;
                    orig(self);
                    return;
                }
            }

            orig(self);
        }
    }
}
