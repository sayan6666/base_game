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
        public static Base _base;

        public Model() 
        {
            _view = new View();
            _controller = new Controller();
            _map = new Map(100, 70, 10);
            _player = new Player(new Vector2((float)((_map.size/2)*_map.tile1.size), (float)(((_map.size / 2) * _map.tile1.size)+(_map.tile1.size*2))),"player");
            _base = new Base("base", "cannon", 100.0f, 1.0f, new Vector2((float)((_map.size / 2)*_map.tile1.size), (float)((_map.size / 2) * _map.tile1.size)), new Vector2((float)(((_map.size / 2) * _map.tile1.size)+150), (float)(((_map.size / 2) * _map.tile1.size)+150)));
            _map.Generate();
        }

        public void Update()
        {
            _controller.UpdateState();
            _player.Move(_controller._keyboardState);
            _base.Interact(_controller._keyboardState,_player);
            if (_base.isControlled)
                _base.Control(_controller);
            _view.CalculateTranslation(_player.position);
        }

        public void Draw() => _view.Draw();
    }
}
