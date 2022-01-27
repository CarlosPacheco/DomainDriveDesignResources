using System.Collections.Generic;
using EnvDTE;
using EnvDTE80;

namespace DDDResourcesWizard
{
    public static class DteExtentions
    {
        /// <summary>
        /// Gets the project item.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="name">The name of the project item.</param>
        /// <param name="kind">The kind of project item located in EndDTE.Constatns class.</param>
        public static ProjectItem GetProjectItem(this ProjectItems projectItems, string name, string kind)
        {
            foreach (ProjectItem item in projectItems)
            {
                if (item.Name == name && item.Kind == kind)
                {
                    return item;
                }
            }

            return null;
        }

        /// <summary>
        /// Adds project item to folder.
        /// </summary>
        /// <param name="proj">The project.</param>
        /// <param name="item">The project item.</param>
        /// <param name="folder">The destination folder.</param>
        public static void AddToFolder(this Project proj, ProjectItem item, List<string> folders)
        {
            try
            {
                ProjectItems folderItems = proj.ProjectItems;

                foreach (string folder in folders)
                {
                    ProjectItem folderItem = folderItems.GetProjectItem(folder, Constants.vsProjectItemKindPhysicalFolder);

                    folderItem = folderItem ?? folderItems.AddFolder(folder);

                    folderItems = folderItem.ProjectItems;
                }

                folderItems.AddFromFileCopy(item.FileNames[0]);
            }
            catch (System.Exception)
            {
            }
        }

        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <param name="solution">The solution.</param>
        public static IEnumerable<Project> GetProjects(this Solution solution)
        {
            List<Project> projectList = new List<Project>();
            foreach (Project project in solution.Projects)
            {
                if (project.Kind == ProjectKinds.vsProjectKindSolutionFolder)
                {
                    projectList.AddRange(GetSolutionFolderProjects(project));
                }
                else
                {
                    projectList.Add(project);
                }
            }

            return projectList;
        }

        private static IEnumerable<Project> GetSolutionFolderProjects(Project solutionFolder)
        {
            List<Project> list = new List<Project>();

            foreach (ProjectItem item in solutionFolder.ProjectItems)
            {
                if (item.SubProject != null)
                {
                    var subProject = item.SubProject;

                    if (subProject.Kind == ProjectKinds.vsProjectKindSolutionFolder)
                    {
                        list.AddRange(GetSolutionFolderProjects(subProject));
                    }
                    else
                    {
                        list.Add(subProject);
                    }
                }
            }

            return list;
        }
    }
}