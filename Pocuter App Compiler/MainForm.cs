using System.Security.Cryptography;
using System.Text;

namespace Pocuter_App_Compiler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAppProjectBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogApp.ShowDialog() == DialogResult.OK)
            {
                textBoxAppProject.Text = folderBrowserDialogApp.SelectedPath;
            }
        }

        private void buttonBrowseAppIcon_Click(object sender, EventArgs e)
        {
            if (openFileDialogIcon.ShowDialog() == DialogResult.OK)
            {
                textBoxAppIconPath.Text = openFileDialogIcon.FileName;
                Image newImage = Image.FromFile(openFileDialogIcon.FileName);
                if (newImage.Size.Width != 16 || newImage.Size.Height != 16)
                {
                    MessageBox.Show("Image must be 16x16 pixels.");
                    return;
                }
                pictureBoxAppIcon.Image = newImage;
            }
        }

        private void buttonOutputBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogApp.ShowDialog(this) == DialogResult.OK)
            {
                textBoxOutputPath.Text = folderBrowserDialogApp.SelectedPath;
            }
        }

        private void checkBoxInstall_CheckedChanged(object sender, EventArgs e)
        {
            numericIP_A.Enabled = checkBoxInstall.Checked;
            numericIP_B.Enabled = checkBoxInstall.Checked;
            numericIP_C.Enabled = checkBoxInstall.Checked;
            numericIP_D.Enabled = checkBoxInstall.Checked;
        }

        private void buttonCompile_Click(object sender, EventArgs e)
        {
            if (textBoxAppProject.Text == "")
            {
                MessageBox.Show("Please select project path.");
                return;
            }

            if (textBoxAppName.Text == "")
            {
                MessageBox.Show("Please enter an app name.");
                return;
            }

            if (textBoxAppAuthor.Text == "")
            {
                MessageBox.Show("Please enter an app author.");
                return;
            }

            if (numericAppID.Value == 0)
            {
                MessageBox.Show("Please choose an app ID.");
                return;
            }

            if (!checkBoxOutputApps.Checked && !checkBoxInstall.Checked)
            {
                MessageBox.Show("Please select either Output to Apps Folder or Install on Pocuter Wirelessly.");
                return;
            }

            if (checkBoxOutputApps.Checked && textBoxOutputPath.Text == "")
            {
                MessageBox.Show("Please select an output Apps folder.");
                return;
            }

            if (checkBoxInstall.Checked && numericIP_A.Value == 0)
            {
                MessageBox.Show("Please select an IP address. (Make sure the Pocuter is running the Code Upload Server app too!)");
                return;
            }

            progressBar.Value = 20;
            progressBar.Update();
            processArduino.StartInfo.Arguments = "compile \"" + textBoxAppProject.Text + "\" -b esp32:esp32:pocuterone -e";
            processArduino.StartInfo.RedirectStandardError = true;
            processArduino.Start();
            processArduino.WaitForExit();
            if (processArduino.ExitCode != 0)
            {
                string output = "STDOUT:\n" + processArduino.StandardOutput.ReadToEnd() + "\n\nSTDERR:\n" + processArduino.StandardError.ReadToEnd();
                File.WriteAllText("arduino-output-log.txt", output);
                MessageBox.Show("Failed to compile. Error " + processArduino.ExitCode + ". See arduino-output-log.txt for more info.");
                return;
            }

            progressBar.Value = 40;
            progressBar.Update();
            string iniFile = "[APPDATA]\n";
            iniFile += "Name=" + textBoxAppName.Text + "\n";
            iniFile += "Author=" + textBoxAppAuthor.Text + "\n";

            if (pictureBoxAppIcon.Image != null)
            {
                Bitmap iconBitmap = new Bitmap(pictureBoxAppIcon.Image);

                byte[] pixels = new byte[16 * 16 * 4];
                for (int x = 0; x < 16; x++)
                {
                    for (int y = 0; y < 16; y++)
                    {
                        Color color = iconBitmap.GetPixel(x, y);
                        pixels[(y * 16 * 4) + (x * 4) + 0] = color.B;
                        pixels[(y * 16 * 4) + (x * 4) + 1] = color.G;
                        pixels[(y * 16 * 4) + (x * 4) + 2] = color.R;
                        pixels[(y * 16 * 4) + (x * 4) + 3] = 255;
                    }
                }
                iniFile += "AppIcon=" + Convert.ToBase64String(pixels) + "\n";
            }

            progressBar.Value = 60;
            progressBar.Update();
            try
            {
                File.WriteAllText("app.ini", iniFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to write app.ini: " + ex.Message);
                progressBar.Value = 0;
                return;
            }

            try
            {
                File.Copy(textBoxAppProject.Text + "/build/esp32.esp32.pocuterone/" + new DirectoryInfo(textBoxAppProject.Text).Name + ".ino.bin", "app.bin", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to copy app.bin: " + ex.Message);
                progressBar.Value = 0;
                return;
            }

            progressBar.Value = 80;
            progressBar.Update();
            string converterArgs = "-id " + numericAppID.Value;
            converterArgs += " -version " + numericVersionMaj.Value + "." + numericVersionMin.Value + "." + numericVersionPatch.Value;
            converterArgs += " -image app.bin -meta app.ini";

            processAppConverter.StartInfo.Arguments = converterArgs;
            processAppConverter.StartInfo.RedirectStandardError = true;
            processAppConverter.Start();
            processAppConverter.WaitForExit();

            if (processAppConverter.ExitCode != 0)
            {
                string output = "STDOUT:\n" + processAppConverter.StandardOutput.ReadToEnd() + "\n\nSTDERR:\n" + processAppConverter.StandardError.ReadToEnd();
                File.WriteAllText("converter-output-log.txt", output);
                MessageBox.Show("Failed to compile. Error " + processAppConverter.ExitCode + ". See converter-output-log.txt for more info.");
                progressBar.Value = 0;
                return;
            }

            if (checkBoxOutputApps.Checked)
            {
                try
                {
                    Directory.CreateDirectory(textBoxOutputPath.Text + "/" + numericAppID.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create output directory: " + ex.Message);
                    progressBar.Value = 0;
                    return;
                }

                try
                {
                    File.Copy("apps/" + numericAppID.Value + "/esp32c3.app", textBoxOutputPath.Text + "/" + numericAppID.Value + "/esp32c3.app", true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to copy output file: " + ex.Message);
                    progressBar.Value = 0;
                    return;
                }
            }

            if (checkBoxInstall.Checked)
            {
                if (!UploadToPocuter())
                    return;
            }

            progressBar.Value = 100;
            progressBar.Update();
            MessageBox.Show("Success!");
            progressBar.Value = 0;
        }

        bool UploadToPocuter()
        {
            try
            {
                byte[] pocuterUploadFile = File.ReadAllBytes("apps/" + numericAppID.Value + "/esp32c3.app");

                /*
                 * Manually generate a POST request because it is very specific about what it wants to receive.
                 */
                HttpClient client = new HttpClient();

                string uploadHost = "http://" +
                    numericIP_A.Value.ToString() + "." +
                    numericIP_B.Value.ToString() + "." +
                    numericIP_C.Value.ToString() + "." +
                    numericIP_D.Value.ToString();
                string uploadUrl = uploadHost + "/upload";

                string filePath = "apps/" + numericAppID.Value + "/esp32c3.app";

                byte[] md5Hash = MD5.HashData(pocuterUploadFile);
                string hashString = BitConverter.ToString(md5Hash).Replace("-", "").ToLower();

                string boundaryStr = "418777386925025282742009286339";
                string boundary = "-----------------------------" + boundaryStr + "\r\n";
                string requestBody = "";
                requestBody += boundary;
                boundary = "\r\n" + boundary;
                requestBody += "Content-Disposition: form-data; name=\"appID\"\r\n";
                requestBody += "\r\n";
                requestBody += numericAppID.Value.ToString();
                requestBody += boundary;
                requestBody += "Content-Disposition: form-data; name=\"appMD5\"\r\n";
                requestBody += "\r\n";
                requestBody += hashString;
                requestBody += boundary;
                requestBody += "Content-Disposition: form-data; name=\"appSize\"\r\n";
                requestBody += "\r\n";
                requestBody += pocuterUploadFile.Length.ToString();
                requestBody += boundary;
                requestBody += "Content-Disposition: form-data; name=\"appImage\"; filename=\"" + filePath + "\"\r\n";
                requestBody += "Content-Type: application/octet-stream\r\n";
                requestBody += "\r\n";

                byte[] requestContentsBytes = Encoding.UTF8.GetBytes(requestBody);
                byte[] requestFileBytes = File.ReadAllBytes(filePath);
                byte[] boundaryBytes = Encoding.UTF8.GetBytes("\r\n-----------------------------" + boundaryStr + "--\r\n");
                byte[] requestBytes = new byte[requestContentsBytes.Length + requestFileBytes.Length + boundaryBytes.Length];
                Array.Copy(requestContentsBytes, 0, requestBytes, 0, requestContentsBytes.Length);
                Array.Copy(requestFileBytes, 0, requestBytes, requestContentsBytes.Length, requestFileBytes.Length);
                Array.Copy(boundaryBytes, 0, requestBytes, requestContentsBytes.Length + requestFileBytes.Length, boundaryBytes.Length);

                ByteArrayContent byteContent = new ByteArrayContent(requestBytes);
                byteContent.Headers.Add("Content-Type", "multipart/form-data; boundary=---------------------------418777386925025282742009286339");

                HttpResponseMessage response = client.PostAsync(uploadUrl, byteContent).Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("[2] Failed to send app to Pocuter: " + response.ReasonPhrase);
                    return false;
                }

                byteContent.Dispose();
                client.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send app to Pocuter: " + ex.Message);
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    MessageBox.Show(ex.Message);
                }
                progressBar.Value = 0;
                return false;
            }

            return true;
        }

        private void processArduino_Exited(object sender, EventArgs e)
        {

        }

        private void checkBoxOutputApps_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOutputPath.Enabled = checkBoxOutputApps.Checked;
            buttonOutputBrowse.Enabled = checkBoxOutputApps.Checked;
        }
    }
}