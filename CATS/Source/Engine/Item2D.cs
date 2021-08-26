using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    public class Item2D
    {
        public Vector2 _pos, _dimension;
        public Texture2D image;

        public Item2D(string PATH, Vector2 pos, Vector2 dimension)
        {
            _pos = pos;
            _dimension = dimension;

            image = Globals.content.Load<Texture2D>(PATH);
        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {
            if(image != null)
            {
                Globals.spriteBatch.Draw(image, new Rectangle((int)_pos.X, (int)_pos.Y, (int)_dimension.X, (int)_dimension.Y), null, Color.White, 0.0f, new Vector2(image.Bounds.X/2, image.Bounds.Y/2), new SpriteEffects(), 0); 
            }    
        }
    }
}
