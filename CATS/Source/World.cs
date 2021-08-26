using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    public class World
    {
        public DrawBg bg;

        public World()
        {
            bg = new DrawBg("Images\\firstLook", new Vector2(0,0), new Vector2(1920, 1080));
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
