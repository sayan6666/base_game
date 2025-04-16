using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace base_game
{
    internal class Globals
    {
        public static SpriteBatch _spriteBatch { get; set; }
        public static ContentManager _contentManager { get; set; }
        public static GraphicsDeviceManager _graphics { get; set; }

    }
}
