using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace base_game
{
    internal class View
    {
        private Matrix _translation;
        public Texture2D bg;
        public View() 
        {
            bg = Globals._contentManager.Load<Texture2D>("Flag_of_Burma_(1948–1974).svg");
        }

        public void CalculateTranslation(Vector2 _position)
        {
            var dx = Globals._graphics.PreferredBackBufferWidth / 2 - _position.X;
            var dy = Globals._graphics.PreferredBackBufferHeight / 2 - _position.Y;
            _translation = Matrix.CreateTranslation(dx, dy, 0f);
        }

        public void Draw()
        {
            Globals._spriteBatch.Begin(transformMatrix: _translation);
            //Globals._spriteBatch.Draw(bg, Vector2.Zero, Color.White);
            Model._map.Draw();
            Model._player.Draw();
            Globals._spriteBatch.End();
        }
    }
}
