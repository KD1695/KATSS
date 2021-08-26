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

        public Player(string PATH, Vector2 pos, Vector2 dimension, Keys left, Keys right) : base(PATH, pos, dimension)
        {
            _left = left;
            _right = right;
        }

        public override void Update()
        {
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(_left))
                _pos.X -= move;
            if (state.IsKeyDown(_right))
                _pos.X += move;

        }
        
    }
}
