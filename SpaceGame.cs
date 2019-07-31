using SplashKitSDK;

public class SpaceGame {
        private Ship a;
        private Window _gameWindow;

        public SpaceGame () {
            LoadGraphics ();
            a = new Ship { X = 110, Y = 110 };
        }

        private void LoadGraphics () {
            SplashKit.LoadBitmap ("Bullet", "Fire.png");
            SplashKit.LoadBitmap ("Gliese", "Gliese.png");
            SplashKit.LoadBitmap ("Pegasi", "Pegasi.png");
            SplashKit.LoadBitmap ("Aquarii", "Aquarii.png");
        }

        public void HandleInput () {
            _gameWindow = new Window ("BlastOff", 600, 600);
            while (!_gameWindow.CloseRequested) {
                SplashKit.ProcessEvents ();
                if (SplashKit.KeyDown (KeyCode.UpKey)) {
                    a.Move (4, 0);
                }
                if (SplashKit.KeyDown (KeyCode.DownKey)) {
                    a.Move (-4, 0);
                }
                if (SplashKit.KeyDown (KeyCode.LeftKey)) {
                    a.Rotate (-4);
                }
                if (SplashKit.KeyDown (KeyCode.RightKey)) {
                    a.Rotate (4);
                }
                if (SplashKit.KeyTyped (KeyCode.SpaceKey)) {
                    a.Shoot ();
                }
                a.TODORENAME ();
                Draw ();
            }
            _gameWindow.Close ();
            _gameWindow = null;
            }

        private void Draw () {
            _gameWindow.Clear (Color.Black);
            a.Draw ();
            _gameWindow.Refresh (60);
        }
    }