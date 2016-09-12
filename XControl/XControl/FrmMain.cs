using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;

namespace XControl
{
    public partial class FrmMain : Form
    {
        private GamePadState _currentGamePadState;

        private bool dpadRelease;
        private bool dpadIsHeld;

        public FrmMain()
        {
            InitializeComponent();

            dpadRelease = true;
            dpadIsHeld = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _currentGamePadState = GamePad.GetState(PlayerIndex.One);
            xloop.Start();
        }

        private void xloop_Tick(object sender, EventArgs e)
        {
            int mouseX = MouseOperations.GetCursorPosition().X;
            int mouseY = MouseOperations.GetCursorPosition().Y;

            _currentGamePadState = GamePad.GetState(PlayerIndex.One);

            string debug = _currentGamePadState.Buttons
                           + "\n" +
                           _currentGamePadState.Triggers
                           + "\n" +
                           _currentGamePadState.DPad
                           + "\n" +
                           _currentGamePadState.ThumbSticks;

            lblDebug.Text = debug;

            MoveMouse(mouseX, mouseY, _currentGamePadState.ThumbSticks.Left, _currentGamePadState.Triggers.Right);

            HandleClicks();

            HandleDPad();
        }

        private void MoveMouse(int mouseX, int mouseY, Vector2 leftThumbStick, float rightTrigger)
        {
            int xPos = (int)(mouseX + (10 * leftThumbStick.X) * (1 + rightTrigger * 2));
            int yPos = (int)(mouseY + (-10 * leftThumbStick.Y) * (1 + rightTrigger * 2));

            MouseOperations.SetCursorPosition(new MouseOperations.MousePoint(xPos, yPos));
        }

        private void HandleClicks()
        {
            MouseState currentMouseState = Mouse.GetState();

            // LEFT CLICK
            if (_currentGamePadState.IsButtonDown(Buttons.A))
            {
                if (currentMouseState.LeftButton == ButtonState.Released)
                {
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                }
            }
            else
            {
                if (currentMouseState.LeftButton == ButtonState.Pressed)
                {
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                }
            }

            // RIGHT CLICK
            if (_currentGamePadState.IsButtonDown(Buttons.B))
            {
                if (currentMouseState.RightButton == ButtonState.Released)
                {
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightDown);
                }
            }
            else
            {
                if (currentMouseState.RightButton == ButtonState.Pressed)
                {
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightUp);
                }
            }

            // MIDDLE CLICK
            if (_currentGamePadState.IsButtonDown(Buttons.X))
            {
                if (currentMouseState.MiddleButton == ButtonState.Released)
                {
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleDown);
                }
            }
            else
            {
                if (currentMouseState.MiddleButton == ButtonState.Pressed)
                {
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);
                }
            }
        }

        private void HandleDPad()
        {
            // ARROW UP
            if (_currentGamePadState.IsButtonDown(Buttons.DPadUp) && dpadRelease)
            {
                KeyboardOperations.PressDirection("up");
                dpadRelease = false;
            }
            else if (_currentGamePadState.IsButtonUp(Buttons.DPadUp))
            {
                dpadRelease = true;
            }

            // ARROW RIGHT
            if (_currentGamePadState.IsButtonDown(Buttons.DPadRight) && dpadRelease)
            {
                KeyboardOperations.PressDirection("right");
                dpadRelease = false;
            }
            else if (_currentGamePadState.IsButtonUp(Buttons.DPadRight))
            {
                dpadRelease = true;
            }

            // ARROW DOWN
            if (_currentGamePadState.IsButtonDown(Buttons.DPadDown) && dpadRelease)
            {
                KeyboardOperations.PressDirection("down");
                dpadRelease = false;
            }
            else if (_currentGamePadState.IsButtonUp(Buttons.DPadDown))
            {
                dpadRelease = true;
            }

            // ARROW LEFT
            if (_currentGamePadState.IsButtonDown(Buttons.DPadLeft) && dpadRelease)
            {
                KeyboardOperations.PressDirection("left");
                dpadRelease = false;
            }
            else if (_currentGamePadState.IsButtonUp(Buttons.DPadLeft))
            {
                dpadRelease = true;
            }
        }
    }
}
