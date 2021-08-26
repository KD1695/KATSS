using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    class DropItem : Item2D
    {
        string _key;
        public bool outOfBounds = false;
        public DropItem(string PATH, Vector2 pos, Vector2 dimension, string key) : base(PATH, pos, dimension)
        {
            _key = key;
        }

        public override void Update()
        {
            _pos = new Vector2(_pos.X, _pos.Y + 1);
            if(_pos.Y > Globals.graphics.GraphicsDevice.Viewport.Height)
            {
                outOfBounds = true;
            }
        }
    }
}
