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

        public World()
        {
            bg = new Item2D("Images\\background", new Vector2(0,0), new Vector2(1920, 1080));
            player1 = new Player("Images\\front", new Vector2(318, 500), new Vector2(324,399), Keys.A, Keys.D, true);
            player2 = new Player("Images\\front", new Vector2(1278, 500), new Vector2(324, 399), Keys.Left, Keys.Right, false);
        }

        public void Update(GameTime gameTime)
        {
            player1.Update();
            player2.Update();
            itemGenerator.Update(gameTime);
        }

        public void Draw()
        {
            bg.Draw();
            player1.Draw();
            player2.Draw();
            itemGenerator.Draw();
        }
    }
}
