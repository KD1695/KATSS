using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    public class DropItemGenerator
    {
        float currentTime = 0;
        string dropImagePATH = "Images\\"; 
        Vector2 dropItemDimension = new Vector2(100, 100); //todo change when size is fixed
        float speed = 2f; //default speed
        Random random = new Random();

        public void Update(GameTime gameTime)
        {
            Random r = new Random();
            if (gameTime.TotalGameTime.TotalSeconds > currentTime)
            {
                currentTime += 1.25f;

                speed = random.Next(3,6);
                //p1 drop
                Vector2 dropPos = new Vector2(r.Next(100, 1820), 20);
                int newKeyIndex = r.Next(0, 3);
                List<Keys> p1Key = new List<Keys> { Globals.Player1KeySet[newKeyIndex], Globals.Player2KeySet[newKeyIndex] };
                DropItem drop = new DropItem(dropImagePATH+Globals.DropItemImageList[Globals.Player1KeySet[newKeyIndex]], dropPos, dropItemDimension, p1Key, speed);
                Globals.dropItems.Add(drop);
            }

            foreach (var drop in Globals.dropItems)
            {
                drop.Update(gameTime);
            }

            //add speed scaling with time

            Globals.dropItems.RemoveAll(item => item.outOfBounds);
        }

        public void Draw()
        {
            foreach (var drop in Globals.dropItems)
            { 
                drop.Draw();
            }
        }
    }
}
