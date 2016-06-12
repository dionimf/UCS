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

namespace UCS.PacketProcessing.Commands
{
    internal class ToggleHeroAttackModeCommand : Command
    {
        #region Public Constructors

        public ToggleHeroAttackModeCommand(BinaryReader br)
        {
            /*
            BuildingId = br.ReadUInt32WithEndian(); //buildingId - 0x1DCD6500;
            Unknown1 = br.ReadByte();
            Unknown2 = br.ReadUInt32WithEndian();
            Unknown3 = br.ReadUInt32WithEndian();
            */
        }

        #endregion Public Constructors

        #region Public Properties

        public uint BuildingId { get; set; }
        public byte Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        public uint Unknown3 { get; set; }

        #endregion Public Properties
    }
}