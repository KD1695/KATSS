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
        public AudienceCheerBar()
        {
            rect = new Texture2D(Globals.graphics.GraphicsDevice, 30, 400);
            data = new Color[30 * 400];
            coor = new Vector2(50, 150);
            currentCheer = data.Length;
        }

        public void Update(GameTime gameTime)
        {
            if(currentCheer > setCheerVal)
                currentCheer -= (int)gameTime.TotalGameTime.TotalSeconds*7;
        }

        public void Draw()
        {
            for (int i = 0; i < currentCheer; ++i) data[i] = Color.Chocolate;
            for (int i = currentCheer; i < data.Length; ++i) data[i] = Color.Red;
            rect.SetData(data);
            Globals.spriteBatch.Draw(rect, coor, Color.White);
        }

        public void SetCheerValue(int percent)
        {
            setCheerVal = data.Length - (((data.Length * percent) / 100)/30)*30;
        }
    }
}
