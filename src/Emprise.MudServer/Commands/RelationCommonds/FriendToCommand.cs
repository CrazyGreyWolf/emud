﻿using Emprise.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emprise.MudServer.Commands.RelationCommonds
{

    public class FriendToCommand : Command
    {
        public int PlayerId { get; set; }
        public int RelationId { get; set; }
        public FriendToCommand(int playerId, int relationId)
        {
            PlayerId = playerId;
            RelationId = relationId;
        }
    }
}
