﻿namespace Tibia.Objects
{
    public partial class AddressesCollection
    {
        public ContextMenusAddresses ContextMenus = new ContextMenusAddresses();

        public class ContextMenusAddresses
        {
            /// <summary>
            /// The function used to add a context menu item.
            /// </summary>
            public uint AddContextMenuPtr;

            /// <summary>
            /// The function used to process Tibia's "OnClick" events,
            /// that is, the events issued when you click a context
            /// menu item.
            /// </summary>
            public uint OnClickContextMenuPtr;

            /// <summary>
            /// The address in the virtual function table where the
            /// "OnClick" event for context menu items is.
            /// This address should be overwritten with a raw address,
            /// that is, the unmodified address of the function to be
            /// called when a "OnClick" event is issued.
            /// Moreover, it is HIGHLY (by highly I mean DO IT if you
            /// want to avoid sure trouble) recommended that you call
            /// OnClickContextMenuPtr from your hooked function to
            /// process standard Tibia events.
            /// </summary>
            public uint OnClickContextMenuVf;

            /// <summary>
            /// The "Set Outfit" context menu item function call.
            /// Overwrite it if you want to add a context menu item
            /// that is specific to your character
            /// </summary>
            public uint AddSetOutfitContextMenu;

            /// <summary>
            /// The "Invite to Party" / "Leave Party" context menu
            /// item function call.
            /// Overwrite it if you want to add a context menu item
            /// that is specific to other players.
            /// </summary>
            [System.Obsolete]
            public uint AddPartyActionContextMenu;

            /// <summary>
            /// The "Copy Name" context menu item function call.
            /// Overwrite it if you want to add a context menu item
            /// that is specific to creatures (including you and monsters).
            /// </summary>
            public uint AddCopyNameContextMenu;

            public uint AddTradeWithContextMenu;

            /// <summary>
            /// The "Look" context menu item function call.
            /// Overwrite it if you want to add a context menu item
            /// that always appears on game window or inventory item clicks.
            /// </summary>
            public uint AddLookContextMenu;

        }
    }
}