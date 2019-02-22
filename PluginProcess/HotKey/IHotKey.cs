﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lanotalium.Plugin.Simple.HotKey
{
    public interface IHotKey
    {
        void OnPressSingle();
        void OnPressLong();
        void OnPressDouble();
    }
}
