using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_game
{
    internal class Beam
    {
        public Texture2D sprite;
        public Vector2 position;
        public double rotation;
        public bool used;

        public Beam(Vector2 position, string spriteName) 
        {
            this.position = position;
            used = false;
            rotation = 0.0d;
            sprite = Globals._contentManager.Load<Texture2D>(spriteName);
        }

        public void Draw()
        {
            if (used)
            Globals._spriteBatch.Draw(sprite, new Rectangle((int)position.X, (int)position.Y, sprite.Width, sprite.Height), null, Color.White, (float)rotation, new Vector2(sprite.Width / 2, 0), SpriteEffects.None, 0);
        }
    }
}
