using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace KATSS
{
    class GameOverScreen : Item2D
    {
        Color transparent = new Color(0,0,0,0);
        Color show = new Color(255, 255, 255, 255);
        Texture2D p1;
        Texture2D p2;

        public GameOverScreen(string PATH, Vector2 pos, Vector2 dimension) : base(PATH, pos, dimension)
        {
            color = transparent;
            p1 = Globals.content.Load<Texture2D>("Images\\KATUS");
            p2 = Globals.content.Load<Texture2D>("Images\\TUM");
        }

        public void EndGame(string winner)
        {
            if (winner == "p1")
                image = p1;
            else
                image = p2;

            color = show;
        }
    }
}
