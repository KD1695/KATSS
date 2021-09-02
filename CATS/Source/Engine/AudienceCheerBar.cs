using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    public class AudienceCheerBar
    {
        Texture2D rect;
        Vector2 coor;
        Color[] data;
        int currentCheer;
        int setCheerVal;
        Texture2D texture;
        Vector2 _texPosition;
        Vector2 _dimension;

        public AudienceCheerBar(Vector2 texPosition)
        {
            _texPosition = texPosition;
            rect = new Texture2D(Globals.graphics.GraphicsDevice, 28, 625);
            data = new Color[28 * 625];
            coor = new Vector2(texPosition.X + 82, 155);
            currentCheer = data.Length;
            setCheerVal = data.Length;

            texture = Globals.content.Load<Texture2D>("Images\\Audience_Bar_blank");
            _dimension = new Vector2(208.5f, 769.5f);
        }

        public void Update(GameTime gameTime)
        {
            if (currentCheer > setCheerVal)
                currentCheer -= (int)gameTime.TotalGameTime.TotalSeconds * 7;

            if (currentCheer < setCheerVal)
                currentCheer += (int)gameTime.TotalGameTime.TotalSeconds * 7;
        }

        public void Draw()
        {
            for (int i = 0; i < currentCheer; i++)
            {
                if (i >= data.Length)
                    break;
                data[i] = Color.Transparent;
            }
            for (int i = currentCheer; i < data.Length; i++)
            {
                if (i < 0)
                    break;
                data[i] = Color.Red;
            }
            rect.SetData(data);
            Globals.spriteBatch.Draw(rect, coor, Color.White);
            Globals.spriteBatch.Draw(texture, new Rectangle((int)_texPosition.X, (int)_texPosition.Y, (int)_dimension.X, (int)_dimension.Y), null, Color.White, 0.0f, new Vector2(texture.Bounds.X / 2, texture.Bounds.Y / 2), new SpriteEffects(), 1);
        }

        public void SetCheerValue(int percent)
        {
            setCheerVal = data.Length - (((data.Length * percent) / 100)/30)*30;
        }
    }
}
