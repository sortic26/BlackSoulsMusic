using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlackSoulsMusic.Content.SceneEffects
{
    public class ForestDayMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override float GetWeight(Player player) => 0.4f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/ForestDayTheme"); }
                catch { return MusicID.OverworldDay; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.bloodMoon || Main.eclipse) return false;
            return player.active && player.ZoneOverworldHeight && Main.dayTime && player.townNPCs < 3f;
        }
    }

    public class ForestAltDayMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override float GetWeight(Player player) => 0.45f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/ForestAltDayTheme"); }
                catch { return MusicID.AltOverworldDay; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.bloodMoon || Main.eclipse) return false;
            return player.active && player.ZoneOverworldHeight && Main.dayTime && player.townNPCs < 3f && player.ZoneCrimson;
        }
    }

    public class ForestNightMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override float GetWeight(Player player) => 0.4f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/ForestNightTheme"); }
                catch { return MusicID.Night; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.bloodMoon) return false;
            return player.active && player.ZoneOverworldHeight && !Main.dayTime && player.townNPCs < 3f;
        }
    }

    public class TownMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
        public override float GetWeight(Player player) => 0.7f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/TownTheme"); }
                catch { return MusicID.TownDay; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.bloodMoon || Main.eclipse) return false;
            return player.active && player.ZoneOverworldHeight && player.townNPCs >= 3f;
        }
    }

    public class SpaceMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.95f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/SpaceTheme"); }
                catch { return MusicID.SpaceDay; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            return player.active && (player.ZoneSkyHeight || player.position.Y / 16f < Main.worldSurface * 0.45f);
        }
    }
    public class DesertMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override float GetWeight(Player player) => 0.55f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/DesertTheme"); }
                catch { return MusicID.Desert; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.bloodMoon || Main.eclipse) return false;
            return player.active && player.ZoneDesert && player.ZoneOverworldHeight;
        }
    }

    public class SnowMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override float GetWeight(Player player) => 0.55f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/SnowTheme"); }
                catch { return MusicID.Snow; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.bloodMoon || Main.eclipse) return false;
            return player.active && player.ZoneSnow && player.ZoneOverworldHeight;
        }
    }

    public class JungleDayMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override float GetWeight(Player player) => 0.55f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/JungleDayTheme"); }
                catch { return MusicID.Jungle; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.bloodMoon || Main.eclipse) return false;
            return player.active && player.ZoneJungle && player.ZoneOverworldHeight && Main.dayTime;
        }
    }

    public class JungleNightMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override float GetWeight(Player player) => 0.55f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/JungleNightTheme"); }
                catch { return MusicID.JungleNight; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.bloodMoon) return false;
            return player.active && player.ZoneJungle && player.ZoneOverworldHeight && !Main.dayTime;
        }
    }

    public class OceanDayMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override float GetWeight(Player player) => 0.55f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/OceanDayTheme"); }
                catch { return MusicID.Ocean; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.bloodMoon || Main.eclipse) return false;
            return player.active && player.ZoneBeach && player.ZoneOverworldHeight && Main.dayTime;
        }
    }

    public class OceanNightMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override float GetWeight(Player player) => 0.55f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/OceanNightTheme"); }
                catch { return MusicID.OceanNight; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            if (Main.bloodMoon) return false;
            return player.active && player.ZoneBeach && player.ZoneOverworldHeight && !Main.dayTime;
        }
    }

    public class MushroomMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.98f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/MushroomTheme"); }
                catch { return 7; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            return player.active && Main.SceneMetrics.MushroomTileCount >= 40;
        }
    }

    public class GraveyardMusicScene : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music
        {
            get
            {
                try { return MusicLoader.GetMusicSlot(Mod, "Content/Music/GraveyardTheme"); }
                catch { return MusicID.Graveyard; }
            }
        }
        public override bool IsSceneEffectActive(Player player)
        {
            return player.active && Main.LocalPlayer.ZoneGraveyard && player.ZoneOverworldHeight;
        }
    }
}









