using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    class DropItem : Item2D
    {
        Keys _key;
        float _speed;
        public bool outOfBounds = false;
        public DropItem(string PATH, Vector2 pos, Vector2 dimension, Keys key, float speed) : base(PATH, pos, dimension)
        {
            _key = key;
            _speed = speed;
        }

        public override void Update()
        {
            _pos = new Vector2(_pos.X, _pos.Y + _speed);
            if(_pos.Y > Globals.graphics.GraphicsDevice.Viewport.Height)
            {
                outOfBounds = true;
            }
        }
    }
}
