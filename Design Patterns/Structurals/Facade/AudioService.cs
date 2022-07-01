using System;

namespace Design_Patterns.Structurals.Facade
{
    public class AudioService
    {
        internal string Initialize()
        {
            return "AudioService Ready! \n";
        }

        internal string PrepareAudio()
        {
            return "Audio Prepared \n";
        }
    }
}