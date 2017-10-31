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
        public int speed = 2;
        public int playerPosX = 400;
        public int playerPosY = 200;

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
                playerPosX += speed;
                if (playerPosX >= 450)
                {
                    playerPosX = 450; 
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                turning = "left";
                playerPosX -= speed;
                if (playerPosX <= 350)
                {
                    playerPosX = 350;
                }
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(mainPlayer, destinationRectangle: new Rectangle(playerPosX, playerPosY, 400, 400));
        }

    }
}
