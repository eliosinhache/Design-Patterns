using System;

namespace Design_Patterns.Structurals.Facade
{
    public class VideoService
    {
        internal string Initialize()
        {
            return "VideoService Ready! \n";
        }

        internal string PrepareVideo()
        {
            return "Video Prepared \n";
        }
    }
}