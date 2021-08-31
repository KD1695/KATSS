using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    public class DropItemGenerator
    {
        int currentTime = 0;
        string dropImagePATH = "Images\\"; 
        Vector2 dropItemDimension = new Vector2(100, 100); //todo change when size is fixed
        float speed = 2f; //default speed

        public void Update(GameTime gameTime)
        {
            Random r = new Random();
            if (gameTime.TotalGameTime.TotalSeconds > currentTime)
            {
                currentTime += 2;
                
                //p1 drop
                Vector2 dropPos = new Vector2(r.Next(20, 940), 20);
                Keys p1Key = Globals.Player1KeySet[r.Next(0,3)];
                DropItem drop = new DropItem(dropImagePATH+Globals.DropItemImageList[p1Key], dropPos, dropItemDimension, p1Key, speed);
                Globals.dropItems.Add(drop);
                //p2 drop
                Vector2 dropPos2 = new Vector2(r.Next(980, 1900), 20);
                Keys p2Key = Globals.Player2KeySet[r.Next(0, 3)];
                DropItem drop2 = new DropItem(dropImagePATH + Globals.DropItemImageList[p2Key], dropPos2, dropItemDimension, p2Key, speed);
                Globals.dropItems2.Add(drop2);
            }

            foreach (var drop in Globals.dropItems)
            {
                drop.Update();
            }

            foreach (var drop in Globals.dropItems2)
            {
                drop.Update();
            }

            //add speed scaling with time

            Globals.dropItems.RemoveAll(item => item.outOfBounds);
            Globals.dropItems2.RemoveAll(item => item.outOfBounds);
        }

        public void Draw()
        {
            foreach (var drop in Globals.dropItems)
            { 
                drop.Draw();
            }

            foreach (var drop in Globals.dropItems2)
            {
                drop.Draw();
            }
        }
    }
}
