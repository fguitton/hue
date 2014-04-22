﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using HueSaturation.API.UPNP;

namespace HueSaturation.API.Hue
{
    public class BridgeManager
    {
        public Bridge CurrentBridge { get; set; }
        public List<Bridge> DiscoveredBridges { get; set; }

        private static volatile BridgeManager instance;
        private static object syncRoot = new Object();

        private BridgeManager() { }

        /// <summary>
        /// Constructor
        /// </summary>
        public static BridgeManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new BridgeManager();
                    }
                }

                return instance;
            }
        }

        
    }
}
