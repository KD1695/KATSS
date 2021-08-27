using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    public class DropItemGenerator
    {
        int currentTime = 0;
        string dropImagePATH = "Images\\circle";
        Vector2 dropItemDimension = new Vector2(48, 48); //todo change when size is fixed
        float speed = 2f; //default speed

        public void Update(GameTime gameTime)
        {
            Random r = new Random();
            if (gameTime.TotalGameTime.TotalSeconds > currentTime)
            {
                currentTime += 2;
                //generate twice because 2 players
                Vector2 dropPos = new Vector2(r.Next(20, 940), 20);
                DropItem drop = new DropItem(dropImagePATH, dropPos, dropItemDimension, Globals.Player1KeySet[r.Next(0,3)], speed);
                Globals.dropItems.Add(drop);
                Vector2 dropPos2 = new Vector2(r.Next(980, 1900), 20);
                DropItem drop2 = new DropItem(dropImagePATH, dropPos2, dropItemDimension, Globals.Player2KeySet[r.Next(0, 3)], speed);
                Globals.dropItems.Add(drop2);
            }

            foreach (var drop in Globals.dropItems)
            {
                drop.Update();
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
