﻿#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class TransferRequest
    {
        public string ownId { get; set; }
        public int amount { get; set; }
        public string description { get; set; }
        public Transferinstrument transferInstrument { get; set; }
    }
}
