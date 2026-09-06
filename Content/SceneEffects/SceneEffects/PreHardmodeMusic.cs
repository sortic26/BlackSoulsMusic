using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlackSoulsMusic.Content.SceneEffects
{
    public class TrojanSquirrelMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/TrojanSquirrelTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.TrojanSquirrelMusic) return false;
            bool isAlive = false;
            if (ModLoader.TryGetMod("FargowiltasSouls", out Mod fargo))
            {
                isAlive = Main.npc.Any(n => n != null && n.active && n.ModNPC != null && n.ModNPC.Mod == fargo && n.ModNPC.Name == "TrojanSquirrel");
            }
            if (isAlive) { overrideTimer = 45; lastTick = Main.GameUpdateCount; return true; }
            if (overrideTimer > 0)
            {
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead) && Main.GameUpdateCount != lastTick)
                {
                    overrideTimer--; lastTick = Main.GameUpdateCount;
                }
                return true;
            }
            return false;
        }
    }

    public class KingSlimeMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/KingSlimeTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.KingSlimeMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == NPCID.KingSlime);
            if (isAlive) { overrideTimer = 45; lastTick = Main.GameUpdateCount; return true; }
            if (overrideTimer > 0)
            {
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead) && Main.GameUpdateCount != lastTick)
                {
                    overrideTimer--; lastTick = Main.GameUpdateCount;
                }
                return true;
            }
            return false;
        }
    }

    public class EyeOfCthulhuMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/EyeOfCthulhuTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.EyeOfCthulhuMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == NPCID.EyeofCthulhu);
            if (isAlive) { overrideTimer = 45; lastTick = Main.GameUpdateCount; return true; }
            if (overrideTimer > 0)
            {
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead) && Main.GameUpdateCount != lastTick)
                {
                    overrideTimer--; lastTick = Main.GameUpdateCount;
                }
                return true;
            }
            return false;
        }
    }

    public class CursedCoffinMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/CursedCoffinTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.CursedCoffinMusic) return false;
            bool isAlive = false;
            if (ModLoader.TryGetMod("FargowiltasSouls", out Mod fargo))
            {
                isAlive = Main.npc.Any(n => n != null && n.active && n.ModNPC != null && n.ModNPC.Mod == fargo && n.ModNPC.Name == "CursedCoffin");
            }
            if (isAlive) { overrideTimer = 45; lastTick = Main.GameUpdateCount; return true; }
            if (overrideTimer > 0)
            {
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead) && Main.GameUpdateCount != lastTick)
                {
                    overrideTimer--; lastTick = Main.GameUpdateCount;
                }
                return true;
            }
            return false;
        }
    }

    public class EvilBossesMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/EvilBossTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.EvilBossesMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && (n.type == NPCID.EaterofWorldsHead || n.type == NPCID.EaterofWorldsBody || n.type == NPCID.EaterofWorldsTail || n.type == NPCID.BrainofCthulhu));
            if (isAlive) { overrideTimer = 45; lastTick = Main.GameUpdateCount; return true; }
            if (overrideTimer > 0)
            {
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead) && Main.GameUpdateCount != lastTick)
                {
                    overrideTimer--; lastTick = Main.GameUpdateCount;
                }
                return true;
            }
            return false;
        }
    }

    public class QueenBeeMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/QueenBeeTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.QueenBeeMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == NPCID.QueenBee);
            if (isAlive) { overrideTimer = 45; lastTick = Main.GameUpdateCount; return true; }
            if (overrideTimer > 0)
            {
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead) && Main.GameUpdateCount != lastTick)
                {
                    overrideTimer--; lastTick = Main.GameUpdateCount;
                }
                return true;
            }
            return false;
        }
    }

    public class SkeletronMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/SkeletronTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.SkeletronMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == NPCID.SkeletronHead);
            if (isAlive) { overrideTimer = 45; lastTick = Main.GameUpdateCount; return true; }
            if (overrideTimer > 0)
            {
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead) && Main.GameUpdateCount != lastTick)
                {
                    overrideTimer--; lastTick = Main.GameUpdateCount;
                }
                return true;
            }
            return false;
        }
    }

    public class DeerclopsMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/DeerclopsTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.DeerclopsMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == NPCID.Deerclops);
            if (isAlive) { overrideTimer = 45; lastTick = Main.GameUpdateCount; return true; }
            if (overrideTimer > 0)
            {
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead) && Main.GameUpdateCount != lastTick)
                {
                    overrideTimer--; lastTick = Main.GameUpdateCount;
                }
                return true;
            }
            return false;
        }
    }

    public class WallOfFleshMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        private ulong lastTick = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/WallOfFleshTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.WallOfFleshMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == NPCID.WallofFlesh);
            if (isAlive) { overrideTimer = 45; lastTick = Main.GameUpdateCount; return true; }
            if (overrideTimer > 0)
            {
                if (!(Main.LocalPlayer.active && Main.LocalPlayer.dead) && Main.GameUpdateCount != lastTick)
                {
                    overrideTimer--; lastTick = Main.GameUpdateCount;
                }
                return true;
            }
            return false;
        }
    }
}

