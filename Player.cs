using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace base_game
{
    internal class Player
    {
        public Vector2 position;
        public Texture2D sprite;
        private float speed=10;

        public Player(Vector2 position, string textureName) 
        {
            this.position = position;
            sprite = Globals._contentManager.Load<Texture2D>(textureName);
        }

        public void Move(KeyboardState _state)
        {
            if (_state.IsKeyDown(Keys.Right)) position.X += speed;
            if (_state.IsKeyDown(Keys.Left)) position.X -= speed;
            if (_state.IsKeyDown(Keys.Up)) position.Y -= speed;
            if (_state.IsKeyDown(Keys.Down)) position.Y += speed;
        }

        public void Draw()
        {
            Globals._spriteBatch.Draw(sprite, position, Color.White);
        }
    }
}
