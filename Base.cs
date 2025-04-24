using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace base_game
{
    internal class Base
    {
        private float hp;
        private float damage;
        private Texture2D spriteMain;
        private Texture2D spriteCannon;
        private Vector2 positionMain;
        private Vector2 positionCannon;
        private double rotation;
        private Beam beam;
        public bool isControlled;

        public Base(string mainTextureName, string cannonTextureName, float hp, float damage, Vector2 positionMain, Vector2 positionCannon) 
        {
            this.hp = hp;
            this.damage = damage;
            this.positionMain = positionMain;
            this.positionCannon = positionCannon;
            rotation = 0.0d;
            isControlled = false;
            spriteMain = Globals._contentManager.Load<Texture2D>(mainTextureName);
            spriteCannon = Globals._contentManager.Load<Texture2D>(cannonTextureName);
            beam = new Beam(new Vector2((float)(this.positionCannon.X), (float)(this.positionCannon.Y)), "beam");
        }

        public void Control(Controller controller)
        {
            if (controller._keyboardState.IsKeyDown(Keys.W)) { rotation += 0.005; beam.rotation += 0.005; }
                if (controller._keyboardState.IsKeyDown(Keys.S)) { rotation -= 0.005; beam.rotation -= 0.005; }
            if (controller._keyboardState.IsKeyDown(Keys.Q)) { beam.used = true; }
        }

        public void Interact(KeyboardState _state, Player player)
        {
            if (_state.IsKeyDown(Keys.E))
            {
                if (((player.position.X <= positionMain.X + spriteMain.Width + 50 && player.position.X >= positionMain.X - 50) && (player.position.Y <= positionMain.Y + spriteMain.Height + 50 && player.position.Y >= positionMain.Y - 50))
                    && isControlled == false)
                {
                    isControlled = true;
                    player.speed = 0;
                }
                else if (isControlled == true)
                {
                    isControlled = false;
                    player.speed = 10;
                }
            }
        }

        public void Draw()
        {
            Globals._spriteBatch.Draw(spriteMain, positionMain, Color.White);
            beam.Draw();
            Globals._spriteBatch.Draw(spriteCannon,new Rectangle( (int)positionCannon.X, (int)positionCannon.Y, spriteCannon.Width, spriteCannon.Height), null, Color.White, (float)rotation, new Vector2(spriteCannon.Width/2, spriteCannon.Height/2), SpriteEffects.None, 0);
        }
    }
}
