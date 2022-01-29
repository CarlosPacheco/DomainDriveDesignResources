using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TemplateWizard;

namespace DomainDriveDesignResourcesVSIX
{
    public enum LayerName
    {
        Controller,
        Services,
        Business,
        DataInterfaces,
        Data,
        DataTransferObjects,
        SearchFilters,
        EntityModel
    }

    public class Layer
    {
        public string Name { get; set; }
        public List<string> Folders { get; set; }
        public Project Project { get; set; }
        public bool CreateModelFolder { get; set; }
        public string Namespace
        {
            get
            {
                string foldersPath = string.Join(".", Folders);
                return $"{Project.Name}{(string.IsNullOrWhiteSpace(foldersPath) ? string.Empty : "." + foldersPath)}";
            }
        }

        public Layer(string name, List<string> folders, Project project, bool createModelFolder = false)
        {
            Name = name;
            Folders = folders;
            Project = project;
            CreateModelFolder = createModelFolder;
        }

        public Layer()
        {
        }
    }

    public class WizardImplementation : IWizard
    {
        #region Fields
        IDictionary<LayerName, Layer> layers = new Dictionary<LayerName, Layer>();
        private readonly DTE _dte;
        private IEnumerable<Project> _allProjects;
        #endregion

        #region Ctor

        public WizardImplementation()
        {
            _dte = (DTE)Package.GetGlobalService(typeof(DTE));
        }

        #endregion

        #region IWizard Methods

        // This method is only called for item templates,
        // not for project templates.
        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            string itemName = Path.GetFileNameWithoutExtension(projectItem.Name);
            Layer selectedLayer = null;

            foreach (Layer layer in layers.Values)
            {
                if (layer.Project == null) continue;

                if (itemName.Equals(layer.Name))
                {
                    selectedLayer = layer;
                    break;
                }

                if (itemName.EndsWith(layer.Name) || itemName.EndsWith($"{layer.Name}.Querys"))
                {
                    selectedLayer = layer;
                    break;
                }
            }

            if(selectedLayer != null)
                selectedLayer.Project.AddToFolder(projectItem, selectedLayer.Folders);

            projectItem?.Remove();
            projectItem?.Delete();
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            _allProjects = _dte.Solution.GetProjects();

            OptionsForm form = new OptionsForm(_allProjects.Select(it => it.Name));
            form.ShowDialog();

            // Format the model name in case when someone typed 'eMploYeE' instead of 'Employee'
            string _modelName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(replacementsDictionary["$safeitemname$"]);
            string _modelNameFolder = _modelName + "s";

            if (form.HaveControllersProject) layers.Add(LayerName.Controller, new Layer($"{_modelName}Controller", new List<string> { "Controllers", _modelNameFolder }, GetProjectByName(form.SelectedControllersProject), true));
            if (form.HaveApplicationProject) layers.Add(LayerName.Services, new Layer($"{_modelName}Service", new List<string> { "Services", _modelNameFolder }, GetProjectByName(form.SelectedApplicationProject), true));
            if (form.HaveBusinessProject) layers.Add(LayerName.Business, new Layer($"{_modelName}Blo", new List<string> { "LogicObjects", _modelNameFolder }, GetProjectByName(form.SelectedBusinessProject), true));
            if (form.HaveDataProject) layers.Add(LayerName.DataInterfaces, new Layer($"I{_modelName}Dao", new List<string> { "Interfaces", "Data", "AccessObjects", _modelNameFolder }, GetProjectByName(form.SelectedBusinessProject), true));
            if (form.HaveDataProject) layers.Add(LayerName.Data, new Layer($"{_modelName}Dao", new List<string> { _modelNameFolder }, GetProjectByName(form.SelectedDataProject), true));
            if (form.HaveDataTransferObjectsProject) layers.Add(LayerName.DataTransferObjects, new Layer($"{_modelName}Dto", new List<string>(), GetProjectByName(form.SelectedDataTransferObjectsProject), false));
            if (form.HaveEntitiesProject) layers.Add(LayerName.EntityModel, new Layer(_modelName, new List<string> { "Entities" }, GetProjectByName(form.SelectedEntitiesProject), false));
            if (form.HaveEntitiesProject) layers.Add(LayerName.SearchFilters, new Layer($"{_modelName}SearchFilter", new List<string> { "SearchFilters" }, GetProjectByName(form.SelectedEntitiesProject), false));

            SetParameters(replacementsDictionary);
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        // This method is called before opening any item that
        // has the OpenInEditor attribute.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is called after the project is created.
        public void RunFinished()
        {
        }

        #endregion

        #region Private Methods       

        private void SetParameters(Dictionary<string, string> replacementsDictionary)
        {
            string _modelName = layers[LayerName.EntityModel].Name;

            replacementsDictionary.Add("$basename$", _modelName);
            replacementsDictionary.Add("$propname$", string.Concat("_", char.ToLowerInvariant(_modelName[0]), _modelName.Substring(1), layers[LayerName.Data].Name));

            replacementsDictionary.Add("$EntityModelNamespace$", layers[LayerName.EntityModel].Namespace);
            replacementsDictionary.Add("$SearchFiltersNamespace$", layers[LayerName.SearchFilters].Namespace);
            replacementsDictionary.Add("$DataTransferObjectsNamespace$", layers[LayerName.DataTransferObjects].Namespace);
            replacementsDictionary.Add("$ControllerNamespace$", layers[LayerName.Controller].Namespace);
            replacementsDictionary.Add("$ServiceNamespace$", layers[LayerName.Services].Namespace);
            replacementsDictionary.Add("$BuisnessNamespace$", layers[LayerName.Business].Namespace);
            replacementsDictionary.Add("$DataInterfacesNamespace$", layers[LayerName.DataInterfaces].Namespace);
            replacementsDictionary.Add("$DataNamespace$", layers[LayerName.Data].Namespace);
        }

        private Project GetProjectByName(string projectName)
        {
            return _allProjects.FirstOrDefault(it => it.Name == projectName);
        }

        #endregion
    }
}