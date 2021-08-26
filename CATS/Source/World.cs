using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    public class World
    {
        public Item2D bg;

        public World()
        {
            bg = new Item2D("Images\\firstLook", new Vector2(0,0), new Vector2(1920, 1080));
        }

        public void Update()
        {

        }

        public void Draw()
        {
            bg.Draw();
        }
    }
}
