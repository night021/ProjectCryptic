using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCryptic 
{
    //For all of Object in Scene
    public class Sprite
    {
        private Texture2D texture;
        public Vector2 position;

        public int speed = 2;

        public int posX = 0;
        public int posY = 200;

        public Sprite(Texture2D texture2)
        {
            texture = texture2;
        }

        public void Update()
        {
            if(Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                {
                   posX -= speed;
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {

                posX += speed;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, destinationRectangle: new Rectangle(posX, posY, 400, 400));
        }

    }
}
