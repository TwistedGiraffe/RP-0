﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RP0.ModuleTags
{
    public class ModuleTagDecoupler : ModuleTag
    {
        public override string GetInfo()
        {
            string str = string.Empty;
            str = "Contains a decoupler that requires extensive integration and testing which increase the overall Rollout Cost.\n\n" +
                "<b><color=orange>Rollout Cost: Cost of This Part * 3.0</color></b>";
            return str;
        }
    }
}
