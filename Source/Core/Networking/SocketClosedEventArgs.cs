﻿using System;

namespace XenForms.Core.Networking
{
    public class SocketClosedEventArgs : EventArgs
    {
        public string UniqueId { get; set; }
        public string Address { get; set; }
    }
}
