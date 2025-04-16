using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace base_game
{
    internal class Model
    {
        public View _view;
        public Controller _controller;
        public static Player _player;
        public static Map _map;

        public Model() 
        {
            _view = new View();
            _controller = new Controller();
            _player = new Player(Vector2.Zero,"player");
            _map = new Map(100,70,10);
            _map.Generate();
        }

        public void Update()
        {
            _controller.UpdateState();
            _player.Move(_controller._keyboardState);
            _view.CalculateTranslation(_player.position);
        }

        public void Draw() => _view.Draw();
    }
}
