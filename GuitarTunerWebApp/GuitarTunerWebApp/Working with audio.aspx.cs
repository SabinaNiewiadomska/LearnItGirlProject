using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GuitarTunerWebApp
{
    public partial class Working_with_audio : System.Web.UI.Page
    {
        private NAudio.Wave.WaveFileReader waveReader = null;
        private NAudio.Wave.DirectSoundOut waveOutPut = null;
        private NAudio.Wave.BlockAlignReductionStream stream = null;
        //it takes uncompresed data from mp3 and make from it a table of data 
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            
            FileUpload1.SaveAs(Server.MapPath("upload/") + FileUpload1.FileName);
            LabelMP3.Text = FileUpload1.FileName;

            DisposeWave();

            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(FileUpload1.FileName));
            //streamMP3 = new NAudio.Wave.BlockAlignReductionStream(pcm);
            waveReader = new NAudio.Wave.WaveFileReader(Server.MapPath("upload/") + FileUpload1.FileName);
            waveOutPut = new NAudio.Wave.DirectSoundOut();
            waveOutPut.Init(new NAudio.Wave.WaveChannel32(waveReader));// ?! Init initialize playback ?!
            waveOutPut.Play();

            ButtonPauseMP3.Enabled = true;
        }

        private void DisposeWave()
        {
            if (waveOutPut != null)
            {
                if (waveOutPut.PlaybackState == NAudio.Wave.PlaybackState.Playing) waveOutPut.Stop();
                waveOutPut.Dispose(); // ?! check dispose meaning ?!
                waveOutPut = null;
            }

            if (waveReader != null)
            {
                waveReader.Dispose();
                waveReader = null;
            }
        }

        protected void ButtonPauseMP3_Click(object sender, EventArgs e)
        {
            ButtonPauseMP3.Enabled = false;
        }
    }
}