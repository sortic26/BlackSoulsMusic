using System.ComponentModel;
using Terraria.Localization;
using Terraria.ModLoader.Config;
using Newtonsoft.Json;

namespace BlackSoulsMusic
{
    public enum DevianttMusicMode
    {
        Disabled,
        Elizabeth3,
        Gokumashin
    }

    public class MusicConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        public static MusicConfig Instance;

        public override void OnChanged()
        {
            Instance = this;
        }

        [Header("$Mods.BlackSoulsMusic.Configs.MusicConfig.Headers.PreHardmodeBosses")]
        [DefaultValue(true)]
        public bool TrojanSquirrelMusic;

        [DefaultValue(true)]
        public bool KingSlimeMusic;

        [DefaultValue(true)]
        public bool EyeOfCthulhuMusic;

        [DefaultValue(true)]
        public bool CursedCoffinMusic;

        [DefaultValue(true)]
        public bool EvilBossesMusic;

        [DefaultValue(true)]
        public bool QueenBeeMusic;

        [DefaultValue(true)]
        public bool SkeletronMusic;

        [DefaultValue(true)]
        public bool DeerclopsMusic;

        public DevianttSettings DevianttWrapper = new DevianttSettings();

        [DefaultValue(true)]
        public bool WallOfFleshMusic;

        [Header("$Mods.BlackSoulsMusic.Configs.MusicConfig.Headers.HardmodeBosses")]
        [DefaultValue(true)]
        public bool QueenSlimeMusic;

        [DefaultValue(true)]
        public bool BanishedBaronMusic;

        [DefaultValue(true)]
        public bool TwinsMusic;

        [DefaultValue(true)]
        public bool DestroyerMusic;

        [DefaultValue(true)]
        public bool SkeletronPrimeMusic;

        [DefaultValue(true)]
        public bool LifelightMusic;

        [DefaultValue(true)]
        public bool PlanteraMusic;

        [DefaultValue(true)]
        public bool GolemMusic;

        [DefaultValue(true)]
        public bool BetsyMusic;

        [DefaultValue(true)]
        public bool DukeFishronMusic;

        [DefaultValue(true)]
        public bool EmpressMusic;

        [DefaultValue(true)]
        public bool CultistMusic;

        [DefaultValue(true)]
        public bool MoonLordMusic;

        [Header("$Mods.BlackSoulsMusic.Configs.MusicConfig.Headers.PostMoonLord")]
        [DefaultValue(true)]
        public bool ChampionsMusic;

        [DefaultValue(true)]
        public bool EridanusMusic;

        [DefaultValue(true)]
        public bool AbominationnMusic;

        [DefaultValue(true)]
        public bool MutantMusic;

        [Header("$Mods.BlackSoulsMusic.Configs.MusicConfig.Headers.GlobalEvents")]
        [DefaultValue(true)]
        public bool BloodMoonMusic;
        [DefaultValue(true)]
        public bool SolarEclipseMusic;

        [DefaultValue(true)]
        public bool MeteorZoneMusic;

        [DefaultValue(true)]
        public bool OldOneArmyMusic;

        [DefaultValue(true)]
        public bool GoblinInvasionMusic;

        [DefaultValue(true)]
        public bool PirateInvasionMusic;

        [DefaultValue(true)]
        public bool MartianMadnessMusic;

        [DefaultValue(true)]
        public bool PumpkinMoonMusic;

        [DefaultValue(true)]
        public bool FrostMoonMusic;

        [DefaultValue(true)]
        public bool LunarPillarsMusic;

        [Header("$Mods.BlackSoulsMusic.Configs.MusicConfig.Headers.Controls")]
        [DefaultValue(false)]
        public bool EnableAll
        {
            get => false;
            set
            {
                if (value)
                {
                    DevianttWrapper.DevianttMode = DevianttMusicMode.Elizabeth3;
                    TrojanSquirrelMusic = true;
                    KingSlimeMusic = true;
                    EyeOfCthulhuMusic = true;
                    CursedCoffinMusic = true;
                    EvilBossesMusic = true;
                    QueenBeeMusic = true;
                    SkeletronMusic = true;
                    DeerclopsMusic = true;
                    WallOfFleshMusic = true;
                    QueenSlimeMusic = true;
                    BanishedBaronMusic = true;
                    TwinsMusic = true;
                    DestroyerMusic = true;
                    SkeletronPrimeMusic = true;
                    LifelightMusic = true;
                    PlanteraMusic = true;
                    GolemMusic = true;
                    BetsyMusic = true;
                    DukeFishronMusic = true;
                    EmpressMusic = true;
                    CultistMusic = true;
                    MoonLordMusic = true;
                    ChampionsMusic = true;
                    EridanusMusic = true;
                    AbominationnMusic = true;
                    MutantMusic = true;
                    BloodMoonMusic = true;
                    SolarEclipseMusic = true;
                    MeteorZoneMusic = true;
                    OldOneArmyMusic = true;
                    GoblinInvasionMusic = true;
                    PirateInvasionMusic = true;
                    MartianMadnessMusic = true;
                    PumpkinMoonMusic = true;
                    FrostMoonMusic = true;
                    LunarPillarsMusic = true;
                }
            }
        }

        [DefaultValue(false)]
        public bool DisableAll
        {
            get => false;
            set
            {
                if (value)
                {
                    DevianttWrapper.DevianttMode = DevianttMusicMode.Disabled;
                    TrojanSquirrelMusic = false;
                    KingSlimeMusic = false;
                    EyeOfCthulhuMusic = false;
                    CursedCoffinMusic = false;
                    EvilBossesMusic = false;
                    QueenBeeMusic = false;
                    SkeletronMusic = false;
                    DeerclopsMusic = false;
                    WallOfFleshMusic = false;
                    QueenSlimeMusic = false;
                    BanishedBaronMusic = false;
                    TwinsMusic = false;
                    DestroyerMusic = false;
                    SkeletronPrimeMusic = false;
                    LifelightMusic = false;
                    PlanteraMusic = false;
                    GolemMusic = false;
                    BetsyMusic = false;
                    DukeFishronMusic = false;
                    EmpressMusic = false;
                    CultistMusic = false;
                    MoonLordMusic = false;
                    ChampionsMusic = false;
                    EridanusMusic = false;
                    AbominationnMusic = false;
                    MutantMusic = false;
                    BloodMoonMusic = false;
                    SolarEclipseMusic = false;
                    MeteorZoneMusic = false;
                    OldOneArmyMusic = false;
                    GoblinInvasionMusic = false;
                    PirateInvasionMusic = false;
                    MartianMadnessMusic = false;
                    PumpkinMoonMusic = false;
                    FrostMoonMusic = false;
                    LunarPillarsMusic = false;
                }
            }
        }
    }

    public class DevianttSettings
    {
        [Slider]
        [DrawTicks]
        [DefaultValue(DevianttMusicMode.Elizabeth3)]
        public DevianttMusicMode DevianttMode = DevianttMusicMode.Elizabeth3;
    }
}


