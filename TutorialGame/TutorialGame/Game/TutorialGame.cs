using System;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace TutorialGame
{
    public class TutorialGame : GameLoop
    {
        public const uint WINDOW_WIDTH = 640;
        public const uint WINDOW_HEIGHT = 480;
        public const string WINDOW_TITLE = "Tutorial Game";
        public static Color WINDOW_COLOR = Color.Black;
        public static Styles WINDOW_STYLE = Styles.Default;

        public TutorialGame() : base (WINDOW_WIDTH, WINDOW_HEIGHT, WINDOW_TITLE, WINDOW_COLOR, WINDOW_STYLE)
        {
            
        }

        public override void LoadContent()
        {
            DebugUtility.LoadContent();
        }

        public override void Initialize()
        {
        }

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw(GameTime gameTime)
        {
            DebugUtility.DrawPerformanceData(this, Color.White);
        }
    }
}
