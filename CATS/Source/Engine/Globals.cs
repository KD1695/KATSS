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
        //public static List<DropItem> dropItems2 = new List<DropItem>();
        public static GraphicsDeviceManager graphics;

        public static int cheerP1 = 0;
        public static int cheerP2 = 0;

        public static List<Keys> Player1KeySet = new List<Keys>{Keys.D1, Keys.D2, Keys.D3, Keys.D4};
        public static List<Keys> Player2KeySet = new List<Keys>{Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4};
        public static Dictionary<Keys,string> DropItemImageList = new Dictionary<Keys, string> 
                                                                {
                                                                    {Keys.D1, "icon1"},
                                                                    {Keys.D2, "icon2"},
                                                                    {Keys.D3, "icon3"},
                                                                    {Keys.D4, "icon4"},
                                                                    {Keys.NumPad1, "icon1"},
                                                                    {Keys.NumPad2, "icon2"},
                                                                    {Keys.NumPad3, "icon3"},
                                                                    {Keys.NumPad4, "icon4"}
                                                                };

        public static Dictionary<Keys, string> PoseImageList = new Dictionary<Keys, string>
                                                                {
                                                                    {Keys.D1, "pose"},
                                                                    {Keys.D2, "pose1"},
                                                                    {Keys.D3, "pose2"},
                                                                    {Keys.D4, "pose3"},
                                                                    {Keys.NumPad1, "cat 2 p1"},
                                                                    {Keys.NumPad2, "cat 2 p2"},
                                                                    {Keys.NumPad3, "cat 2 p3"},
                                                                    {Keys.NumPad4, "cat 2 p4"}
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
