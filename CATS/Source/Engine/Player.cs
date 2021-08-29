using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace KATSS
{
    public class Player : Item2D
    {
        public Keys _left;
        public Keys _right;
        public int move = 5;
        float leftBound;
        float rightBound;
        int width = 5;
        int dif = 2;
        int height = 5;

        public Player(string PATH, Vector2 pos, Vector2 dimension, Keys left, Keys right) : base(PATH, pos, dimension)
        {
            _left = left;
            _right = right;
            leftBound = _pos.X - 480;
            rightBound = _pos.X + 480;
        }

        public override void Update()
        {

            CollisionDetect();

            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(_left))
            {
                _pos.X -= move;
            }

            if (state.IsKeyDown(_right))
            {
                _pos.X += move;
            }

            _pos.X = MathHelper.Clamp(_pos.X, leftBound, rightBound);
        }

        void CollisionDetect()
        {
            foreach (var drop in Globals.dropItems)
            {
                if (Math.Abs(drop._pos.X - _pos.X) < width && Math.Abs(drop._pos.Y - (_pos.Y - dif)) < height)
                    CheckKey(drop._key);
            }

        }

        void CheckKey(Keys key)
        {
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(key))
            {
                //change player pose
                //add audio bar
            }
            else
            {
                //change player pose to failed pic
            }

        }
        
    }
}
