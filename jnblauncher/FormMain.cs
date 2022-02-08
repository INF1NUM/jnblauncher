using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace jnblauncher
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string mapsDirectory = $"{Application.StartupPath}\\data";
        private string jnbExePath = $"{Application.StartupPath}\\jumpnbump.exe";
        private List<Map> maps;

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (!Directory.Exists(mapsDirectory))
            {
                MessageBox.Show("Maps directory is not exist: " + mapsDirectory, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }

            string[] mapsArray = Directory.GetFiles(mapsDirectory, "*.dat", SearchOption.TopDirectoryOnly);

            if(mapsArray.Length == 0)
            {
                MessageBox.Show($"Maps directory is empty: {mapsDirectory}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }

            maps = new List<Map>();

            foreach (string mapDir in mapsArray)
                maps.Add(new Map(mapDir));

            comboBoxMap.DataSource = maps;
            comboBoxMap.DisplayMember = "FileName";
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (!File.Exists(jnbExePath))
            {
                MessageBox.Show("File 'jumpnbump.exe' is not found: " + jnbExePath, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }

            Process jnb = new Process();
            jnb.StartInfo.FileName = jnbExePath;
            jnb.StartInfo.Verb = "runas";

            if(checkBoxLoadMap.Checked)
                jnb.StartInfo.Arguments += $" -dat \"{(comboBoxMap.SelectedItem as Map).FullPath}\"";
            if (checkBoxScaleup.Checked)
                jnb.StartInfo.Arguments += " -scaleup";
            if (checkBoxFullscreen.Checked)
                jnb.StartInfo.Arguments += " -fullscreen";
            if(checkBoxSoundOff.Checked)
                jnb.StartInfo.Arguments += " -nosound";
            if(checkBoxNoSfx.Checked)
                jnb.StartInfo.Arguments += " -musicnosound";
            if(checkBoxFamilyMode.Checked)
                jnb.StartInfo.Arguments += " -nogore";
            if(checkBoxNoFlies.Checked)
                jnb.StartInfo.Arguments += " -noflies";

            try
            {
                if (jnb.Start() == true)
                    Environment.Exit(0);
            }
            catch (Win32Exception ex)
            {
                if(!ex.NativeErrorCode.Equals(1223))
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxLoadMap_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                comboBoxMap.Enabled = true;
            else
                comboBoxMap.Enabled = false;
        }
    }
}
