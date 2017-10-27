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
    public class player
    {
        //For only player
        //For all of Object in Scene
        private Texture2D mainPlayer;
        public Vector2 position;

        //Movement
        public int speed = 1;
        public int posX = 0;
        public int posY = 0;

        //Animation
        string turning = "right";

        public player(Texture2D texture2)
        {
            mainPlayer = texture2;
        }

        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                turning = "right";
                if (posX >= 350)
                {
                    posX -= speed;
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                turning = "left";
                if (posX <= 450)
                {
                    posX += speed ;
                }
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(mainPlayer, destinationRectangle: new Rectangle(posX, posY, 400, 400));
        }

    }
}
