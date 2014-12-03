using NAudio.Wave;
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
        NAudio.Wave.WaveFileWriter waveWriter = null;

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
            ButtonOpenWaveFile.Enabled = false;
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

        protected void Button2_mic_Click(object sender, EventArgs e)
        {
            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                Label4_microphone.Text = "Number of device: " + waveInDevice.ToString()
                + " Device name: "
                + deviceInfo.ProductName.ToString() 
                + " Device info channels: "
                +  deviceInfo.Channels.ToString();

                TextBox1.Text = "Number of device: " + waveInDevice.ToString()
                + " Device name: "
                + deviceInfo.ProductName.ToString()
                + " Device info channels: "
                + deviceInfo.Channels.ToString();

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            //The DataAvailable event handler will notify us whenever 
            //a buffer of audio has been returned to us from the sound card.
            //The data comes back as an array of bytes, 
            //representing PCM sample data

            // if we were recording in stereo, the 16 bit samples would themselves come in pairs, 
            //first the left sample, then the right sample.
            for (int index = 0; index < e.BytesRecorded; index += 2)
            {
                short sample = (short)((e.Buffer[index + 1] << 8) |
                                        e.Buffer[index + 0]);
                float sample32 = sample / 32768f;
                //ProcessSample(sample32);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            WaveIn waveIn = new WaveIn();
            waveIn.DeviceNumber = 0;
            waveIn.DataAvailable += waveIn_DataAvailable;
            int sampleRate = 8000; // 8 kHz
            int channels = 1; // mono
            waveIn.WaveFormat = new WaveFormat(sampleRate, channels);
            waveIn.StartRecording();
        }

        protected void Button3_record_Click(object sender, EventArgs e)
        {

        }
    }
}