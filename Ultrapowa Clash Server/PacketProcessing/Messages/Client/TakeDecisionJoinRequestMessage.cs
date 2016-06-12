﻿/*
 * Program : Ultrapowa Clash Server
 * Description : A C# Writted 'Clash of Clans' Server Emulator !
 *
 * Authors:  Jean-Baptiste Martin <Ultrapowa at Ultrapowa.com>,
 *           And the Official Ultrapowa Developement Team
 *
 * Copyright (c) 2016  UltraPowa
 * All Rights Reserved.
 */

using System.IO;
using UCS.Logic;

namespace UCS.PacketProcessing.Messages.Client
{
    internal class TakeDecisionJoinRequestMessage : Message
    {
        #region Public Constructors

        public TakeDecisionJoinRequestMessage(PacketProcessing.Client client, BinaryReader br) : base(client, br)
        {
        }

        #endregion Public Constructors

        #region Public Methods

        public override void Decode()
        {
            // Console.WriteLine(Encoding.UTF8.GetString(GetData()));
        }

        public override void Process(Level level)
        {
            // PacketManager.ProcessOutgoingPacket(new DecisionJoinRequestMessage(Client));
        }

        #endregion Public Methods
    }
}