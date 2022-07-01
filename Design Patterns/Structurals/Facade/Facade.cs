using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structurals.Facade
{
    public class Facade
    {
        protected AudioService audioSystem;
        protected VideoService videoSystem;
        public Facade(AudioService audioService, VideoService videoService)
        {
            this.audioSystem = audioService;
            this.videoSystem = videoService;
        }

        public void ConvertVideo()
        {
            string operations = "Facade Starts To Initialize Subsystems.. \n";
            operations += audioSystem.Initialize();
            operations += videoSystem.Initialize();
            operations += "\nFacade Orders subsystems to perform the actions: \n";
            operations += audioSystem.PrepareAudio();
            operations += videoSystem.PrepareVideo();
            operations += "\nVideo Converted Succufully!";
            Console.WriteLine(operations);
        }
    }
}
