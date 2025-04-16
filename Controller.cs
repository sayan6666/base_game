using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace base_game
{
    internal class Controller
    {
        public KeyboardState _keyboardState;
        public MouseState _mouseState;

        public void UpdateState()
        {
            _keyboardState=Keyboard.GetState();
            _mouseState=Mouse.GetState();
        }

    }
}
