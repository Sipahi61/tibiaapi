namespace Tibia.Addresses
{
    /// <summary>
    /// Client addresses not specific to a player.
    /// </summary>
    public static class Client
    {
        /// <summary>
        /// The system time in ms when the client was started.
        /// Used for Creatures.Distance_BlackSquare calculations.
        /// </summary>
        public static uint StartTime = 0x77BA3C;

        /// <summary>
        /// Address to the XTea encryption key.
        /// </summary>
        public static uint XTeaKey = 0x776DB4;

        /// <summary>
        /// FPS (Frames Per Second) Pointer
        /// </summary>
        public static uint FrameRatePointer = 0x77AF3C;

        /// <summary>
        /// Current fps offset
        /// </summary>
        public static int FrameRateCurrentOffset = 0x0;

        /// <summary>
        /// FPS limit offset
        /// </summary>
        public static int FrameRateLimitOffset = 0x58;

        /// <summary>
        /// Address to activate multiclient.
        /// </summary>
        public static uint MultiClient = 0x100CE4;

        /// <summary>
        /// Value to be written to the multiclient address.
        /// </summary>
        public static uint MultiClientValue = 0xEB;

        /// <summary>
        /// 8 = Connected | 0 = Disconnected
        /// </summary>
        public static uint Status = 0x77A3F8;

        /// <summary>
        /// Safe mode (don't attack other players)
        /// </summary>
        public static uint SafeMode = 0x7771D0;
        /// <summary>
        /// Follow mode while attacking (Follow, keep distance, stand still)
        /// </summary>
        public static uint FollowMode = SafeMode + 4;

        /// <summary>
        /// Attack type (Full attack, half and half, full defense)
        /// </summary>
        public static uint AttackMode = FollowMode + 4;

        /// <summary>
        /// Action state (formerly MouseCursor icon)
        /// </summary>
        public static uint ActionState = 0x77A458;

        /// <summary>
        /// The window that is foremost
        /// </summary>
        public static uint CurrentWindow = 0x62CABC;

        /// <summary>
        /// The last player to send a message to the default channel.
        /// </summary>
        public static uint LastMSGAuthor = LastMSGText - 0x28; //8.1, 8.0 = 0x768680

        /// <summary>
        /// The text of the last message sent to the default channel.
        /// </summary>
        public static uint LastMSGText = 0x76DB78; //8.1, 8.0 = 0x7686A8

        /// <summary>
        /// The statusbar text to be displayed.
        /// </summary>
        public static uint Statusbar_Text = 0x77BA58;
        /// <summary>
        /// The time that the text will be displayed for in the statusbar.
        /// </summary>
        public static uint Statusbar_Time = Statusbar_Text - 4; 

        /// <summary>
        /// The id of the last clicked item.
        /// </summary>
        public static uint Click_Id = 0x76C364;   //8.1, 8.0 = 0x766E94
        /// <summary>
        /// The amount of the last clicked item (eg. 52 fish)
        /// </summary>
        public static uint Click_Count = Click_Id + 4;  //8.1, 8.0 = 0x766E98
        /// <summary>
        /// The floor that was clicked.
        /// </summary>
        public static uint Click_Z = Click_Id - 0x68;      //8.1, 8.0 = 0x766E2C

        /// <summary>
        /// The id of the last item seen (looked at).
        /// </summary>
        public static uint See_Id = Click_Id + 12;     //8.1, 8.0 = 0x766EA0
        /// <summary>
        /// The amount of the last item seen (eg. 42 fish).
        /// </summary>
        public static uint See_Count = See_Id + 4;  //8.1, 8.0 = 0x766EA4
        /// <summary>
        /// The floor that the last seen item is on.
        /// </summary>
        public static uint See_Z = See_Id - 0x68;      //8.1, 8.0 = 0x766E00
        /// <summary>
        /// The text that came with the last seen item (eg. You see a fish).
        /// </summary>
        public static uint See_Text = 0x76DB50;     //8.1
        

        // Login Server addresses
        public static uint LoginServerStart = 0x0771CF0;
        public static uint Step_LoginServer = 112;
        public static uint Distance_Port = 100;
        public static uint Max_LoginServers = 10;

        /// <summary>
        /// RSA Key Adress
        /// </summary>
        public static uint RSA = 0x5A3610;
		  
        /// <summary>
        /// Login character list. This points to the character list.
        /// </summary>
        public static uint LoginCharList = 0x77A3BC;

        /* Character List Format
        
        30 bytes - Character name, null terminated string
        30 bytes - Server name, null terminated string
        4 bytes - Binary IP, the IP address in hex
        16 bytes - IP string, null terminated string of the IP address
        2 bytes - Port number
        2 bytes - Padding
        
        */

        /// <summary>
        /// Login character list selected character. This address doesn't move.
        /// </summary>
        public static uint LoginSelectedChar = 0x77A3B8;

        //This format is for the character list that is stored at 0x76450D.
        //This format is also how it comes in the packet.
        //This list gets overwritten with different data when connected to the game world.
        
        /* Character List Format
        
        2 bytes - Length of name
        n bytes - Name
        
        2 bytes - Length of sever name
        n bytes - Server name
        
        4 bytes - IP address
        2 bytes - Port number
        
        */


        /// <summary>
        /// Pointer to an address. When that address has 0x4E added to
        /// it, it points to the game window rect 
        /// struct.
        /// </summary>
        public static uint GameWindowRectPointer = 0x12D624; //8.1
        /*
            Several notes are needed on this one.
            1) This address is in the stack so it is very volitile. However it appears
               that it does not change as long as the player stays logged in.
            2) This address is always in the same place as long as the player
               is logged in.
            3) This address points to another address. Once you obtain that address
               you must add 0x4E and that will point to the begining of the struct.
         
            Struct Layout (each 4 bytes):
            X, Y, Width, Height
        */

        public static uint DatPointer = 0x768C9C; // 8.11

        public static uint DialogBegin = 0x61E984; // 8.11
        public static uint DialogLeft = 0x14;
        public static uint DialogTop = 0x18;
        public static uint DialogWidth = 0x1C;
        public static uint DialogHeight = 0x20;
        public static uint DialogCaption = 0x50;


        /// <summary>
        /// Auto login stuff
        /// </summary>
        public static uint LoginPassword = 0x77A3C4; // 8.2
        public static uint LoginAccountStr = LoginPassword + 32; // 8.2
        public static uint LoginAccountNum = LoginAccountStr + 12; // 8.2

        public static uint LoginPatch = 0x47935E; // 8.11
        public static uint LoginPatch2 = 0x47A2B3; // 8.11

        public static byte Nop = 0x90;
        public static byte[] LoginPatchOrig = new byte[] { 0xE8, 0x0D, 0x1D, 0x09, 0x00 };
        public static byte[] LoginPatchOrig2 = new byte[] { 0xE8, 0xC8, 0x15, 0x09, 0x00 };
    }
}