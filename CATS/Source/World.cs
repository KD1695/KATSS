using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace KATSS
{
    public class World
    {
        public Item2D bg;
        public Player player1;
        public Player player2;
        public DropItemGenerator itemGenerator = new DropItemGenerator();
        public AudienceCheerBar bar1 = new AudienceCheerBar(new Vector2(-20, 150));
        public AudienceCheerBar bar2 = new AudienceCheerBar(new Vector2(1750, 150));
        public HpBar hPBar1 = new HpBar(new Vector2(30, 50));
        public HpBar hPBar2 = new HpBar(new Vector2(1615, 50));

        public World()
        {
            bg = new Item2D("Images\\background", new Vector2(0,0), new Vector2(1920, 1080));
            player1 = new Player("Images\\front", new Vector2(318, 440), new Vector2(388,478), Keys.A, Keys.D, true);
            player2 = new Player("Images\\cat2 front", new Vector2(1278, 440), new Vector2(388, 478), Keys.Left, Keys.Right, false);
            bar1.SetCheerValue(0);
            bar2.SetCheerValue(0);
        }

        public void Update(GameTime gameTime)
        {
            if(Globals.cheerP1 >= 0)
            {
                bar1.SetCheerValue(Globals.cheerP1);
            }
            if (Globals.cheerP2 >= 0)
            {
                bar2.SetCheerValue(Globals.cheerP2);
            }
            hPBar1.SetHpValue(Globals.hpP1);
            hPBar2.SetHpValue(Globals.hpP2);

            float damageScale = Math.Abs(player1._pos.X - player2._pos.X) / 10;
            float damage = 700 / ((damageScale < 1) ? 1 : damageScale);
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.Space) && Globals.cheerP1 >= 50)
            {
                player1.SuperPose();
                Globals.hpP2-= damage;
                Globals.cheerP1 -= 50;
            }
            if (state.IsKeyDown(Keys.Enter) && Globals.cheerP2 >= 50)
            {
                player2.SuperPose();
                Globals.hpP1 -= damage;
                Globals.cheerP2 -= 50;
            }

            bar1.Update(gameTime);
            bar2.Update(gameTime);
            hPBar1.Update(gameTime);
            hPBar2.Update(gameTime);
            player1.Update(gameTime);
            player2.Update(gameTime);
            itemGenerator.Update(gameTime);
        }

        public void Draw()
        {
            bg.Draw();
            bar1.Draw();
            bar2.Draw();
            hPBar1.Draw();
            hPBar2.Draw();
            player1.Draw();
            player2.Draw();
            itemGenerator.Draw();
        }
    }
}
