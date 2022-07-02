using Design_Patterns.Structurals.Facade;

namespace Design_Patterns.PatternsRunners
{
    internal class FacadeRun
    {
        public FacadeRun()
        {
            AudioService audioService = new AudioService();
            VideoService videoService = new VideoService(); 
            Facade facadeRun = new Facade(audioService, videoService);

            facadeRun.ConvertVideo();
        }
    }
}