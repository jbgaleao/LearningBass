using System;
using System.IO;
using System.Media;

namespace LearningBass
{
    public class Som
    {
        public Som(Action<Stream> exec)
        {
        }

        public static void Exec(Stream strm)
        {
            SoundPlayer SonidoOK = new SoundPlayer(strm);
            SonidoOK.Play();
        }
    }
}
