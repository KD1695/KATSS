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
        
        public void Update(GameTime gameTime)
        {
            if (gameTime.TotalGameTime.TotalSeconds > currentTime)
            {
                currentTime += 2;
                //generate twice because 2 players
                Vector2 dropPos = new Vector2(50,10); //todo randomize x
                DropItem drop = new DropItem(dropImagePATH, dropPos, dropItemDimension, ""); //todo randomize key input from set
                Globals.dropItems.Add(drop);
            }

            foreach (var drop in Globals.dropItems)
            {
                drop.Update();
            }
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
