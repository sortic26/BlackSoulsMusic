using System;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using BlackSoulsMusic;

namespace BlackSoulsMusic.Content.SceneEffects
{
    public class ChampionsMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/ChampionsTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.ChampionsMusic) return false;
            
            bool isAlive = false;
            if (ModLoader.TryGetMod("FargowiltasSouls", out Mod fargo))
            {
                string[] championNames = { 
                    "TimberChampion", "TimberChampionHead", "EarthChampion", "TerraChampion", 
                    "NatureChampion", "LifeChampion", "ShadowChampion", 
                    "SpiritChampion", "WillChampion" 
                };

                isAlive = Main.npc.Any(n => n != null && n.active && n.ModNPC != null && 
                                            n.ModNPC.Mod == fargo && championNames.Contains(n.ModNPC.Name));
            }

            if (isAlive) 
            {
                overrideTimer = 45; 
                lastTick = Main.GameUpdateCount;
                return true;
            }

            if (overrideTimer > 0) 
            { 
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead)) 
                {
                    if (Main.GameUpdateCount != lastTick)
                    {
                        overrideTimer--;
                        lastTick = Main.GameUpdateCount;
                    }
                } 
                return true; 
            }
            return false;
        }
    }

    public class EridanusMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/EridanusTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.EridanusMusic) return false;
            
            bool isAlive = false;
            if (ModLoader.TryGetMod("FargowiltasSouls", out Mod fargo))
            {
                isAlive = Main.npc.Any(n => n != null && n.active && n.ModNPC != null && n.ModNPC.Mod == fargo && n.ModNPC.Name == "CosmosChampion");
            }

            if (isAlive) 
            {
                overrideTimer = 45; 
                lastTick = Main.GameUpdateCount;
                return true;
            }

            if (overrideTimer > 0) 
            { 
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead)) 
                {
                    if (Main.GameUpdateCount != lastTick)
                    {
                        overrideTimer--;
                        lastTick = Main.GameUpdateCount;
                    }
                } 
                return true; 
            }
            return false;
        }
    }
}
