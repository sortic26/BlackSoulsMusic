using System;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.Audio;
using Terraria.ModLoader;
using BlackSoulsMusic;

namespace BlackSoulsMusic.Content.SceneEffects
{
    public class FargoLowLevelMusicSystem : ModSystem
    {
        private static int abominationnType = -1;
        private static int mutantBossType = -1;
        private static bool checkedFargoTypes = false;

        public static int CurrentAbomPhase = 1;
        public static int CurrentMutantPhase = 1;

        private const BindingFlags UniversalBindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

        public override void Load()
        {
            MethodInfo updateMethod = typeof(LegacyAudioSystem).GetMethod("Update", UniversalBindingFlags);
            if (updateMethod != null)
            {
                MonoModHooks.Add(updateMethod, Update_Detour);
            }
        }

        private static void InitializeFargoTypes()
        {
            if (checkedFargoTypes) return;
            checkedFargoTypes = true;

            if (ModLoader.TryGetMod("FargowiltasSouls", out Mod fargo))
            {
                if (fargo.TryFind<ModNPC>("AbomBoss", out ModNPC abom)) abominationnType = abom.Type;
                if (fargo.TryFind<ModNPC>("MutantBoss", out ModNPC mutant)) mutantBossType = mutant.Type;
            }
        }

        public delegate void Orig_Update(LegacyAudioSystem self);

        internal static void Update_Detour(Orig_Update orig, LegacyAudioSystem self)
        {
            if (Main.gameMenu) 
            {
                CurrentAbomPhase = 1;
                CurrentMutantPhase = 1;
                orig(self);
                return;
            }

            InitializeFargoTypes();
            Mod myMod = ModLoader.GetMod("BlackSoulsMusic"); 

            if (abominationnType != -1)
            {
                NPC npc = Main.npc.FirstOrDefault(n => n != null && n.active && n.type == abominationnType);
                if (npc != null)
                {
                    float lifePercent = (float)npc.life / npc.lifeMax;

                    if (CurrentAbomPhase == 1)
                    {
                        bool internalAbomPhase2 = false;
                        if (npc.ModNPC != null)
                        {
                            try
                            {
                                FieldInfo p2Field = npc.ModNPC.GetType().GetField("Phase2", UniversalBindingFlags);
                                if (p2Field != null) internalAbomPhase2 = (bool)p2Field.GetValue(npc.ModNPC);
                            }
                            catch { }
                        }

                        if (internalAbomPhase2 || npc.ai[0] == 5f || (npc.dontTakeDamage && lifePercent <= 0.70f) || lifePercent <= 0.65f)
                        {
                            CurrentAbomPhase = 2;
                        }
                    }

                    if (CurrentAbomPhase == 2)
                    {
                        Main.newMusic = MusicLoader.GetMusicSlot(myMod, "Content/Music/AbominationnPhase2");
                    }
                    else
                    {
                        Main.newMusic = MusicLoader.GetMusicSlot(myMod, "Content/Music/AbominationnPhase1");
                    }
                    orig(self);
                    return; 
                }
                else
                {
                    CurrentAbomPhase = 1;
                }
            }
            if (mutantBossType != -1)
            {
                NPC npc = Main.npc.FirstOrDefault(n => n != null && n.active && n.type == mutantBossType);
                if (npc != null)
                {
                    float lifePercent = (float)npc.life / npc.lifeMax;

                    if (CurrentMutantPhase != 3)
                    {
                        bool internalIsDesperation = false;
                        bool internalIsPhase2 = false;

                        if (npc.ModNPC != null)
                        {
                            try
                            {
                                FieldInfo immuneField = npc.ModNPC.GetType().GetField("FullyImmune", UniversalBindingFlags);
                                if (immuneField != null) internalIsDesperation = (bool)immuneField.GetValue(npc.ModNPC);

                                FieldInfo p2Field = npc.ModNPC.GetType().GetField("Phase2", UniversalBindingFlags);
                                if (p2Field != null) internalIsPhase2 = (bool)p2Field.GetValue(npc.ModNPC);
                            }
                            catch { }
                        }

                        if (internalIsDesperation || npc.life <= 1 || (npc.dontTakeDamage && CurrentMutantPhase == 2 && npc.ai[0] == 0f))
                        {
                            CurrentMutantPhase = 3;
                        }
                        else if (CurrentMutantPhase == 1 && (npc.ai[0] == 10f || lifePercent <= 0.66f || internalIsPhase2))
                        {
                            CurrentMutantPhase = 2;
                        }
                    }

                    if (MusicConfig.Instance != null && !MusicConfig.Instance.MutantMusic)
                    {
                        orig(self);
                        return;
                    }

                    if (CurrentMutantPhase == 3)
                    {
                        bool isLegendary = Main.zenithWorld || Main.getGoodWorld;

                        if (Main.masterMode && isLegendary)
                        {
                            Main.newMusic = MusicLoader.GetMusicSlot(myMod, "Content/Music/MutantPhase3_Legendary");
                        }
                        else if (Main.masterMode)
                        {
                            Main.newMusic = MusicLoader.GetMusicSlot(myMod, "Content/Music/MutantPhase3_2");
                        }
                        else
                        {
                            Main.newMusic = MusicLoader.GetMusicSlot(myMod, "Content/Music/MutantPhase3_1");
                        }
                    }
                    else if (CurrentMutantPhase == 2)
                    {
                        if (Main.masterMode)
                        {
                            Main.newMusic = MusicLoader.GetMusicSlot(myMod, "Content/Music/MutantPhase2_2");
                        }
                        else
                        {
                            Main.newMusic = MusicLoader.GetMusicSlot(myMod, "Content/Music/MutantPhase2_1");
                        }
                    }
                    else
                    {
                        Main.newMusic = MusicLoader.GetMusicSlot(myMod, "Content/Music/MutantPhase1");
                    }
                    orig(self);
                    return;
                }
                else
                {
                    CurrentMutantPhase = 1;
                }
            }

            orig(self);
        }
    }
}




