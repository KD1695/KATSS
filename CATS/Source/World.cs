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

        public World()
        {
            bg = new Item2D("Images\\firstLook", new Vector2(0,0), new Vector2(1920, 1080));
            player1 = new Player("character_wire_frame", new Vector2(300, 800), new Vector2(106,202), Keys.Left, Keys.Right);
        }

        public void Update()
        {
            player1.Update();
        }

        public void Draw()
        {
            bg.Draw();
            player1.Draw();
        }
    }
}
