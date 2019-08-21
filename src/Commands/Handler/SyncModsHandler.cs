using CSM.Commands.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSM.Networking;

namespace CSM.Commands.Handler
{
    public class SyncModsHandler : CommandHandler<SyncModsCommand>
    {
        public override void Handle(SyncModsCommand command)
        {
            var mask = SteamHelper.GetOwnedDLCMask();
            foreach(var dlc in mask.DLCs())
            {
                // Checks availability on the server?
                if(SteamHelper.IsDLCAvailable(dlc))
                {
                    //TODO: GET DLC
                }
            }
        }
    }
}
