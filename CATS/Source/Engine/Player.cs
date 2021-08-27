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

        public Player(string PATH, Vector2 pos, Vector2 dimension, Keys left, Keys right) : base(PATH, pos, dimension)
        {
            _left = left;
            _right = right;
            //_isPlayer1 = isPlayer1;
            leftBound = _pos.X - 480;
            rightBound = _pos.X + 480;
        }

        public override void Update()
        {
            
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
        
    }
}
