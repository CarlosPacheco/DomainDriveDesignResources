using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DDDResourcesWizard
{
    public partial class OptionsForm : Form
    {
        private IEnumerable<string> _projectList;

        public OptionsForm(IEnumerable<string> projectList)
        {
            InitializeComponent();

            _projectList = projectList;
        }

        public bool HaveControllersProject
        {
            get
            {
                return chkHaveControllersProject.Checked;
            }
        }

        public bool HaveApplicationProject
        {
            get
            {
                return chkHaveApplicationProject.Checked;
            }
        }

        public bool HaveBusinessProject
        {
            get
            {
                return chkHaveBusinessProject.Checked;
            }
        }

        public bool HaveDataProject
        {
            get
            {
                return chkHaveDataProject.Checked;
            }
        }

        public bool HaveDataTransferObjectsProject
        {
            get
            {
                return chkHaveDataTransferObjectsProject.Checked;
            }
        }

        public bool HaveEntitiesProject
        {
            get
            {
                return chkHaveEntitiesProject.Checked;
            }
        }

        public string SelectedDataProject
        {
            get
            {
                return DataProject.SelectedValue.ToString();
            }
        }

        public string SelectedBusinessProject
        {
            get
            {
                return BusinessProject.SelectedValue.ToString();
            }
        }

        public string SelectedControllersProject
        {
            get
            {
                return ControllersProject.SelectedValue.ToString();
            }
        }

        public string SelectedApplicationProject
        {
            get
            {
                return ApplicationProject.SelectedValue.ToString();
            }
        }

        public string SelectedDataTransferObjectsProject
        {
            get
            {
                return DataTransferObjectsProject.SelectedValue.ToString();
            }
        }

        public string SelectedEntitiesProject
        {
            get
            {
                return EntitiesProject.SelectedValue.ToString();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            ControllersProject.DataSource = ApplicationProject.DataSource = DataTransferObjectsProject.DataSource = BusinessProject.DataSource = EntitiesProject.DataSource = DataProject.DataSource = _projectList.ToList();

            ControllersProject.SelectedItem = _projectList.FirstOrDefault(it => it.Contains("Core"));
            ApplicationProject.SelectedItem = _projectList.FirstOrDefault(it => it.Contains("Application"));
            DataTransferObjectsProject.SelectedItem = _projectList.FirstOrDefault(it => it.Contains("Data.TransferObjects"));
            BusinessProject.SelectedItem = _projectList.FirstOrDefault(it => it.Contains("Business"));
            EntitiesProject.SelectedItem = _projectList.FirstOrDefault(it => it.Contains("Business"));
            DataProject.SelectedItem = _projectList.FirstOrDefault(it => it.Contains("Data.AccessObjects"));        

            base.OnLoad(e);
        }
    }
}
