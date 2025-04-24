using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_game
{
    internal class Tile
    {
        public int size;
        private Texture2D sprite;
        private int type;

        public Tile(int size, string texture_name, int type)
        {
            this.size = size;
            sprite=Globals._contentManager.Load<Texture2D>(texture_name);
            this.type = type;
        }

        public void Draw(int x, int y)
        {
            Globals._spriteBatch.Draw(sprite, new Vector2(x * 50, y * 50), Color.White);
        }
    }
}
