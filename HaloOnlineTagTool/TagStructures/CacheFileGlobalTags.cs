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
	[TagStructure(Class = "cfgt", Size = 0x10)]
	public class CacheFileGlobalTags
	{
		public List<UnknownBlock> Unknown;
		public uint Unknown2;

		[TagStructure(Size = 0x10)]
		public class UnknownBlock
		{
			public HaloTag Unknown;
		}
	}
}
