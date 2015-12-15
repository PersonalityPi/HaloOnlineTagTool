using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineTagTool.Common;
using HaloOnlineTagTool.Resources;
using HaloOnlineTagTool.Serialization;

namespace HaloOnlineTagTool.TagStructures
{
    [TagStructure(Name = "shader_halogram", Class = "rmhg", Size = 0x4)]
    public class ShaderHalogram : RenderMethod
    {
        public uint Unknown8;
    }
}
