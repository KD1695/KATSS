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
            player1 = new Player("Images\\character_wire_frame", new Vector2(480, 800), new Vector2(106,202), Keys.A, Keys.D);
            player2 = new Player("Images\\character_wire_frame", new Vector2(1440, 800), new Vector2(106, 202), Keys.Left, Keys.Right);
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
