using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    class Globals
    {
        public static ContentManager content;
        public static SpriteBatch spriteBatch;
        public static List<DropItem> dropItems = new List<DropItem>();
        public static GraphicsDeviceManager graphics;
    }
}
