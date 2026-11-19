using System;
using System.Resources;
using Mainframe.Scripts.Game;

namespace Microgames.MPM_Danse
{
    public class MPM_DanseMicrogame : Mainframe.Scripts.Microgame.Microgame
    {
        public override string GetInstruction()
        {
            return "Run !";
        }

        public override float GetDuration()
        {
            return 5f;
        }

        public override bool IsFinished()
        {
            return false;
        }

        public override bool IsSuccess()
        {
            return true;
        }

        public override void Setup()
        {
            base.Setup();
        }

        public override void Begin()
        {
            base.Begin();
            Game.Input.OnButtonPerformed.AddListener(Onbutton);
        }

        public override void End()
        {
            base.End();
        }

        public override void Cleanup()
        {
            base.Cleanup();
        }

        private void Update()
        {
            if (Game.Input.GetButtonPressed())
            {
                
            }

            if (Game.Input.GetJoystick().y > 0.5)
            {
                
            }
        }

        void Onbutton(bool buttonPressed)
        {
            onWin?.Invoke();
            onLose?.Invoke();
        }
    }
}