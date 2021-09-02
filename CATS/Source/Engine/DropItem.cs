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
        public List<Keys> _keys = new List<Keys>();
        float _speed;
        public bool outOfBounds = false;
        public DropItem(string PATH, Vector2 pos, Vector2 dimension, List<Keys> keys, float speed) : base(PATH, pos, dimension)
        {
            _keys.Clear();
            _keys.AddRange(keys);
            _speed = speed;
        }

        public override void Update(GameTime gameTime)
        {
            _pos = new Vector2(_pos.X, _pos.Y + _speed);
            if(_pos.Y > Globals.graphics.GraphicsDevice.Viewport.Height)
            {
                outOfBounds = true;
            }
        }
    }
}
