using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    public class DrawBg
    {
        public Vector2 _pos, _dimension;
        public Texture2D bgImage;

        public DrawBg(string PATH, Vector2 pos, Vector2 dimension)
        {
            _pos = pos;
            _dimension = dimension;

            bgImage = Globals.content.Load<Texture2D>(PATH);
        }

        public void Update()
        {

        }

        public void Draw()
        {
            if(bgImage != null)
            {
                Globals.spriteBatch.Draw(bgImage, new Rectangle((int)_pos.X, (int)_pos.Y, (int)_dimension.X, (int)_dimension.Y), null, Color.White, 0.0f, new Vector2(bgImage.Bounds.X/2, bgImage.Bounds.Y/2), new SpriteEffects(), 0); 
            }    
        }
    }
}
