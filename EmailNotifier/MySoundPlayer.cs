using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EmailNotifier
{
    class MySoundPlayer
    {

        //lets see mci documention
        //we need to find signature of this api function
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        // so here we are defining wind32 api function exists in winmm.dll
        // now lets add some functions

        string playerIdentifier;
        public MySoundPlayer(string Identifier)
        {
            playerIdentifier = Identifier;
        }

        void open(string SoundFile)
        {
            // here we will send command to MCI using mcisendstring
            //open command format is 
            //open filepath type MPEGVideo alias playeridentifier
            string command = string.Format("open \"{0}\" type MPEGVideo alias {1}", 
                SoundFile, 
                playerIdentifier);

            mciSendString(command,null,0,IntPtr.Zero);
            // so here we have initialized our player"

        }

        void play()
        {
            //now we can play the file by sending play command to MCI
            //play command format is
            //play playeridentifier
            string command = string.Format("play {0}", playerIdentifier);
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        void stop()
        {
            //now we will send stop command to stop currently playing file
            //format of stop command is 
            //stop playerindetifier
            string command = string.Format("stop {0}", playerIdentifier);
            mciSendString(command, null, 0, IntPtr.Zero);
           
        }

        void close()
        {
            //now we will send close player command to MCI
            //close command format is
            //close playerindetifier
            string command = string.Format("close {0}", playerIdentifier);
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void PlaySound(string SoundFilePath)
        {
            stop();
            close();
            //this have to be done because if player is already playing file it will 
            //not play another file. so we have to send stop and send commands
            open(SoundFilePath);
            play();

        }
        //now our player is ready lets create some Alert UI 
        //which will be later used by our object to show alerts.
    }
}
