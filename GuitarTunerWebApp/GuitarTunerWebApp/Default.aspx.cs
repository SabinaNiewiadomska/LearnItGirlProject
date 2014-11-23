using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GuitarTunerWebApp
{
    public partial class _Default : Page
    {
        private NAudio.Wave.WaveFileReader waveReader = null;
        private NAudio.Wave.DirectSoundOut waveOutPut = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "I'm lazy button, now I do nothing!";
        }

        protected void ButtonOpenWaveFile_Click(object sender, EventArgs e)
        {
            //EASY WAY TO UPLOAD FILE
            FileUpload1.SaveAs(Server.MapPath("upload/") + FileUpload1.FileName);
            Label2.Text = FileUpload1.FileName;
            
            DisposeWave(); 

            waveReader = new NAudio.Wave.WaveFileReader(Server.MapPath("upload/") + FileUpload1.FileName);
            waveOutPut = new NAudio.Wave.DirectSoundOut();
            waveOutPut.Init(new NAudio.Wave.WaveChannel32(waveReader));// ?! Init initialize playback ?!
            waveOutPut.Play();

            ButtonPlayPause.Enabled = true;
            //ADVANCED WAY TO UPLOAD FILE
            //string[] validFileTypes = { "aac" };
            //string ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            //bool isValidFile = false;
            //for (int i = 0; i < validFileTypes.Length; i++)
            //{
            //    if (ext == "." + validFileTypes[i])
            //    {
            //        isValidFile = true;
            //        break;
            //    }
            //}
            //if (!isValidFile)
            //{
            //    Label2.ForeColor = System.Drawing.Color.Red;
            //    Label2.Text = "Invalid File. Please upload a File with extension " +
            //                   string.Join(",", validFileTypes);
            //}
            //else
            //{
            //    Label2.ForeColor = System.Drawing.Color.Green;
            //    Label2.Text = FileUpload1.FileName + " File uploaded successfully.";
            //}
        }

        //method
        private void DisposeWave()
        {
            if (waveOutPut != null)
            {
                if (waveOutPut.PlaybackState == NAudio.Wave.PlaybackState.Playing) waveOutPut.Stop();
                waveOutPut.Dispose(); // ?! check dispose meaning ?!
                waveOutPut = null;
            }

            if(waveReader != null)
            {
                waveReader.Dispose();
                waveReader = null;
            }
        }
        protected void ButtonPlayPause_Click(object sender, EventArgs e)
        {
            DisposeWave();
        }
    }
}