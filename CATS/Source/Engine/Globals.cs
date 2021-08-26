using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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

        public static List<Keys> Player1KeySet = new List<Keys>{Keys.D1, Keys.D2, Keys.D3, Keys.D4};
        public static List<Keys> Player2KeySet = new List<Keys>{Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.NumPad6};
    }
}
