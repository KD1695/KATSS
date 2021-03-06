using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace KATSS
{
    public class Player : Item2D
    {
        public Keys _left;
        public Keys _right;
        public int move = 10;
        float leftBound;
        float rightBound;
        int width = 80;
        int upperBound = 800;
        int lowerBound = 600;
        int playerWidth = 162;
        int itemWidth = 50;
        string path = "Images\\";
        bool _isPlayer1;
        Texture2D neutralPose;
        float poseDuration = 0.7f;
        float currentTime = 0.0f;
        bool isPose = false;

        public Dictionary<Keys, Texture2D> PoseTextureList = new Dictionary<Keys, Texture2D>{};
        Texture2D superPose;
        List<SoundEffect> soundEffects;

        public Player(string PATH, Vector2 pos, Vector2 dimension, Keys left, Keys right, bool isPlayer1) : base(PATH, pos, dimension)
        {
            _left = left;
            _right = right;
            leftBound = - 80;
            rightBound = 1920 - 240;
            _isPlayer1 = isPlayer1;
            neutralPose = Globals.content.Load<Texture2D>(PATH);
            superPose = (_isPlayer1) ? Globals.content.Load<Texture2D>("Images\\attack pose") : Globals.content.Load<Texture2D>("Images\\cat 2 attack pose");

            soundEffects = new List<SoundEffect>();
            soundEffects.Add(Globals.content.Load<SoundEffect>("Audio\\AttackBurst"));
            soundEffects.Add(Globals.content.Load<SoundEffect>("Audio\\Medium Crowd Cheer"));
            //soundEffects.Add(Globals.content.Load<SoundEffect>("Audio\\Get Hit"));
            
            if (isPlayer1)
            {
                foreach(Keys k in Globals.Player1KeySet)
                {
                    Texture2D im = Globals.content.Load<Texture2D>(path + Globals.PoseImageList[k]);
                    PoseTextureList.Add(k, im);
                }
            }
            else
            {
                foreach (Keys k in Globals.Player2KeySet)
                {
                    Texture2D im = Globals.content.Load<Texture2D>(path + Globals.PoseImageList[k]);
                    PoseTextureList.Add(k, im);
                }
            }
        }

        public override void Update(GameTime gameTime)
        {
            if (Globals.isEndGame) return;

            if (isPose) {
                currentTime += (float)gameTime.ElapsedGameTime.TotalSeconds; //Time passed since last Update() 
                if (currentTime >= poseDuration)
                {
                    color = Color.White;
                    isPose = false;
                    currentTime = 0;
                    image = neutralPose;
                }
            }
            
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
                if ((drop._pos.Y + itemWidth) < upperBound && (drop._pos.Y + itemWidth) > lowerBound && Math.Abs((drop._pos.X + itemWidth) - (_pos.X + playerWidth)) < width)
                    CheckKey(drop);

            }
        }

        void CheckKey(DropItem drop)
        {
            //Debug.WriteLine(key.ToString());

            KeyboardState state = Keyboard.GetState();

            if (_isPlayer1)
            {
                if (Globals.Player1KeySet.Any(key => state.IsKeyDown(key)))
                {
                    if (drop._keys.Any(key => state.IsKeyDown(key)))
                    {
                        soundEffects[1].CreateInstance().Play();
                        image = PoseTextureList[drop._keys[0]];
                        drop.outOfBounds = true;
                        Globals.cheerP1 = (Globals.cheerP1 + 25) > 100 ? 100 : Globals.cheerP1 + 25;
                        isPose = true;
                    }
                    else
                    {
                        //change player pose to failed pic
                    }
                }
            }
            else
            {
                if (Globals.Player2KeySet.Any(key => state.IsKeyDown(key)))
                {
                    if (drop._keys.Any(key => state.IsKeyDown(key)))
                    {
                        soundEffects[1].CreateInstance().Play();
                        image = PoseTextureList[drop._keys[1]];
                        drop.outOfBounds = true;
                        isPose = true;
                        Globals.cheerP2 = (Globals.cheerP2 + 25) > 100 ? 100 : Globals.cheerP2 + 25;
                    }
                    else
                    {
                        //change player pose to failed pic
                    }
                }
            }
        }

        public void SuperPose()
        {
            image = superPose;
            soundEffects[0].CreateInstance().Play();
            isPose = true;
        }

        public void DamagePose()
        {
            color = new Color(178,34,34,150);
            isPose = true;
        }
    }
}
