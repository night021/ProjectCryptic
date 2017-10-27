using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProjectCryptic
{
    public class Game1 : Game
    {
        //PlayerGraphic
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Keyboard

        //Object
        private player player;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void OnActivated(object sender, EventArgs args)
        {
            Window.Title = "Cryptic";

            //Setting Graphic First
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.ApplyChanges();
            graphics.IsFullScreen = true;
            base.OnActivated(sender, args);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            var texture = Content.Load<Texture2D>("Idle1");//Load

            //Player
            player = new player(texture);
            {
                player.posX = 400;
                player.posY = 200;
            }

            
        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            player.Update();



            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //Control
            KeyboardState state = Keyboard.GetState();


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            
            //Generate player
            player.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
