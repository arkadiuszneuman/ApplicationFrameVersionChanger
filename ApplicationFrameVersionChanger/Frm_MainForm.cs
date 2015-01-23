using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationFrameVersionChanger.AssemblyElementGetter;
using ApplicationFrameVersionChanger.CsprojFinder;
using ApplicationFrameVersionChanger.CurrentVersionFinder;
using ApplicationFrameVersionChanger.FileTextLoader;
using ApplicationFrameVersionChanger.FileTextSaver;
using ApplicationFrameVersionChanger.RootNamespaceGetter;
using ApplicationFrameVersionChanger.VersionChanger;
using ApplicationFrameVersionChanger.VersionChanger.AssemblyInfoChanger;
using ApplicationFrameVersionChanger.VersionChanger.DocumentationElementGetter;
using ApplicationFrameVersionChanger.VersionChanger.TFSFileCheckouter;
using DevExpress.XtraEditors;

namespace ApplicationFrameVersionChanger
{
    public partial class Frm_MainForm : XtraForm
    {
        public Frm_MainForm()
        {
            InitializeComponent();
            LoadCurrentVersion();
        }

        private void frtxtSlnPath_EditValueChanged(object sender, EventArgs e)
        {
            LoadCurrentVersion();
        }

        private void LoadCurrentVersion()
        {
            if (File.Exists(frtxtSlnPath.Text))
            {
                Cl_CurrentVersionFinder vrlCurrentVersionFinder = new Cl_CurrentVersionFinder(new Cl_CsprojFinder(), new Cl_FileTextLoader(), new Cl_AssemblyElementGetter(), new Cl_RootNamespaceGetter());
                string vrlCurrentVersion = vrlCurrentVersionFinder.GetCurrentVersion(frtxtSlnPath.Text);
                frtxtVersion.Text = vrlCurrentVersion;
            }
            else
            {
                frtxtVersion.Text = string.Empty;
            }
        }

        private void btnChangeVersion_Click(object sender, EventArgs e)
        {
            Cl_TFSFileCheckout vrlTFSFileCheckout = new Cl_TFSFileCheckout(Path.GetDirectoryName(frtxtSlnPath.Text));
            Cl_AssemblyInfoChanger vrlAssemblyInfoChanger = new Cl_AssemblyInfoChanger(vrlTFSFileCheckout, new Cl_FileTextLoader(), new Cl_FileTextSaver());

            Cl_VersionChanger vrlVersionChanger = new Cl_VersionChanger(new Cl_CsprojFinder(), new Cl_AssemblyElementGetter(), new Cl_RootNamespaceGetter(), vrlTFSFileCheckout, vrlAssemblyInfoChanger, new Cl_DocumentationFileElementGetter());
            vrlVersionChanger.ChangeVersion(frtxtSlnPath.Text, frtxtVersion.Text, frbitTfs.Checked);
        }
    }
}
