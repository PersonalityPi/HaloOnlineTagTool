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
	[TagStructure(Class = "cprl", Size = 0x10)]
	public class ChudWidgetParallaxData
	{
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public uint Unknown4;
	}
}
