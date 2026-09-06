using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlackSoulsMusic.Content.SceneEffects
{
    public class QueenSlimeMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/QueenSlimeTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.QueenSlimeMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == 657);
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class BanishedBaronMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/BanishedBaronTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.BanishedBaronMusic) return false;
            bool isAlive = false;
            if (ModLoader.TryGetMod("FargowiltasSouls", out Mod fargo))
            {
                isAlive = Main.npc.Any(n => n != null && n.active && n.ModNPC != null && n.ModNPC.Mod == fargo && n.ModNPC.Name == "BanishedBaron");
            }
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class TwinsMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/TwinsTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.TwinsMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && (n.type == 125 || n.type == 126));
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class DestroyerMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/DestroyerTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.DestroyerMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == 134);
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class SkeletronPrimeMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/SkeletronPrimeTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.SkeletronPrimeMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == 127);
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class LifelightMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/LifelightTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.LifelightMusic) return false;
            bool isAlive = false;
            if (ModLoader.TryGetMod("FargowiltasSouls", out Mod fargo))
            {
                isAlive = Main.npc.Any(n => n != null && n.active && n.ModNPC != null && n.ModNPC.Mod == fargo && n.ModNPC.Name == "LifeChallenger");
            }
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class PlanteraMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/PlanteraTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.PlanteraMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == 262);
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class GolemMusic : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/GolemTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.GolemMusic) return false;
            bool isBossAlive = Main.npc.Any(npc => npc != null && npc.active && npc.type == NPCID.Golem);
            if (isBossAlive) overrideTimer = 120;
            if (overrideTimer > 0) { if (!isBossAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class BetsyMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/BetsyTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.BetsyMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == 551);
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class DukeFishronMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/DukeFishronTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.DukeFishronMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == 370);
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class EmpressMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/EmpressTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.EmpressMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == 636);
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class CultistMusicScene : ModSceneEffect
    {
        private int overrideTimer = 0;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override float GetWeight(Player player) => 0.6f;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/CultistTheme");

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.CultistMusic) return false;
            bool isAlive = Main.npc.Any(n => n != null && n.active && n.type == 439);
            if (isAlive) overrideTimer = 60;
            if (overrideTimer > 0) { if (!isAlive && !(Main.LocalPlayer.active && Main.LocalPlayer.dead)) overrideTimer--; return true; }
            return false;
        }
    }

    public class MoonLordMusic : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh; 
        public override float GetWeight(Player player) => 0.6f; 
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/MoonLordTheme"); 

        public override bool IsSceneEffectActive(Player player)
        {
            if (MusicConfig.Instance != null && !MusicConfig.Instance.MoonLordMusic) return false; 
            return Main.npc.Any(npc => npc != null && npc.active && (npc.type == NPCID.MoonLordHead || npc.type == NPCID.MoonLordCore || npc.type == NPCID.MoonLordHand));
        }
    }
}
