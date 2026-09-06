using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ModLoader;

namespace BlackSoulsMusic.Content
{
    public class MenuParticle
    {
        public Vector2 Position;
        public Vector2 Velocity;
        public float Alpha;
        public float Scale;

        public MenuParticle(Vector2 position, Vector2 velocity, float scale)
        {
            Position = position;
            Velocity = velocity;
            Scale = scale;
            Alpha = 1.0f;
        }

        public bool Update()
        {
            Position += Velocity;
            Alpha -= 0.004f;
            return Alpha > 0f;
        }
    }

    public class BlackSoulsMenu : ModMenu
    {
        public override Asset<Texture2D> Logo => ModContent.Request<Texture2D>("BlackSoulsMusic/Content/MenuLogo");
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Music/MenuTheme");
        public override string DisplayName => "Black Souls Music Menu";

        private static List<MenuParticle> particles = new List<MenuParticle>();

        public override bool PreDrawLogo(SpriteBatch spriteBatch, ref Vector2 logoDrawCenter, ref float logoRotation, ref float logoScale, ref Color logoDrawColor)
        {
            Main.dayTime = true;
            Main.time = 27000.0;

            Texture2D bookTexture = ModContent.Request<Texture2D>("BlackSoulsMusic/Content/MenuBook").Value;
            Texture2D borderTexture = ModContent.Request<Texture2D>("BlackSoulsMusic/Content/MenuBorder").Value;
            Texture2D logoTexture = Logo.Value;
            Texture2D pixel = Terraria.GameContent.TextureAssets.MagicPixel.Value;

            Rectangle screenRectangle = new Rectangle(0, 0, Main.screenWidth, Main.screenHeight);

            spriteBatch.Draw(bookTexture, screenRectangle, Color.White);

            Color particleBaseColor = Color.White;

            if (Main.rand.NextFloat() < 0.15f)
            {
                Vector2 spawnPos = new Vector2(Main.rand.Next(0, Main.screenWidth), Main.screenHeight + 10);
                Vector2 spawnVel = new Vector2(Main.rand.NextFloat(-0.5f, 0.5f), Main.rand.NextFloat(-2.0f, -0.8f));
                float size = Main.rand.NextFloat(2f, 5f);
                particles.Add(new MenuParticle(spawnPos, spawnVel, size));
            }

            for (int i = particles.Count - 1; i >= 0; i--)
            {
                MenuParticle p = particles[i];
                if (!p.Update())
                {
                    particles.RemoveAt(i);
                    continue;
                }
                Rectangle rect = new Rectangle((int)p.Position.X, (int)p.Position.Y, (int)p.Scale, (int)p.Scale);
                spriteBatch.Draw(pixel, rect, particleBaseColor * p.Alpha);
            }

            spriteBatch.Draw(borderTexture, screenRectangle, Color.White);

            float animatedScale = 0.5f + (float)Math.Cos(Main.GlobalTimeWrappedHourly * 0.8f) * 0.02f;
            float animatedRotation = (float)Math.Sin(Main.GlobalTimeWrappedHourly * 0.6f) * 0.04f;

            Vector2 logoPosition = new Vector2(Main.screenWidth / 2f, Main.screenHeight * 0.15f);
            Vector2 logoOrigin = new Vector2(logoTexture.Width / 2f, logoTexture.Height / 2f);

            spriteBatch.Draw(
                logoTexture, 
                logoPosition, 
                null, 
                Color.White, 
                animatedRotation, 
                logoOrigin, 
                animatedScale,    
                SpriteEffects.None, 
                0f
            );

            return false;
        }
    }
}
