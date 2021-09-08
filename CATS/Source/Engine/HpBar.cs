using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    public class HpBar
    {
        Texture2D rect;
        Vector2 coor;
        Color[] data;
        int skipIndexLength;
        int hpBarValue;
        Texture2D texture;
        Vector2 _texPosition;
        Vector2 _dimension;

        public HpBar(Vector2 texPosition)
        {
            _texPosition = texPosition;
            rect = new Texture2D(Globals.graphics.GraphicsDevice, 260, 30);
            data = new Color[260 * 30];
            coor = new Vector2(texPosition.X + 71, texPosition.Y + 34);
            skipIndexLength = data.Length;
            hpBarValue = data.Length;

            texture = Globals.content.Load<Texture2D>("Images\\HP Bar Ver2 blank");
            _dimension = new Vector2(335, 100);
        }

        public void Update(GameTime gameTime)
        {
            skipIndexLength = hpBarValue == 0 ? 1 : hpBarValue;
        }

        public void Draw()
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((i % 260)/skipIndexLength >= 1)
                {
                    data[i] = Color.Transparent;
                    continue;
                }
                data[i] = Color.YellowGreen;
            }

            rect.SetData(data);
            Globals.spriteBatch.Draw(rect, coor, Color.White);
            Globals.spriteBatch.Draw(texture, new Rectangle((int)_texPosition.X, (int)_texPosition.Y, (int)_dimension.X, (int)_dimension.Y), null, Color.White, 0.0f, new Vector2(texture.Bounds.X / 2, texture.Bounds.Y / 2), new SpriteEffects(), 1);
        }

        public void SetHpValue(float val)
        {
            if (val < 0)
                val = 0;
            hpBarValue = (int)(260 * val / 1000);
        }
    }
}
