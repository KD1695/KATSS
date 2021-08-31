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
        public static List<DropItem> dropItems2 = new List<DropItem>();
        public static GraphicsDeviceManager graphics;

        public static List<Keys> Player1KeySet = new List<Keys>{Keys.D1, Keys.D2, Keys.D3, Keys.D4};
        public static List<Keys> Player2KeySet = new List<Keys>{Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.NumPad6};
        public static Dictionary<Keys,string> DropItemImageList = new Dictionary<Keys, string> 
                                                                {
                                                                    {Keys.D1, "icon1"},
                                                                    {Keys.D2, "icon2"},
                                                                    {Keys.D3, "icon3"},
                                                                    {Keys.D4, "icon4"},
                                                                    {Keys.NumPad6, "icon6"},
                                                                    {Keys.NumPad7, "icon7"},
                                                                    {Keys.NumPad8, "icon8"},
                                                                    {Keys.NumPad9, "icon9"}
                                                                };

        public static Dictionary<Keys, string> PoseImageList = new Dictionary<Keys, string>
                                                                {
                                                                    {Keys.D1, "pose"},
                                                                    {Keys.D2, "pose1"},
                                                                    {Keys.D3, "pose2"},
                                                                    {Keys.D4, "pose3"},
                                                                    {Keys.NumPad6, "pose"},
                                                                    {Keys.NumPad7, "pose1"},
                                                                    {Keys.NumPad8, "pose2"},
                                                                    {Keys.NumPad9, "pose3"}
                                                                };
        /*
        public static Dictionary<Keys, Texture2D> PoseTextureList = new Dictionary<Keys, Texture2D>
                                                                {
                                                                    {Keys.D1, Globals.content.Load<Texture2D>("Image\\pose")},
                                                                    {Keys.D2, Globals.content.Load<Texture2D>("Image\\pose1")},
                                                                    {Keys.D3, Globals.content.Load<Texture2D>("Image\\pose2")},
                                                                    {Keys.D4, Globals.content.Load<Texture2D>("Image\\pose3")},
                                                                    {Keys.NumPad6, Globals.content.Load<Texture2D>("Image\\pose")},
                                                                    {Keys.NumPad7, Globals.content.Load<Texture2D>("Image\\pose1")},
                                                                    {Keys.NumPad8, Globals.content.Load<Texture2D>("Image\\pose2")},
                                                                    {Keys.NumPad9, Globals.content.Load<Texture2D>("Image\\pose3")}
                                                                };*/
    }
}
