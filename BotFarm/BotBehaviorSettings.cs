﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFarm
{
    [Serializable]
    public struct BotBehaviorSettings
    {
        public bool AutoAcceptGroupInvites;
        public bool AutoAcceptResurrectRequests;
    }
}
