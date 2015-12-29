﻿using HaloOnlineTagTool.TagStructures;

namespace HaloOnlineTagTool.Commands.Bitmaps
{
    static class BitmapContextFactory
    {
        public static CommandContext Create(CommandContext parent, OpenTagCache info, TagInstance tag, Bitmap bitmap)
        {
            var groupName = info.StringIds.GetString(tag.GroupName);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, bitmap);

            return context;
        }

        public static void Populate(CommandContext context, OpenTagCache info, TagInstance tag, Bitmap bitmap)
        {
            context.AddCommand(new ImportCommand(info, tag, bitmap));
        }
    }
}
