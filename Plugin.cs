using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.Commands.PluginManager;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using Exiled.API.Interfaces;
using Exiled.Events.Features;

namespace Broadcasts
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "Volokno";
        public override string Name => "jump";
        public override string Prefix => "jump";
        public override Version Version => base.Version;

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Verified += OnVerified;
            base.OnEnabled();

            Exiled.Events.Handlers.Player.Jumping += OnPlayerJumping;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= OnVerified;
            base.OnDisabled();

            Exiled.Events.Handlers.Player.Jumping += OnPlayerJumping;
            base.OnDisabled();        }
        private void OnVerified(VerifiedEventArgs ev)
        {
            if (ev.Player == null && ev.Player.IsNPC && ev.Player.IsHost)
                return;
        }
        private void OnPlayerJumping(JumpingEventArgs ev)
        {

            if (ev.Player == null)
                return;

            ev.Player.Broadcast(Config.Duration, Config.Textjump);
        }

    }
}