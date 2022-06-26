using System;
using System.Collections.Generic;
using System.Media;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrumPadApp
{
    class Sound
    {
        public Sound(string soundName)
        {
            var soundFile = Path.Join(Windows.ApplicationModel.Package.Current.InstalledLocation.Path, "Assets/Sounds", soundName);
            SoundPlayer player = new SoundPlayer(soundFile);
            player.Play();
        }
    }
}
