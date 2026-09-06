using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace BlackSoulsMusic.Common.Systems 
{
    public class CreditsMusicSystem : ModSystem
    {
        public override void Load()
        {
            // Вешаем хук на обновление аудиосистемы
            Terraria.Audio.On_LegacyAudioSystem.Update += HookCreditsMusic;
        }

        public override void Unload()
        {
            // Очищаем хук при выгрузке мода, чтобы не было утечек памяти
            Terraria.Audio.On_LegacyAudioSystem.Update -= HookCreditsMusic;
        }

        private void HookCreditsMusic(Terraria.Audio.On_LegacyAudioSystem.orig_Update orig, Terraria.Audio.LegacyAudioSystem self)
        {
            // Если игра собирается включить ванильную музыку титров
            if (Main.newMusic == MusicID.Credits)
            {
                // Подменяем её на слот твоего трека
                Main.newMusic = MusicLoader.GetMusicSlot(Mod, "Content/Music/CreditsTheme");
            }

            // Продолжаем стандартное обновление звука игры
            orig(self);
        }
    }
}