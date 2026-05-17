using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using robotfight.Properties;

namespace robotfight
{
    public class Sounds
    {
        private WaveOutEvent outputDevice;
        private WaveFileReader waveReader;
        public void PlayMusic()
        {
            // Convert resource to stream
            var stream = Resources.backMusic;
            waveReader = new WaveFileReader(stream);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(waveReader);
            outputDevice.Play();
        }
        public void PlayVineBoom()
        {
            var stream = Resources.vineboom;

            var waveReader = new WaveFileReader(stream);
            var outputDevice = new WaveOutEvent();
            outputDevice.Init(waveReader);
            outputDevice.Play();
            outputDevice.PlaybackStopped += (s, e) =>
            {
                waveReader.Dispose();
                outputDevice.Dispose();
            };
        }
    }
}
