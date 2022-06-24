using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace DrumPad
{
    class Sound
    {
        public Sound(string soundName)
        {
            var soundFile = Path.Join(Windows.ApplicationModel.Package.Current.InstalledLocation.Path, "Assets/Sounds", soundName);
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }
    }
}
