using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSM.Commands.Data
{
    /// <summary>
    /// Command to sync mods using the hosting server as the target mod state.
    /// </summary>
    [ProtoContract]    
    public class SyncModsCommand : CommandBase
    {
        /// <summary>
        /// List of mods currently on the server.
        /// </summary>
        [ProtoMember(1)]
        public List<string> Mods { get; set; }
    }
}
