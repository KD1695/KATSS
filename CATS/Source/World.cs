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

        public World()
        {
            bg = new Item2D("Images\\background", new Vector2(0,0), new Vector2(1920, 1080));
            player1 = new Player("Images\\front", new Vector2(318, 500), new Vector2(324,399), Keys.A, Keys.D, true);
            player2 = new Player("Images\\front", new Vector2(1278, 500), new Vector2(324, 399), Keys.Left, Keys.Right, false);
            bar1.SetCheerValue(99);
            bar2.SetCheerValue(99);
        }

        public void Update(GameTime gameTime)
        {
            bar1.Update(gameTime);
            bar2.Update(gameTime);
            player1.Update();
            player2.Update();
            itemGenerator.Update(gameTime);
        }

        public void Draw()
        {
            bg.Draw();
            bar1.Draw();
            bar2.Draw();
            player1.Draw();
            player2.Draw();
            itemGenerator.Draw();
        }
    }
}
