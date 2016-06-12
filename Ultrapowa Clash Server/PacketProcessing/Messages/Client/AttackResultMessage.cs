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

using System;
using System.IO;
using System.Text;
using UCS.Logic;

namespace UCS.PacketProcessing.Messages.Client
{
    internal class AttackResultMessage : Message
    {
        #region Public Constructors

        public AttackResultMessage(PacketProcessing.Client client, BinaryReader br)
            : base(client, br)
        {
        }

        #endregion Public Constructors

        #region Public Methods

        public override void Decode()
        {
            Console.WriteLine("Packet Attack Result : " + Encoding.UTF8.GetString(GetData()));
        }

        public override void Process(Level level)
        {
        }

        #endregion Public Methods
    }
}